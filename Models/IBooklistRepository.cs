using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morris_Isaac_Homework5.Models
{
    public interface IBooklistRepository
    {
        IQueryable<Book> Books { get; }
    }
}
