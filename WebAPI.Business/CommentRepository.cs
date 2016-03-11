﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.Data;

namespace WebAPI.Business
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        //TestAPIEntities : is DbContext auto generated by EF
        public CommentRepository(TestAPIEntities context)
            : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Comment> GetCommentsByAuthor(string author)
        {
            return context.Set<Comment>().Where(x => x.Author.Equals(author));
        }
    }
}