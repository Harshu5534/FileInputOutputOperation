using System;
namespace FileInputOutputOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Welcome--------------");
            FileOperations operations = new FileOperations();
            operations.FileExist();
            operations.ReadAllLines();
            operations.ReadAllText();
            operations.CopyFile();
            operations.DeleteFilePath();
            operations.UsingStreamReader();
        }
        
    }

}
