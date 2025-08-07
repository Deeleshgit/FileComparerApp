using System;
using FileComparerApp;
using FileComparerApp.Service;
class Program
{
    static void Main(string[] args)
    {
        string path1 = "C:/Users/deelesh.maywah/source/repos/FileComparerApp/FileComparerApp/Files/file1.txt";
        string path2 = "C:/Users/deelesh.maywah/source/repos/FileComparerApp/FileComparerApp/Files/file2.txt";

        var results = FileComparer.CompareFiles(path1, path2);

        bool allMatch = results.TrueForAll(result => result.Status == "Match");

        if (allMatch)
        {
            Console.WriteLine("The files are identical.");
        }
        else
        {
            foreach (var result in results)
            {
                if (result.Status != "Match")
                {
                    Console.WriteLine($"Difference at line {result.LineNumber}:");
                    Console.WriteLine($"File1: {result.File1Line}");
                    Console.WriteLine($"File2: {result.File2Line}");
                }
            }
        }
        ExcelExporter.ExportToExcel(results);
        Console.WriteLine("ComparisonReport.xlsx has been created.");
    }
}