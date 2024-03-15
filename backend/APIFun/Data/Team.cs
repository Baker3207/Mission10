﻿using System.ComponentModel.DataAnnotations;

namespace APIFun.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
        public int? CaptainID { get; set; }  
    }
}