using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSC.ResturantTableBookingApp.Core.ViewModel;

namespace LSC.ResturantTableBookingApp.Data
{
    public interface IResturantRepository
    {
        /// <summary>
        /// GetAllResturantAsync
        /// </summary>
        /// <returns></returns>
        Task<List<ResturantModels>> GetAllResturantAsync();

        /// <summary>
        /// GetResturantByResturantIdAsync
        /// </summary>
        /// <param name="resturantId"></param>
        /// <returns></returns>
        Task<IEnumerable<ResturantBranchModel>> GetResturantBranchByResturantIdAsync(int resturantId);

        /// <summary>
        /// GetDiningTablesByBranchAsync
        /// </summary>
        /// <param name="branchId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId, DateTime date);

        /// <summary>
        /// GetDiningTablesByBranchAsync
        /// </summary>
        /// <param name="branchId"></param>
        /// <returns></returns>
        Task<IEnumerable<DiningTableWithTimeSlotsModel>> GetDiningTablesByBranchAsync(int branchId);

    }
}
