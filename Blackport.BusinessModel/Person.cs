﻿using Blackport.BusinessModel.API;
using Blackport.BusinessModel.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackport.BusinessModel
{
	public class Person : SuperType, IPerson
	{
		public string FirstName { get; set; }
		public string Surname	{ get; set; }
		public string DoB		{ get; set; }
	}
}
