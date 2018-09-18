using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitConverter
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = "91";
			string reverse = "";
			for( int i = word.Length-1; i >= 0; i-- )
			{
				reverse += word[i];
			}
			Console.WriteLine(reverse);
			Console.ReadLine();
		}
	}
}
