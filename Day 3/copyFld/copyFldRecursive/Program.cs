using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace copyFldRecursive
{
    class Program
    {
        static void Main(string[] args)
        {

           /* 2. Create a folder with few nested files and sub-folders 
                 (not less than 3 levels). Write a recursive function to 
                 copy the source folder to a destination folder along 
                 with all the contents in it.*/
             
            string folderName = @"C:\Users\467627\Desktop\467627\copyFld\Source Folder";

            string pathString1 = System.IO.Path.Combine(folderName, "SubFolder1");
            string pathString2 = System.IO.Path.Combine(folderName, "SubFolder2");
            
            string pathString3 = System.IO.Path.Combine(pathString1, "SubSubFolder1");
            string pathString4 = System.IO.Path.Combine(pathString2, "SubSubFolder2");

            System.IO.Directory.CreateDirectory(pathString1);
            System.IO.Directory.CreateDirectory(pathString2);

            System.IO.Directory.CreateDirectory(pathString3);
            System.IO.Directory.CreateDirectory(pathString4);

            File.WriteAllText(Path.Combine(pathString1, "fileOne.txt"), "abc");
            File.WriteAllText(Path.Combine(pathString2, "filetwo.txt"), "def");
            File.WriteAllText(Path.Combine(folderName, "file.txt"), "ghi");
            File.WriteAllText(Path.Combine(pathString3, "fileThree.txt"), "jkl");
            File.WriteAllText(Path.Combine(pathString4, "fileFour.txt"), "mno");

            if (System.IO.File.Exists(folderName))            
            {
                Console.WriteLine("File \"{0}\" already exists.", folderName);
                return;
            }

            System.Console.WriteLine("File Creation Completed");

            CopyFolder(@"C:\Users\467627\Desktop\467627\copyFld\Source Folder",
@"C:\Users\467627\Desktop\467627\copyFld\Destination Folder");

            System.Console.WriteLine("Copying Files & Folders Completed");
            System.Console.ReadLine();

        }

        static public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
            
        }
        
    }
}
