﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Esempio05
{
    // classe per salvare scrivere settaggi
    class ConsoleApplication
    {
        const string fileName = "AppSettings.dat";

        static void Main()
        {
            WriteDefaultValues();
            DisplayValues();
            Console.ReadKey();
        }

        // scrittura dei settaggi
        public static void WriteDefaultValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"c:\Temp");
                writer.Write(10);
                writer.Write(true);
            }
        }

        // lettura dei settaggi
        public static void DisplayValues()
        {
            float aspectRatio;
            string tempDirectory;
            int autoSaveTime;
            bool showStatusBar;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                    autoSaveTime = reader.ReadInt32();
                    showStatusBar = reader.ReadBoolean();
                }

                Console.WriteLine("Aspect ratio set to: " + aspectRatio);
                Console.WriteLine("Temp directory is: " + tempDirectory);
                Console.WriteLine("Auto save time set to: " + autoSaveTime);
                Console.WriteLine("Show status bar: " + showStatusBar);
            }
        }
    }
}
