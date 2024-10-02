using Interview.Data;
using Interview.Models;
using Interview.Service;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Interview.Repository
{
    public class RBill:IBill
    {
        private BillContext context;
        public RBill(BillContext _context)
        {
            this.context = _context;
        }
        public IQueryable<BillData> All(int type)
        {
            try
            {
                SqlParameter TYPE = new SqlParameter("@TYPE", type);
                return context.BillData.FromSqlRaw("Exec SPALLBILINGDATA @TYPE", TYPE);
            }
            catch(Exception) {
                return null;
            }
            
            
        }
        public IQueryable<BillData> SearchClients(string searchTerm)
        {
            try
            {
                SqlParameter PREFIX = new SqlParameter("@PREFIX", searchTerm);
                return context.BillData.FromSqlRaw("Exec SPBILLSEARCH @PREFIX", PREFIX);
            }
            catch(Exception) {
                return null;
            }
            
            
        }
        public IQueryable<string> UpdateItem(int id, int client, decimal capacity, decimal rate)

        {
            try
            {
                //string mgs = "ok";
                SqlParameter ID = new SqlParameter("@ID", id);
                SqlParameter CLIENT = new SqlParameter("@CLIENT", client);
                SqlParameter CAPACITY = new SqlParameter("@CAPACITY", capacity);
                SqlParameter RATE = new SqlParameter("@RATE", rate);
                context.Database.ExecuteSqlRaw("Exec SPBILINGUPDATE @ID,@CLIENT,@CAPACITY,@RATE", ID, CLIENT, CAPACITY, RATE);
                return null ;
            }
            catch(Exception) {
                return null;
            }
            
            
        }
    }
}
