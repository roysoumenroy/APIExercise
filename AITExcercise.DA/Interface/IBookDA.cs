using AITExcercise.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AITExcercise.DA.Interface
{
    public interface IBookDA
    {
        Task<GetBookResult> GetBookById(string patientId);
        Task<List<GetBookResult>> GetAllBooks();
    }
}
