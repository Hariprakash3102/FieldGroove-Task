using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldGroove.Application.Contracts.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        public IRegisterRepository Register { get; }

        Task Save();
    }
}
