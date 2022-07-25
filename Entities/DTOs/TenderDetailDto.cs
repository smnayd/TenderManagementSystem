﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class TenderDetailDto:IDto
    {
        public int TenderID { get; set; }
        public int UserID { get; set; }
        public int StatusID { get; set; }
        public int CategoryID { get; set; }
        public string? TenderTitle { get; set; }
        public int TenderNumber { get; set; }
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

