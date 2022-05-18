using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tickets.Models
{
	public class Actor
	{
		[key]

		public int id { get; set; }

		public string profilePictureURL { get; set; }

		public string FullName { get; set; }

		public string Bio { get; set; }
	}
}
