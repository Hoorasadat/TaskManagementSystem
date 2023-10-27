using System;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.BLL.Interfaces;
using TaskManagementSystem.Data.Data;
using TaskManagementSystem.Lib.Models;

namespace TaskManagementSystem.BLL.Repositories
{
	public class MockDutyRepository : IDutyRepository
    {
        private readonly MemoryDbContext _context;

        public MockDutyRepository(MemoryDbContext context) 
		{
            _context = context;
            SeedData();
        }



        public async Task<Duty> AddDuty(Duty newDuty)
        {
            var duty = await _context.Duties.AddAsync(newDuty);

            await _context.SaveChangesAsync();

            return duty.Entity;
        }


        public async Task<Duty> DeleteDuty(int id)
        {
            Duty duty = await _context.Duties.FirstOrDefaultAsync(x => x.Id == id);

            if (duty == null)
                return null;
            _context.Duties.Remove(duty);

            await _context.SaveChangesAsync();

            return duty;
        }


        public async Task<IList<Duty>> GetAllDuties()
        {
            IList<Duty> duties = await _context.Duties.ToListAsync<Duty>();
            return duties;
        }


        public async Task<Duty> GetDuty(int id)
        {
            Duty duty = await _context.Duties.FirstOrDefaultAsync(x => x.Id == id);

            return duty;
        }


        public async Task<Duty> UpdateDuty(Duty updatedDuty)
        {
            Duty duty = await _context.Duties.FirstOrDefaultAsync(x => x.Id == updatedDuty.Id);

            if (duty == null)
                return null;

            duty.Id = updatedDuty.Id;
            duty.Title = updatedDuty.Title;
            duty.Description = updatedDuty.Description;
            duty.DueDate = updatedDuty.DueDate;
            duty.Priority = updatedDuty.Priority;
            duty.Status = updatedDuty.Status;
            duty.PersonID = updatedDuty.PersonID;

            _context.Duties.Update(duty);

            await _context.SaveChangesAsync();

            return duty;
        }



        public void SeedData()
        {
            if (!_context.Duties.Any())
            {
                Duty duty1 = new Duty()
                {
                    Id = 1,
                    Title = "Calling Bank",
                    Priority = Priority.Normal,
                    Status = Status.InProgress,
                    PersonID = 1
                };

                Duty duty2 = new Duty()
                {
                    Id = 2,
                    Title = "Changing tires",
                    Priority = Priority.High,
                    Status = Status.NotStarted,
                    PersonID = 2
                };

                Duty duty3 = new Duty()
                {
                    Id = 3,
                    Title = "Applying for jobs",
                    Priority = Priority.Normal,
                    Status = Status.InProgress,
                    PersonID = 1
                };

                _context.Duties.AddRange(duty1, duty2, duty3);
                _context.SaveChanges();
            }
        }

    }
}

