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
    }
}
