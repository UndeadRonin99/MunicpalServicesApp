using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicpalServicesApp
{
    internal class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; } // Path to the attached media file, if any

        public Issue(string location, string category, string description, string filePath)
        {
            Location = location;
            Category = category;
            Description = description;
            FilePath = filePath;
        }
    }
}
