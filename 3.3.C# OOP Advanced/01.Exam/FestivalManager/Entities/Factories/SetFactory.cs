﻿using System;

using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;





namespace FestivalManager.Entities.Factories
{
	using Contracts;
	using Entities.Contracts;
	using Sets;

	public class SetFactory : ISetFactory
	{
		public ISet CreateSet(string name, string type)
		{
			//if (type == "Short")
			//{
			//	return new Short(name);
			//}
			//else if (type == "Medium")
			//{
			//	return new Medium(name);
			//}
			//else
			//{
			//	return new Long(name);
			//}

            var ttype = Assembly.GetCallingAssembly().GetTypes().Single(t => t.Name == type);

            return (ISet)Activator.CreateInstance(ttype, name);


		}
	}




}
