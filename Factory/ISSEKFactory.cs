using SsekRoute.Domain.Models;

namespace SsekRoute.Factory
{
    public interface ISSEKFactory
    {
        Transaction CreateObject(string data);
    }
}
