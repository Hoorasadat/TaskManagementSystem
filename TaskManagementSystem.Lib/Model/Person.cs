using System;
namespace TaskManagementSystem.Lib.Model
{
	public class Person
	{
        public int Id { get; set; }
        public required string Name { get; set; }
        public IList<Duty>? Duties { get; set; }
    }
}

