﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackport.BusinessModel.API
{
	public interface IPerson
	{
		string FirstName	{ get; set; }
		string Surname		{ get; set; }
		string DoB			{ get; set; }
	}
}
