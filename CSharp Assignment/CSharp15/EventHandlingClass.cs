using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

using System.Threading.Tasks;

namespace CSharp15
{
	public class EventHandlingClass
	{
		public static void OnCollectionChange(object sender, NotifyCollectionChangedEventArgs a)
		{
			Console.WriteLine("\nThe Change Action :- \n" + a.Action);
			if (a.NewItems != null)
			{
				Console.WriteLine("The Element added is:- \n ");
				foreach (var i in a.NewItems)
				{
					Console.WriteLine(i);
				}
			}
			if (a.OldItems != null)
			{
				Console.WriteLine("The Element removed is:- \n");
				foreach (var i in a.OldItems)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}