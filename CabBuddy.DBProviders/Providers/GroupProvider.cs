using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabBuddy.DBProviders.Models;

namespace CabBuddy.DBProviders.Providers
{
    public class GroupProvider
    {
        public long Save(Group group)
        {
            if (group == null)
                return 0;
            using (var db = new CabBuddyContext())
            {
                db.Database.Connection.Open();
                db.Groups.Add(group);
                db.SaveChanges();
                return group.Id;
            }            
        }
    }
}
