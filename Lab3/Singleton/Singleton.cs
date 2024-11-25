﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Singleton
{
	public class Singleton
	{
		private static Singleton instance;
		private Singleton()
		{
		}

		public static Singleton getInstance()
		{
			if (instance == null)
			{
				instance = new Singleton();
			}
			return instance;
		}
	}
}
