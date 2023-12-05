﻿using MealSystem.Commons.Enums;
using MealSystem.Models;
using System.ComponentModel;

namespace MealSystem.DTO
{
    public class TicketDto 
    {
        public Code? code { get; set; }
        
        public MealType? type { get; set; }

        public  CompNm?  compNm { get; set;}

        public DateTime? startDt { get; set; }

        public DateTime? endDt { get; set; }

        public DateTime? regDt { get; set; }

        [DefaultValue(false)]
        public bool? isUsed { get; set; }

    }
}
