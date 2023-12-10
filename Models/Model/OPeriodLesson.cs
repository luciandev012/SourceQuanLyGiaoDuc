﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OPeriodLesson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string IDOrganization { get; set; }
        [Required]
        public int PeriodStartTime { get; set; }
        [Required]
        public int PeriodEndTime { get; set; }

        public string PeriodName { get; set; }

        public int IDShift { get; set; }

        [ForeignKey("IDOrganization")]
        public virtual Organization Organization { get; set; }
        [ForeignKey("IDShift")]
        public virtual OShift OShift { get; set; }
    }
}
