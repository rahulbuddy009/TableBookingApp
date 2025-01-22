using LSC.ResturantTableBookingApp.Core.ViewModel;
using LSC.ResturantTableBookingApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.ResturantTableBookingApp.Service
{
    public class ResturantService : IResturantService
    {
        private readonly IResturantRepository resturantRepository;
        public ResturantService(IResturantRepository resturantRepository)
        {
            this.resturantRepository=resturantRepository;
            
        }
        public Task<List<ResturantModels>> GetAllResturantsAsync()
        {
           return  resturantRepository.GetAllResturantAsync();
        }

        public async Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId)
        {
            return await resturantRepository.GetDiningTablesByBranchAsync(branchId);
        }

        public async Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId, DateTime date)
        {
            return await resturantRepository.GetDiningTablesByBranchAsync(branchId, date);
        }

        public async Task<IEnumerable<ResturantBranchModel>> GetResturantBranchByResturantIdAsync(int resturantId)
        {
            return await resturantRepository.GetResturantBranchByResturantIdAsync(resturantId);
        }
    }
}
