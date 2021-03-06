﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DeapthFirstSearchOfAllDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<DirectoryInfo> stack = new Stack<DirectoryInfo>();

            string directoryPath = @"F:\";

            DirectoryInfo mainDirectory = new DirectoryInfo(directoryPath);

            stack.Push(mainDirectory);

            while (stack.Count > 0)
            {
                DirectoryInfo currentDirectory = stack.Pop();

                Console.WriteLine(currentDirectory);

                DirectoryInfo[] subDirs;

                try
                {
                    subDirs = currentDirectory.GetDirectories();
                }

                // An UnauthorizedAccessException exception will be thrown if we do not have
                // discovery permission on a folder or file. It may or may not be acceptable
                // to ignore the exception and continue enumerating the remaining files and
                // folders. It is also possible (but unlikely) that a DirectoryNotFound exception
                // will be raised. This will happen if currentDir has been deleted by
                // another application or thread after our call to Directory.Exists. The
                // choice of which exceptions to catch depends entirely on the specific task
                // you are intending to perform and also on how much you know with certainty
                // about the systems on which this code will run.

                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Access denied! This directory can be accessed only by administrator.");
                    continue;
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("There is no such directory.");
                    continue;
                }

                foreach (var subDir in subDirs)
                {
                    stack.Push(subDir);
                }
            }
        }
    }
}
