using FieldGroove.Domain.Models;

namespace FieldGroove.Application.Contracts.Interface
{
    public interface IRegisterRepository : IGenericsRepository<RegisterModel>
    {
        Task<RegisterModel> GetByEmail(string email);

    }
}
