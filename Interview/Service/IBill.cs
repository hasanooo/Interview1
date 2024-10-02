using Interview.Models;

namespace Interview.Service
{
    public interface IBill
    {
        IQueryable<BillData> All(int type);
        IQueryable<BillData> SearchClients(string searchTerm);
        IQueryable<string> UpdateItem(int id, int client, decimal capacity, decimal rate);
    }
}
