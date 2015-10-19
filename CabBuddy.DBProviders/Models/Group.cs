using System;
using System.Collections.Generic;

namespace CabBuddy.DBProviders.Models
{
    public partial class Group
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CabModel { get; set; }
        public string CabNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverNumber { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}
