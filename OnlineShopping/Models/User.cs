using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class User
    {
        public int Id { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email Address!")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [StringLength(50,MinimumLength =6,ErrorMessage ="Password length should be greater than 6")]
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
