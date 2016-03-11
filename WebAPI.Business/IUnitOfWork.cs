using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Business
{
    public interface IUnitOfWork : IDisposable
    {
        ICommentRepository Comments { get; }
        int Complete();
    }
}
