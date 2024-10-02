using Interview.Models;

namespace Interview.Service
{
    public interface IBill
    {
        IQueryable<BillData> All(int type);
    }
}
