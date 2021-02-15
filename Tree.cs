using System;
using System.Collections.Generic;
using System.Text;

namespace ClockAndTree
{
	class Tree
	{
		private static Saka medis;

        /// <summary>
        /// Tree visualization: (size = 23)
        /// ROOT|Depth 2|Depth 3|Depth 4|Depth 5|Depth 6|
        ///		|		|		|		|		|		|
        ///		|		|  120	|		|		|		|
        ///		|		|		|		|		|		|
        ///		|		|		| 1020	|		|		|
        ///		|		|		|		|		|		|
        ///		|  100	|  150	| 1500	|		|		|
        ///		|		|		|		|		|		|
        ///		|		|		| 1007	| 10220 |		|
        ///		|		|		|		|		|		|
        ///		|		|  170	|		|		|		|
        ///		|		|		|		|		|		|
        ///		|		|		|		|		|		|
        ///		|		|		|		|		|		|
        ///		|		|  220	|  2020	|		|		|
        ///		|		|		|		|		|		|
        /// 0	|  200	|		|		|		|		|
        ///		|		|		|		|		|		|
        ///		|		|  250	|		|		|		|
        ///		|		|		|		|		|		|
        ///		|		|		|		|		|		|
        ///		|		|		|		|		|		|
        ///		|		|		| 3055	|		|		|
        ///		|		|		|		|		|		|
        ///		|		|		|		|		|		|
        ///		|		|		|		|		|		|
        ///		|  300	|  320	|		|		|		|
        ///		|		|		|		| 31120 |		|
        ///		|		|		|		|		|		|
        ///		|		|		|		|		| 321232|
        ///		|		|		| 3555	| 33150 |		|
        ///		|		|		|		|		| 300550|
        ///		|		|		|		|		|		|
        ///		|		|		|		| 30170 | 4480  |
        /// </summary>
        private static void CreateTreeA()
        {
			medis = new Saka(0);

			var saka1 = new Saka(100, new List<Saka>()
			{
				new Saka(120),
				new Saka(150, new List<Saka>()
				{ 
					new Saka(1020),
					new Saka(1500),
					new Saka(1007, new List<Saka>() { 
						new Saka(10220) 
					})
				}),
				new Saka(170)
			});

			var saka2 = new Saka(200, new List<Saka>()
			{
				new Saka(220, new List<Saka>()
				{
					new Saka(2020)
				}),
				new Saka(250),
			});

			var saka3 = new Saka(300, new List<Saka>()
			{
				new Saka(320, new List<Saka>()
				{
					new Saka(3055),
					new Saka(3555, new List<Saka>()
					{
						new Saka(31120),
						new Saka(33150, new List<Saka>()
						{
							new Saka(321232),
							new Saka(300550)
						}),
						new Saka(30170, new List<Saka>()
						{
							new Saka(4480)
						})
					})
				})
			});

			medis.sakos = new List<Saka>()
			{
				saka1,
				saka2,
				saka3
			};
        }

		/// <summary>
		/// Tree visualization: (size = 18)
		/// ROOT|Depth 2|Depth 3|Depth 4|Depth 5|Depth 6|Depth 7|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|  200	|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|  120	|		|		|		|		|
		///		|		|		|		|		|		|		|
		/// 0	|  100	|		|		|		|		|		|
		///		|		|		| 1020	|		|		|		|
		///		|		|  150	|		|		|		|		|
		///		|		|		| 1007	| 10220	|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		| 4480	|
		///		|		|		|		|		| 30170	| 		|
		///		|		|		|		| 33150	|		|		|
		///		|		|		| 3555	|		| 32123 |		|
		///		|		|  320	|		| 31120	|		|		|
		///		|		|		| 3555	|		|		|		|
		///		|  300	|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|  390	|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		///		|		|		|		|		|		|		|
		/// </summary>
		private static void CreateTreeB()
		{
			medis = new Saka(0);

			var saka1 = new Saka(200);

			var saka2 = new Saka(100, new List<Saka>()
			{
				new Saka(120),
				new Saka(150, new List<Saka>()
				{
					new Saka(1020),
					new Saka(1007, new List<Saka>() {
						new Saka(10220)
					})
				}),
			});

			var saka3 = new Saka(300, new List<Saka>()
			{
				new Saka(320, new List<Saka>()
				{
					new Saka(3555, new List<Saka>()
					{
						new Saka(33150, new List<Saka>()
						{
							new Saka(30170, new List<Saka>()
							{
								new Saka(4480)
							}),
							new Saka(32123)
						}),
						new Saka(31120)
					}),
					new Saka(3055)
				}),
				new Saka(390)
			});

			medis.sakos = new List<Saka>()
			{
				saka1,
				saka2,
				saka3
			};
		}

		/// <summary>
		/// Depth finding algorithm
		/// </summary>
		/// <param name="root">Pointer to the root of the tree</param>
		/// <returns>Depth of the tree</returns>
		private static int RunDepth(Saka root)
        {
			int depth = 0;
			if (root.sakos == null)
            {
				return 1;				// If counting root as 0, then change this to 0
            }
            foreach (var saka in root.sakos)
            {
				depth = Math.Max(RunDepth(saka), depth);
            }
			return depth + 1;
        }

		/// <summary>
		/// Finds the depth of the tree. If no given, then evaluating default tree
		/// </summary>
		/// <param name="medelis">Tree to find depth of</param>
		public static void FindDepthOfTree(Saka medelis)
		{
			Console.WriteLine("Finding tree depth");
			CreateTreeA();
			// CreateTreeB();
			Console.WriteLine($"Tree depth: {RunDepth(medelis ?? medis)}");
		}
	}
}
