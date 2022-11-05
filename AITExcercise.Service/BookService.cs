using AITExcercise.DA.Interface;
using AITExcercise.Models;
using AITExcercise.Service.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AITExcercise.Service
{
    public class BookService : IBookService
    {
        private readonly ILogger<BookService> _logger;
        private readonly IBookDA _bookDA;

        public BookService(ILogger<BookService> logger, IBookDA bookDA)
        {
            _logger = logger;
            _bookDA = bookDA;
        }
        public async Task<GetBookResult> GetBookById(string id)
        {
            return await _bookDA.GetBookById(id);
        }
        public async Task<List<GetBookResult>> GetAllBooks()
        {
            return await _bookDA.GetAllBooks();
        }
    }
}
