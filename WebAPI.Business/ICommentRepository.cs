using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Data;

namespace WebAPI.Business
{
    public interface ICommentRepository: IRepository<Comment>
    {
        IEnumerable<Comment> GetCommentsByAuthor(string author);
    }
}
