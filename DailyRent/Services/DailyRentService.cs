using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DailyRent
{
    public class DailyRentService
    {
        private DailyRentContext _context;

        public DailyRentService(DailyRentContext context)
        {
            this._context = context;
        }
        
        public IEnumerable<Post> GetPosts()
        {
            var posts = _context.Posts
                .Include(post => post.Owner)
                .Include(post => post.Apartment)
                .ThenInclude(Apartment => Apartment.Type);
            return posts;
        }
    }
}