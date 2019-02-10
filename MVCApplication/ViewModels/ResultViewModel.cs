using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{

    public class ResultViewModel
    {
        [Required]
        public double Numin { get; set; }
        public bool State { get; set; }
        public bool Answer { get; set; }
        public String Error { get; set; }
    }
}


