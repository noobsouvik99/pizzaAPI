using System;
using pizzaAPI.Models;
namespace pizzaAPI.Services
{
	public  class ClassService
	{
		 List<Class> classes;
		 public ClassService()
		{
			classes = new List<Class>
			{
				new Class {classname = "Invoices", templatetype = 1, trainable = true },
				new Class {classname = "Transcripts", templatetype = 2, trainable = false}
			};
		}

		public List<Class> GetClasses()
		{
			return classes;
		}

		public Class GetClassByName(string classname)
		{
			foreach(Class yourclass in classes)
			{
				if (yourclass.classname == classname)
				{
					return yourclass;
				}
			}
			return null;
			
		}




	}
}

