using System;
using System.IO; // stands for Input/Output. Enables us to work with files. 

namespace W3Course5
{
    class Program
    {
        static void Main(string[] args)
        {
            // writealltext method - writes text to a file

            //string writetext = "hello world!";
            //string path = @"c:\test\mytest.txt"; 

            //File.WriteAllText(path, writetext);

            // appendtext method - appends text to a file

            /*path = @"c:\test\mytest.txt";
            using (streamwriter sw = file.appendtext(path))
            {
                sw.writeline("this");
                sw.writeline("is extra");
                sw.writeline("text");

            }
            
            // copy method - copies a file

            string sourcefile = @"c:\test\mytest.txt";
            string destinationfile = @"c:\test2\test2.txt";
            file.copy(sourcefile, destinationfile);

            // create method - creates or overwrites a file

            file.create(destinationfile);

            // delete method - deletes a file

            string file = @"c:\test2\test2.txt";
            file.delete(file);

            //exists method -tests whether file exists


            string newfile = @"c:\test2\newfile.txt";
            bool result = file.exists(newfile);
            string contents = "hello you";
            if (result == true)
            {
                file.writealltext(newfile, contents);

            }

            // readalltext method - reads the content of the file

            string readtext = file.readalltext(newfile);
            console.writeline(readtext);

            // replace method - replace contents of file with contents of another file
            */
            /*
                try
            {
                string OriginalFile = @"c:\test\MyTest.Txt"; // should delete this file.
                string FileToReplace = @"c:\test2\newFile.Txt"; // and replace contents with file above contents
                string BackUpOfFileToReplace = @"c:\test2\newFileBackUp.Txt.txt";

                Console.WriteLine("Move the contents of " + OriginalFile + " into " + FileToReplace
                    + ", delete " + OriginalFile +
                                   ", and create a backup of " + FileToReplace + ".");

                // Replace the file.
                File.Replace(OriginalFile, FileToReplace, BackUpOfFileToReplace);

                Console.WriteLine("Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
          */
            // WriteAllText Method - creates a new file and writes content to it. If the file
            // already exists, it will be overwritten. 

            string path = @"c:\test\MyTest2.Txt";

            if (!File.Exists(path))
            {
                string createText = "Hello and welcome";
                File.WriteAllText(path, createText);
            }
            Console.ReadLine();
        }
    }

            
}
    

