using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabBuddy.DBProviders.Models;

namespace CabBuddy.Business.Translators
{
    static class GroupTranslator
    {
        public static Group ToDbModel(this Cabbuddy.Models.Group group)
        {
            return new Group()
            {
                Id = group.Id,
                Name = group.Name,
                CabModel = group.CabModel,
                CabNumber = group.CabNumber,
                DriverName = group.DriverName,
                DriverNumber = group.DriverNumber,
                CreatedBy = group.CreatedBy,
                CreatedOn = DateTime.Now
            };
        }
    }
}
