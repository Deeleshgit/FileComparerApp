FileComparerApp is a simple console tool that compares two text files line by line using UTF-8 byte-by-byte comparison. It shows differences in the console and saves the results to an Excel file.

Features
Byte-by-byte file comparison

Detects exact, subtle differences

Handles large files efficiently

Outputs results to console and Excel (ComparisonReport.xlsx)

How to Run
Install .NET 6 or later

Add ClosedXML package: dotnet add package ClosedXML

Build and run the app: 
dotnet build
dotnet run

Output
Console shows matches, mismatches, or missing lines

Excel report is saved as ComparisonReport.xlsx and file path displayed
