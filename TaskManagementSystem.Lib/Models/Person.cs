using System;
namespace TaskManagementSystem.Lib.Models
{
	public class Person
	{
        public int Id { get; set; }
        public required string Name { get; set; }

        public IList<Duty>? Duties { get; set; }
    }
}

