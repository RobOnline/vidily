﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Vidily.Models
{
    public class MembershipType
    {
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public byte Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
  


    }
}