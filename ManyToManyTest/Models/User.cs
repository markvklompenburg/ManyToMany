using System;
using System.ComponentModel.DataAnnotations;
namespace ManyToManyTest.Models
{
	public class User
	{
        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
		public ICollection<Group>? Groups { get; set; }

		public User()
		{
		}
	}
}

