using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparerApp.DataModel
{
    public class LineComparisonResult
    {
        public int LineNumber { get; set; }
        public string File1Line { get; set; } = string.Empty;
        public string File2Line { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

    }
}
