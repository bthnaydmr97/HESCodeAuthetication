using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entites
{
    public class HesCode : BaseClass, IEntity
    {
        [Required]
        public string Hes { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
