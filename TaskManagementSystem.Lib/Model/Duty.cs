using System;
namespace TaskManagementSystem.Lib.Model
{
	public class Duty
	{
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public int PersonID { get; set; }
        public Person? Person { get; set; }
    }
}

