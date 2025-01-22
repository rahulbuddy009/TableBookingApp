using LSC.ResturantTableBookingApp.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.ResturantTableBookingApp.Service
{
    public interface IResturantService
    {
        Task<List<ResturantModels>> GetAllResturantsAsync();
        Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId);
        Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId, DateTime date);
        Task<IEnumerable<ResturantBranchModel>> GetResturantBranchByResturantIdAsync(int resturantId);
    }
}
