using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Data;
using TechJobs.Models;
using TechJobs.ViewModels;

namespace TechJobs.ViewModels
{
    public class JobViewModel
    {
        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location Location { get; set; }

        [Display(Name = "Skill")]
        public CoreCompetency CoreCompetency { get; set; }

        [Display(Name = "Position Type")]
        public PositionType PositionType { get; set; }
        public int Id { get; set; }

        //public Job JBI(int id)
        //{
        //    var jbi = JobData.Find(id);

        //    return jbi;
        //}
    }

   
}
