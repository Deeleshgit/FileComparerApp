using FileComparerApp.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace FileComparerApp.Service
{
    public  class FileComparer: ByteComparer
    {
        public static List<LineComparisonResult> CompareFiles(string path1, string path2)
        {
            var results = new List<LineComparisonResult>();

             var reader1 = new StreamReader(path1);
             var reader2 = new StreamReader(path2);

            int lineNumber = 1;
            while (!reader1.EndOfStream || !reader2.EndOfStream)
            {
                string? line1 = reader1.EndOfStream ? null : reader1.ReadLine();
                string? line2 = reader2.EndOfStream ? null : reader2.ReadLine();

                string status;

                if (line1 == null || line2 == null)
                {
                    status = "Missing";
                }
                else if (AreLinesIdentical(line1, line2))
                {
                    status = "Match";
                }
                else
                {
                    status = "Mismatch";
                }

                results.Add(new LineComparisonResult
                {
                    LineNumber = lineNumber,
                    File1Line = line1 ?? "[Missing]",
                    File2Line = line2 ?? "[Missing]",
                    Status = status
                });

                lineNumber++;
            }

            return results;
        }

        
    }
}
