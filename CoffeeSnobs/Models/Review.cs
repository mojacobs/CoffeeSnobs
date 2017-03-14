using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeSnobs.Models
{
    public class Review
    {
        [DisplayName("Review")]
        public virtual int ReviewId { get; set; }

        //REGEX for date: ^((0[13-9]|1[0-2])\/(0[1-9]|[12]\d|3[01])\/(19|20)\d{2})|(02\/(0[1-9]|1\d|2[0-8]))$
        [DisplayName("Date Visited:")]
        [Required(ErrorMessage = "Need to specify a date.")]
        public virtual string Date { get; set; }

        [DisplayName("Coffee Snob:")]
        [DataType(DataType.EmailAddress)]
        public virtual string Email{ get; set; }

        [DisplayName("Coffee Shop:")]
        [Required(ErrorMessage = "Need to specify a coffee shop.")]
        public virtual string Shop { get; set; }

        [DisplayName("Coffee Shop City:")]
        [Required(ErrorMessage = "Need to specify a city where coffee shop is.")]
        public virtual string City { get; set; }

        [DisplayName("Coffee Drink:")]
        [Required(ErrorMessage = "Need to specify a coffee drink.")]
        public virtual string Drink { get; set; }

        [DisplayName("Coffee Rating (1-5):")]
        public virtual int CoffeeRating { get; set; }

        [DisplayName("Service Rating (1-5):")]
        public virtual int ServRating { get; set; }

        [DisplayName("Would snob return?")]
        [Required(ErrorMessage = "Please let the fellow coffee snobs know if you would revist this shop.")]
        public virtual string Return { get; set; }
    }
}