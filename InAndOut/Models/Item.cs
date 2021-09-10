using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Item
    {
        //// Private field
        //private int _id;
        //private string _borrower;

        //// Property
        //public int Id
        //{
        //    get { return _id; }
        //    set
        //    {

        //            _id = Math.Abs(value);

        //    }
        //}

        //public string Borrower
        //{
        //    get { return _borrower; }
        //    set
        //    {
        //        _borrower = value.ToUpper();

        //    }
        //}

        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }

    }
}
