﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inivohacks.DAL.Models
{
    public class TrackingCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TrackingCodeID { get; set; }
        public int ProductID { get; set; }

        public string Code { get; set; }
        public string Status { get; set; }

        public int BatchNumber { get; set; }

        public int SerialNumber { get; set; }

        public string Notes { get; set; }

        public bool RecallStatus { get; set; }
        public virtual Product product { get; set; }
        public ICollection <Scan> Scans { get; set; }

    }
}
