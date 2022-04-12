//namespace System.IO
//{
//	public static class ExtendedMethod
//	{
//		public static void Rename(this FileInfo fileInfo, string newName)
//		{
//			fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + newName);
//		}
//	}
//}

//FileInfo file = new("C:\Users\vkimura\source\repos\01_Test_ConsoleFileRename\Test_ConsoleFileRename\test-rename.txt");
//file.Rename("test2.txt")

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchRenamer
{
	class Program
	{
		static void Main(string[] args)
		{
			var dirnames = Directory.GetDirectories(@"C:\Users\vkimura\source\repos\01_Test_ConsoleFileRename\Test_ConsoleFileRename\test_rename");

			int i = 0;

			try
			{
				foreach (var dir in dirname
				{
					var fnames = Directory.GetFiles(dir, "*.txt").Select(Path.GetFileName);

					DirectoryInfo d = new DirectoryInfo(dir);
					FileInfo[] finfo = d.GetFiles("*.txt");

					foreach (var f in fnames)
					{
						i++;
						Console.WriteLine("The number of the file being renamed is: {0}", i);

						if (File.Exists(Path.Combine(dir, f.ToString())))
						{
							File.Move(Path.Combine(dir, f), Path.Combine(dir, f.ToString() + "-" + i));
						}
						else
						{
							Console.WriteLine("The file you are attempting to rename already exists! The file path is {0}.", dir);
							foreach (FileInfo fi in finfo)
							{
								Console.WriteLine("The file modify date is: {0} ", File.GetLastWriteTime(dir));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.Read();
		}
	}
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
	