using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;

namespace PatrahSave.Models
{
    public class Accounttype
    {
        [System.ComponentModel.DataAnnotations.Key]

        public int Id { set; get; }
        [DisplayName("Account Name")]
        public string AccountName { get; set; }
        public string AccountType { set; get; }
    }
}
