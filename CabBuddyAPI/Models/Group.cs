using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CabBuddyAPI.Models
{
    public class Group
    {
        public long Id { get; set; }

        public String Name { get; set; }

        public String AdminName { get; set; }

        public DateTime CreatedOn { get; set; }

        public static List<Group> CreateGroup()
        {
            List<Group> groups = new List<Group>
            {
                new Group()
                {
                    Name = "Route 1",
                    AdminName = "John",
                    CreatedOn = DateTime.Now
                },
                new Group()
                {
                    Name = "Route 2",
                    AdminName = "Peter",
                    CreatedOn = DateTime.Now
                },
                new Group()
                {
                    Name = "Route 3",
                    AdminName = "Cena",
                    CreatedOn = DateTime.Now
                }
            };
            return groups;
        }
    }
}