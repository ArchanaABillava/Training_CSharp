using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_CSharp
{
    public class File_ReadWrite
    {
        //Create and store
        public void Write()
        {
            
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13141\Task17.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("1 x 1 = 1\r\n1 x 2 = 2\r\n1 x 3 = 3\r\n1 x 4 = 4\r\n1 x 5 = 5\r\n1 x 6 = 6\r\n1 x 7 = 7\r\n1 x 8 = 8\r\n1 x 9 = 9\r\n1 x 10 = 10");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
        //  Read 
        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13141\Task17.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }
    }
        internal class Task_17_a_
    {
        public static void Main()
        {
            File_ReadWrite rw = new File_ReadWrite();
            rw.Write();
            //rw.read();


            //Move
            //File.Move(@"C:\Users\EI13141\Task17.txt", @"C:\Users\EI13141\source\Task17.txt");

            //Copy
           string path = @"C:\Users\EI13141\Task17.txt";
            //string destination = @"C:\Users\EI13141\source\Task17_Copy";
            //File.Copy(path, destination);

            //Delete files
            //File.Delete(path);

            //Read First line from the file
            string[] content;
            content = File.ReadAllLines(path);
            //Console.WriteLine(content[0]);

            var lineCount = File.ReadLines(@"C:\Users\EI13141\Task17.txt").Count();
            Console.WriteLine(lineCount);


        }
    }
}
