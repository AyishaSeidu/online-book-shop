using System.ComponentModel.DataAnnotations;

namespace OnlineBookShop.Api.Models
{
    public class Author
    {
        [Key]
        [Required]
        public int Id { get; set; }

        
        private string _firstName;
        private string _lastName;
        [Required]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        [Required]
        public string LastName 
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName { 
            get { return $"{_firstName} {_lastName}"; }

        }
    }

}
