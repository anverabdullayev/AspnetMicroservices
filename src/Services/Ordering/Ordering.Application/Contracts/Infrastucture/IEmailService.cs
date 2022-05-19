using Ordering.Application.Models;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infrastucture
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
