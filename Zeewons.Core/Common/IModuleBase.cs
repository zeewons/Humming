using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeewons.Core.Common
{
    public interface IModuleBase
    {
         int LanguageId{get;set;}
         int UserModuleId{get;set;}
         int DomainId { get; set; }
    }
}
