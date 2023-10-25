using System;
using TaskManagementSystem.Lib.Model;

namespace TaskManagementSystem.BLL.Interfaces
{
	public interface IDutyRepository
    {
		Task<IList<Duty>> GetAllDuties();

		Task<Duty> GetDuty(int id);

		Task<Duty> AddDuty(Duty newDuty);

		Task<Duty> UpdateDuty(Duty updatedDuty);

		void DeleteDuty(int id);
	}
}

