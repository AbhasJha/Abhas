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
            PageFizzBuzzList = new PagedList<string>(FizzBuzzNumbers,1,20);
        }
        [Required(ErrorMessage = "Please enter the valid input", AllowEmptyStrings =false)]
        [Range(1, 1000)]
        [DisplayName ("Numbersto be generated")]
        public int Input { get; set; }
        public List<string> FizzBuzzNumbers { get; set; }
        public int Page
        {
            get
            {
                return 1;
            }
        }

        public PagedList<string> PageFizzBuzzList { get; set; }
    }
}
