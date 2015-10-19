using System;
using System.Collections.Generic;

namespace Cabbuddy.Models
{
    public class Group
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CabModel { get; set; }
        public string CabNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverNumber { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }


        public static List<Group> CreateGroup()
        {
            List<Group> groups = new List<Group>
            {
                new Group()
                {
                    Name = "Route 1",
                    CreatedOn = DateTime.Now
                },
                new Group()
                {
                    Name = "Route 2",
                    CreatedOn = DateTime.Now
                },
                new Group()
                {
                    Name = "Route 3",
                    CreatedOn = DateTime.Now
                }
            };
            return groups;
        }
    }
}
