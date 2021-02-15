using System;
using System.Collections.Generic;
using System.Text;

namespace ClockAndTree
{
	class Saka
	{
		public List<Saka> sakos;
		public int data;

		public Saka() {}
		public Saka(int value) : this(value, null) {}
		public Saka(int value, List<Saka> sakos)
		{
			this.data = value;
			this.sakos = sakos;
		}
	}
}
