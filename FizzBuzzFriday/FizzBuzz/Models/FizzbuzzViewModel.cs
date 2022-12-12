using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PagedList;
using System.Collections.Generic;
namespace FizzBuzz.Models
{
    public class FizzbuzzViewModel
    {
        public FizzbuzzViewModel()
        {
            FizzBuzzNumbers = new List<string>();
        }
        [Required(ErrorMessage = "Please enter the valid input", AllowEmptyStrings =false)]
        [Range(1, 1000)]
        [DisplayName ("Numbers to be generated")]
        public int Input { get; set; }
        public List<string> FizzBuzzNumbers { get; set; }      
    }
}
