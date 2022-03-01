using System;
using System.IO;
using System.Linq;

namespace CSharp16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = false;
            while (!flag)
            {
                try
                {
                    //Get all the files from a given directory and perform the following actions
                    string path = @" ";
                    Console.WriteLine("Enter the Directory :- \n");
                    path = Console.ReadLine();
                    if (Directory.Exists(path))
                    {
                        DirectoryInfo i = new DirectoryInfo(path);    //1. Return the number of text files in the directory (*.txt).
                        int numberTextFiles = i.GetFiles().ToList().Where(file => file.FullName.Contains(".txt")).Count();
                        Console.WriteLine("\nThe number of text files in the directory (*.txt):- \n {0} ", numberTextFiles);
                        Console.WriteLine("\nThe number of files per Extension type:- \n");      //2. Return the number of files per extension type.
                        var e = i.EnumerateFiles(".", SearchOption.TopDirectoryOnly)
                                .GroupBy(file => file.Extension)
                                .Select(x => new { Extension = x.Key, Count = x.Count() })
                                .ToList();
                        foreach (var ecount in e)
                        {
                            Console.WriteLine("The Number of files with Extension \"{0}\" is:- \n {1}", ecount.Extension, ecount.Count);
                        }
                        Console.WriteLine("\nThe Top 5 largest files with their file size are:- \n"); //3. Return the top 5 largest files, along with their file size (use anonymous types).
                        var f = i.GetFiles().OrderByDescending(file => file.Length).Take(5).ToList();
                        foreach (FileInfo l in f)
                        {
                            Console.WriteLine("The file \"{0}\" has size {1} MB.", l.Name, l.Length / 1024f / 1024f);
                        }
                        if (f.Count != 0)  //4. Return the file with maximum length
                        {
                            Console.WriteLine("\nThe file \"{0}\" has maximum length in the directory {1} MB.", ((FileInfo)f[0]).Name, ((FileInfo)f[0]).Length / 1024f / 1024f);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Directory doesn't exists.");
                        Console.WriteLine("Press 1 to run the Program again or Press 0 to Terminate.");
                        string s;
                        s = Console.ReadLine();
                        Console.WriteLine("\n");
                        if (int.Parse(s) == 1)
                        {
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input!! Enter a Correct Directory Path.\n");
                }
            }
        }
    }
}
