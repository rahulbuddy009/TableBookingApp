using LSC.ResturantTableBookingApp.Core.ViewModel;
using LSC.ResturantTableBookingApp.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LSC.ResturantTableBookingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResturantController : ControllerBase
    {
        private readonly IResturantService _resturantService;
        public ResturantController(IResturantService resturantService)
        {
            _resturantService = resturantService;
            
        }

        [HttpGet("resturant")]
        [ProducesResponseType(200,Type = typeof(List<ResturantModels>))]
        public async Task<ActionResult> GetAllResturant()
        {
            var resturants=await _resturantService.GetAllResturantsAsync();

            return Ok(resturants);
        }

        [HttpGet("branches/{resturantId}")]
        [ProducesResponseType(200, Type=typeof(IEnumerable<ResturantBranchModel>))]
        [ProducesResponseType(404)]

        public async Task<ActionResult<IEnumerable<ResturantBranchModel>>> GetResturantBranchesByResturantIdAsync(int resturantId)
        {
            var branches = await _resturantService.GetResturantBranchByResturantIdAsync(resturantId);
            if (branches == null)
            {
                return NotFound();
            }
            return Ok(branches);
        }

        [HttpGet("diningtables/{branchId}/{date}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<DiningTableWithTimeSlotsModel>))]
        [ProducesResponseType(404)]

        public async Task<ActionResult<IEnumerable<DiningTableWithTimeSlotsModel>>> GetDiningTablesByBranchAndDateAsync (int branchId,DateTime date)
        {
            var diningTables = await _resturantService.GetDiningTablesByBranchAsync(branchId,date);
            if (diningTables == null)
            {
                return NotFound();
            }
            return Ok(diningTables);
        }

        [HttpGet("diningtables/{branchId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<DiningTableWithTimeSlotsModel>))]
        [ProducesResponseType(404)]

        public async Task<ActionResult<IEnumerable<DiningTableWithTimeSlotsModel>>> GetDiningTablesByBranchIdAsync(int branchId)
        {
            var diningTables = await _resturantService.GetDiningTablesByBranchAsync(branchId);
            if (diningTables == null)
            {
                return NotFound();
            }
            return Ok(diningTables);
        }
    }
}
