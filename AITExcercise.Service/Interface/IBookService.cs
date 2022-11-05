using AITExcercise.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AITExcercise.Service.Interface
{
    public interface IBookService
    {
        Task<GetBookResult> GetBookById(string id);
        Task<List<GetBookResult>> GetAllBooks();
    }
}
