using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ManMinusData.Entities.Business
{
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
