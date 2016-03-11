using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Business
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestAPIEntities _context;

        public UnitOfWork(TestAPIEntities context)
        {
            _context = context;
            Comments = new CommentRepository(context);
        }

        public ICommentRepository Comments { get; private set; }

        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
