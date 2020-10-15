
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingSystem.Entity
{
    public class Account

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique =true)]
        [MaxLength(50)]
        public string EmailId { get; set; }

        [Required]
        [MaxLength(8)]
        public string Password { get; set; }

        [Required]
        [MaxLength(6)]
        public string Gender { get; set; }

        public byte Age { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(100)]

        public string Address { get; set; }

        [Required]
        public int Pincode { get; set; }

        public string Role { get; set; }

        public Account(string id, string password, string gender, byte age, string city, string phoneNo, string language)
        {
            this.EmailId = id;
            this.Password = password;
            this.Gender = gender;
            this.Age = age;
            this.City = city;
            this.PhoneNumber = phoneNo;


        }
        public Account()
        {

        }

    }
}

