using System;
using TaskManagementSystem.Lib.Models;

namespace TaskManagementSystem.BLL.Interfaces
{
	public interface IDutyRepository
    {
		Task<IList<Duty>> GetAllDuties();

		Task<Duty> GetDuty(int id);

		Task<Duty> AddDuty(Duty newDuty);

		Task<Duty> UpdateDuty(Duty updatedDuty);

        Task<Duty> DeleteDuty(int id);
	}
}

