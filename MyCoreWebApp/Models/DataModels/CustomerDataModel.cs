using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MyCoreWebApp.Models.DataModels
{
    public class CustomerDataModel
    {
        
        public int customerId { get; set; }

        [Display(Name = "Username")]
        [StringLength(100, MinimumLength = 5)]
        public string customerUserName { get; set; }

        [Display(Name = "Profile Picture")]
        public string customerAvatar { get; set; }

        [Display(Name = "First Name")]
        [StringLength(100, MinimumLength = 3)]
        public string customerFirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 3)]
        public string customerLastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

        [Display(Name = "Name")]
        public string customerFullName
        {
            get
            {
                return $"{customerFirstName} {customerLastName}";
            }
        }

        [Display(Name = "Address")]
        public Address custAddr { get; set; }


    }

    public class Address {


        [Display(Name = "Street")]
        public string street { get; set; }        

        [Display(Name = "Room Number")]
        public string roomNumber { get; set; }

        //TODO: Link this prop to a state codes list and generate a drop down. Then remove max length prop
        [Display(Name = "State")]
        [Required(ErrorMessage = "Please select your state abbreviation")]
        [MaxLength(2)]
        public string stateAbbreviation { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter a your city")]
        public string city { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Please enter a valid zip code, first 5 digits minimum")]
        [MaxLength(10)]
        public int zip { get; set; }
    }
}
