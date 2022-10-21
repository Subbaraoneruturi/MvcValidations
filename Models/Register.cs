using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel; // so these are the 3 important references we need 
                               //in order to map the DBtbl with the classes as well as Validations.

namespace MvcValidations.Models
{
    [Table("tblRegister")] //tblRegister is a table Attribute
    public class Register //we need to define validations and make sure that
                          //contradictionary Data not get stored Into the DB
    {
        [Key ]
        //[Required(ErrorMessage ="User Id Required")] //every dataAnnotation that u define here
                                                      //is Configured with an attributes 
        public string UserId { get; set; }
        [StringLength(15,MinimumLength = 4, ErrorMessage ="User Name 4 to 15 Chars")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password Mismatch" )]
        public string ConfirmPassword { get; set; }
        [Range(15,30, ErrorMessage=" Age 15 to 30 Only" )]
        public int? Age { get; set;  }
        [DataType(DataType.EmailAddress)] //this ensures that input value is in an Valid Email Format or not    
        public string Email { get; set;  }
        [RegularExpression(@"\+91[0-9]{10}", ErrorMessage = "Invalid Mobile")]
        //it is expecting a Pattern, @ is a Verbatem character which will allow u to 
        //use the strings in a plain format, avoiding escape sequence issues
        public string Mobile { get; set;  }

    }
}