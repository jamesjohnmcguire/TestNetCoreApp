using DigitalZenWorks.Common.Utilities;
using System;

namespace TestNetCoreApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			string test = VersionUtilities.GetVersion();
			Console.WriteLine("Version: " + test);
		}
	}
}
