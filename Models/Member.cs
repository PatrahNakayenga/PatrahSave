using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PatrahSave.Models
{
    public class Member
    {
     [System.ComponentModel.DataAnnotations.Key]

        public int MemberId { get; set; }
        [DisplayName("Item Name")]
        public string Name { get; set; }
        public string YearOfBirth { get; set; }
        public int Age { get; set; }
        public string PlaceOfResidence { get; set; }
    }
}
