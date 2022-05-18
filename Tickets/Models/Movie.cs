﻿using Tickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tickets.Models
{
	public class Movie
	{
		[key]

		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string Price { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public MovieCategory MovieCategory { get; set;}

	}
}
