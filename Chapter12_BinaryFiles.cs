using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
/*
 * This class is used to write a string to a binary file and read that same binary file.
 */
namespace C_sharp_Programming
{
    class Chapter12_BinaryFiles
    {
        public static void RunBinaryFileWriterExample() // Example 12-8, pg 731
        {
            
            FileStream fileStream;
            BinaryWriter binaryWriter;
            string fileName = "../../../Chapter12_BinaryFileTest.txt";
            if (File.Exists(fileName)) 
            {
                Console.WriteLine("File already exists.");
            }
            else 
            {
                fileStream = new FileStream(fileName, FileMode.CreateNew);
                binaryWriter = new BinaryWriter(fileStream);
                decimal aValue = 2.16m;
                binaryWriter.Write("Sample run");
                for (int i = 0; i < 11; i++)
                {
                    binaryWriter.Write(i);
                }
                binaryWriter.Write(aValue);
                binaryWriter.Close();
                fileStream.Close();
            }
            Console.WriteLine("File created successfully.");
        }
        public static void RunBinaryFileReaderExample()
        {
            FileStream fileStream;
            BinaryReader binaryReader;
            string fileName = "../../../Chapter12_BinaryFileTest.txt";

            try
            {
                fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                binaryReader = new BinaryReader(fileStream);
                RetrieveAndDisplayData(binaryReader);
                binaryReader.Close();
                fileStream.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
        }
        public static void RetrieveAndDisplayData(BinaryReader binaryReader)
        {
            Console.WriteLine("ReadString(): " + binaryReader.ReadString());
            Console.Write("Iterating through ReadInt32(): ");
            for(int i = 0; i < 11; i++)
            {
                Console.Write(binaryReader.ReadInt32() + " ");
            }
            Console.WriteLine("\nReadDecimal(): " + binaryReader.ReadDecimal());
        }
    }
}
