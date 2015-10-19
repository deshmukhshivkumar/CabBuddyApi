using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabBuddy.Business.Translators;
using CabBuddy.DBProviders;
using CabBuddy.DBProviders.Providers;
using Cabbuddy.Models;

namespace CabBuddy.Business
{
    public class GroupController
    {
        private readonly GroupProvider _groupProvider = new GroupProvider();

        public long Save(Group group)
        {
            return _groupProvider.Save(group.ToDbModel());
        }
    }
}
