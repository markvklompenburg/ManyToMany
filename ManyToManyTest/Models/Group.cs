using System;
using System.ComponentModel.DataAnnotations;
namespace ManyToManyTest.Models
{
	public class Group
	{
		[Key]
		public int Id { get; set; }
		public string Naam { get; set; }
        public ICollection<User>? Users { get; set; }
        public Group()
		{
		}
	}
}

