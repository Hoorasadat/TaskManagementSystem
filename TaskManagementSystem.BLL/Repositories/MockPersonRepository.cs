using System;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.BLL.Interfaces;
using TaskManagementSystem.Data.Data;
using TaskManagementSystem.Lib.Models;

namespace TaskManagementSystem.BLL.Repositories
{
	public class MockPersonRepository : IPersonRepository
	{
        private readonly MemoryDbContext _context;

        public MockPersonRepository(MemoryDbContext context)
		{
            _context = context;
            SeedData();
        }



        public async Task<Person> AddPerson(Person newPerson)
        {
            var person = await _context.Persons.AddAsync(newPerson);

            await _context.SaveChangesAsync();

            return person.Entity;
        }


        public Task<Person> DeletePerson(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<IList<Person>> GetAllPersons()
        {
            IList<Person> persons = await _context.Persons.ToListAsync<Person>();

            return persons;
        }


        public async Task<Person> GetPerson(int id)
        {
            Person person = await _context.Persons.FirstOrDefaultAsync(x => x.Id == id);

            return person;
        }


        public async Task<Person> UpdatePerson(Person updatedPerson)
        {
            Person person = await _context.Persons.FirstOrDefaultAsync(x => x.Id == updatedPerson.Id);

            if (person == null)
                return null;

            person.Name = updatedPerson.Name;

            _context.Persons.Update(person);

            await _context.SaveChangesAsync();

            return person;
        }



        public void SeedData()
        {
            if(!_context.Persons.Any())
            {
                Person person1 = new Person()
                {
                    Id = 1,
                    Name = "Morteza"
                };

                Person person2 = new Person()
                {
                    Id = 2,
                    Name = "Hoora"
                };

                _context.Persons.AddRange(person1, person2);
                _context.SaveChanges();
            }
        }
    }
}
