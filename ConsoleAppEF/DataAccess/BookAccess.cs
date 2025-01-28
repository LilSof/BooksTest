using ConsoleAppEF.DBContext;
using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF.DataAccess
{
    internal class BookAccess
    {
        public List<UserBookDto> GetUserBooksWithBookInfo()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    return context.UserBooks
                        .Include(ub => ub.Book) // Include related Book data
                        .Select(ub => new UserBookDto
                        {
                            Id = ub.Id,
                            BookName = ub.Book.Name,
                            Author = ub.Book.Author,
                            NumberOfPages = ub.Book.NumberOfPages,
                            IsReadPercentage = ub.IsReadPercentage,
                            CurrentPage = ub.CurrentPage,
                            AddedAt = ub.AddedAt
                        })
                        .ToList();
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex);
                return new List<UserBookDto>();
            }
        }
    }
}
