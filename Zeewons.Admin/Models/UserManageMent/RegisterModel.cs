using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Zeewons.Core.Common;
namespace Zeewons.Admin.Models.UserManageMent
{
    [Table("User")]
    public class RegisterModel
    {
        [Key]
        public int UserId { get; set; }
        public Guid UserGuid { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime LastLoginUtc { get; set; }
        public string LastIpAddress { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int DomainId { get; set; }
    }
}