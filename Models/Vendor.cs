﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VendorsPortal.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }

        [Display(Name = "Business Name")]
        [Required(ErrorMessage="Please Provide Your Business Name")]
        public string VendorName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please Provide Your Email Address")]
        public string Email { get; set; }

        [Display(Name = "Mobile Number")]
        public string VendorMobile { get; set; }

        [Display(Name = "Telephone Number ")]
        [Required(ErrorMessage = "Please Provide Your Telephone Number")]
        public string VendorTelephone { get; set;}

        [Display(Name = "Contact First Name")]
        [Required(ErrorMessage = "A Contact First Name Is Required")]
        public string ContactFirstName { get; set; }

        [Display(Name = "Contact Last Name")]
        [Required(ErrorMessage = "A Contact Last Name Is Required")]
        public string ContactLastName { get; set; }

       
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? RegistrationDate { get; set; }

        [Display(Name = "Vendor Type")]
        [Required(ErrorMessage = "Please Select Your Vendor Type")]
        public int VendorTypeId { get; set; }
        public VendorType VendorType { get; set; }

        public string ContactFullName
        {
            get
            {
                return ContactFirstName + " , " + ContactLastName;
            }
        }

        public virtual ICollection<File> Files { get; set; }

    }
}