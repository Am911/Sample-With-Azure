using Microsoft.EntityFrameworkCore;
using TestWithAzure.Models;

namespace TestWithAzure.DataBaseConnection
{
    public class AzureDatabaseContext: DbContext
    {
        public AzureDatabaseContext(DbContextOptions<AzureDatabaseContext> con):base(con)
        {

        }

        public DbSet<UserInformation> Azure_UserInformation_Mst {  get; set; }
        public DbSet<UserBankDetails> Azure_UserBankDetails_Mst {  get; set; }
    }
}
