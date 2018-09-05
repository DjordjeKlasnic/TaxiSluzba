using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaxiSluzba_backend.Models.Entity;
using TaxiSluzba_backend.Repository.RepositoryImpl;

namespace TaxiSluzba_backend.Controllers
{
    public class CommentsController : ApiController
    {
        public CommentRepository rep = new CommentRepository();

        public IHttpActionResult Get()
        {
            List<Comment> comments = rep.ReadComments();
            if (comments == null)
            {
                return NotFound();
            }
            return Ok(comments);
        }

        public IHttpActionResult Get(int id)
        {
            List<Comment> comments = rep.ReadComments();
            if (comments != null)
            {
                foreach (Comment comment in comments)
                {
                    if (comment.Id == id)
                        return Ok(comment);
                }
            }
            return NotFound();
        }
    }
}
