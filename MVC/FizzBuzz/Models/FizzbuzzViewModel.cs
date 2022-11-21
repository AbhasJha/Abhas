using System.ComponentModel.DataAnnotations;

namespace FizzBuzz.Models
{
    public class FizzbuzzViewModel
    {
        [Range(1,1000,ErrorMessage ="Value should be between 1 to 1000")]
        public int Input { get; set; } 
    }
}
