using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataAcessLayer;

namespace AnimalShop.Models
{
    [Serializable]
    public class AdventureWorksViewModel
    {
        [Display(Name = "The Name")]
        public string Name { get; set; }
        
        public IEnumerable<Person> People { get; set; }
        //IEnumerable<Person> GetPeopleInADWorks()
        //{
        //    return {
        //        )
        //    }
        //} 
        public AdventureWorksViewModel()
        {
            using (var db = new AdventureWorks3017Entities1())
            {
                People = db.People.ToList();
            }

        }
    }
}