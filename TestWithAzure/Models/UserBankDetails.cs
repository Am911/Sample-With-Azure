using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWithAzure.Models
{
    public class UserBankDetails
    {
        [Key]
        public int Pk_BankDetailsId { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Address { get; set; }
        public long AccountNumber { get; set; }
        public UserInformation? _userInformation {  get; set; }
        [ForeignKey("_userInformation")]
        public int Fk_Id { get; set; }
    }
}
