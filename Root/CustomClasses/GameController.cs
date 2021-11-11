using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Root
{
	public class GameController
	{
		public Random r = new Random(); 
		
		public void Shuffler<T>(IList<T> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = r.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}
	}
}
