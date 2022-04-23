using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace filereader
{
    class Program
    {

        static readonly string textFile = @"C:\FileReader\abc.txt";
        static void Main(string[] args)
        {
            //var streamReader = new StreamReader(textFile);
            List<String> songsList = new List<String>();
            if (File.Exists(textFile))
            {
                // Read entire text file content in one string    
                string text = File.ReadAllText(textFile);
                Console.WriteLine(text);
                var row = File.ReadAllLines(textFile).ToList();
                int count = row.Count();
                for(int i=1;i<count; i++)
                {
                    songsList.Add(row[i]);

                }

            }

            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                   Console.WriteLine(line);
                 

            }

            var drives = DriveInfo.GetDrives()
                .Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);

            string fileName = songsList[1];
            string sourcePath = @"C:\FileReader\songs";
            string targetPath = @"C:\FileReader\songs\Destfolder";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder.
            // If the directory already exists, this method does not create a new directory.
            System.IO.Directory.CreateDirectory(targetPath);

            // To copy a file to another location and
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);

            // To copy all the files in one directory to another directory.
            // Get the files in the source folder. (To recursively iterate through
            // all subfolders under the current directory, see
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously
            //       in this code example.


            //USBPort.USBDeviceAttached += new USBClass.USBDeviceEventHandler(USBPort_USBDeviceAttached);
            //USBPort.USBDeviceRemoved += new USBClass.USBDeviceEventHandler(USBPort_USBDeviceRemoved);



            //base.OnSourceInitialized(e);
            //HwndSource source = PresentationSource.FromVisual(this) as HwndSource;
            //source.AddHook(WndProc);
            ////USB Connection
            //USBPort.RegisterForDeviceChange(true, source.Handle);
            //USBTryMyDeviceConnection();
            //MyUSBDeviceConnected = false;



        }
    }
}
