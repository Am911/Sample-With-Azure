using System.ComponentModel.DataAnnotations;

namespace TestWithAzure.Models
{
    public class UserInformation
    {
        [Key]
        public int Pk_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
}
