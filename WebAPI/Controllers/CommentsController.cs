using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Business;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    public class CommentsController : ApiController
    {        
        // GET api/Comments
        public IEnumerable<Comment> Get()
        {
            using (var unitOfWork = new UnitOfWork(new TestAPIEntities()))
            {
                return unitOfWork.Comments.Get();
            }
            
        }

        // GET api/Comments/5
        public Comment Get(int id)
        {
            using (var unitOfWork = new UnitOfWork(new TestAPIEntities()))
            {
                return unitOfWork.Comments.GetById(id);
            }
        }
        
        public IEnumerable<Comment> GetCommentByAuthor(string author)
        {
            using (var unitOfWork = new UnitOfWork(new TestAPIEntities()))
            {
                return unitOfWork.Comments.GetCommentsByAuthor(author);
            }
        }
               

        // DELETE api/values/5
        public void Delete(int id)
        {
            using (var unitOfWork = new UnitOfWork(new TestAPIEntities()))
            {
                var comment = unitOfWork.Comments.GetById(id);
                if (comment!=null)
                {
                    unitOfWork.Comments.Remove(comment);
                    unitOfWork.Complete();//Save Change
                }                
            }
        }
    }
}
