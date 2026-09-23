using Solid_Principles.Models;

namespace Solid_Principles.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}