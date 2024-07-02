using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_with_WF
{
    internal class Course
    {
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public int Crs_Duration { get; set; }
        public int Top_Id { get; set; }

        public string Top_Name { get; set; }

        public Course(int Crs_Id, string Crs_Name, int Crs_Duration, int Top_Id, string Top_Name)
        {
            this.Crs_Id = Crs_Id;
            this.Crs_Name = Crs_Name;
            this.Crs_Duration = Crs_Duration;
            this.Top_Id = Top_Id;
            this.Top_Name = Top_Name;
        }
    }
}
