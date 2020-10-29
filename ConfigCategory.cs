using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCallConsoleApp
{
	public class ConfigCategory
	{
		public string name { get; set; }
		public int id { get; set; }
		public int parentConfigCategoryId { get; set; }
	}
}
