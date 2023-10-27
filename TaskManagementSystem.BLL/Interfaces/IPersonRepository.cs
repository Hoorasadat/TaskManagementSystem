using System;
using TaskManagementSystem.Lib.Models;

namespace TaskManagementSystem.BLL.Interfaces
{
	public interface IPersonRepository
	{
		Task<IList<Person>> GetAllPersons();

		Task<Person> GetPerson(int id);

		Task<Person> AddPerson(Person newPerson);

		Task<Person> UpdatePerson(Person updatedPerson);

		void DeletePerson(int id);
	}
}

