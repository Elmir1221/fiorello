﻿using fiorellopb101.Data;
using fiorellopb101.Models;
using fiorellopb101.Servioces.Interfaces;
using fiorellopb101.ViewModels.Blog;
using Microsoft.EntityFrameworkCore;


namespace fiorellopb101.Servioces
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;

        public BlogService(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<BlogVM>> GetAllAsync( int? take = null)
        {
            IEnumerable<Blog> Blogs = await _context.Blogs.ToListAsync();


            if ( take is null)
            {
                await _context.Blogs.ToListAsync();
            }
            else
            {
                await _context.Blogs.Take((int)take).ToListAsync();

            }

            return Blogs.Select(m => new BlogVM { Title = m.Title, Description = m.Description, Image = m.Image, CreatedDate = m.CreatedDate.ToString("MM.dd.yyyy") });

        }
    }
}
