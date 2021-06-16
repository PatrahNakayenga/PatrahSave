using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PatrahSave.Models
{
    public class Transaction
    {
        [System.ComponentModel.DataAnnotations.Key]

        public int Id { set; get; }
        [DisplayName("Transaction Name")]
        public string transactionName { get; set; }
        public int Amount { set; get; }
    }
}
