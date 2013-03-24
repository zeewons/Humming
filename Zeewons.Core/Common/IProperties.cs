using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeewons.Core.Common
{
    public  interface IProperties
    {
         string AddedBy{get;set;}
         DateTime AddedOn { get; set; }
         bool IsDeleted { get; set; }
         DateTime DeletedOn { get; set; }
         bool IsModified { get; set; }
         DateTime ModifiedOn { get; set; }
         string DeletedBy { get; set; }
         string ModifiedBy { get; set; }
         bool IsActive { get; set; }
    }
}
