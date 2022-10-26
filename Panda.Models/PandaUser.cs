using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda.Models
{
    public class PandaUser : IdentityUser
    {
        public ICollection<Package> Packages { get; set; }
        public ICollection<Receipt> Receipts { get; set; }

        public PandaUser()
        {
            this.Packages = new List<Package>();
            this.Receipts = new List<Receipt>();
        }
    }
}
