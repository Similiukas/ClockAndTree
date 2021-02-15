using System;

namespace ClockAndTree
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!\n");
			Console.Write("Do you want to try the clock function? [y/n]: ");
			string k = Console.ReadLine();
			if (k.ToLower().Equals("y"))
			{
				Clock.ClockStart();
			}
            else
            {
				Console.WriteLine("I guess not");
            }
			Console.Write("\n\nNow do you want the tree function? (If you want a custom tree, you need to edit the source code) [y/n]:");
			k = Console.ReadLine();
			if (k.ToLower().Equals("y"))
			{
				Tree.FindDepthOfTree(null);
			}
			Console.WriteLine("Goodbye\nPress any key to close");
			Console.Read();
		}
	}
}
