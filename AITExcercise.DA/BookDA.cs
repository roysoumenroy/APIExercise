using AITExcercise.DA.Interface;
using AITExcercise.DBEntity.Models;
using AITExcercise.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITExcercise.DA
{
    public class BookDA : IBookDA
    {
        private readonly IMapper _mapper;
        public BookDA(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<GetBookResult> GetBookById(string id)
        {
            using var context = new AITech_ExcerciseContext();
            var result = await context.TblBooks.Where(x => x.Id == new Guid(id)).Select(x => x).FirstOrDefaultAsync();
            return _mapper.Map<GetBookResult>(result);
        }
        public async Task<List<GetBookResult>> GetAllBooks()
        {
            using var context = new AITech_ExcerciseContext();
            var result = await context.TblBooks.ToListAsync();
            return _mapper.Map<List<GetBookResult>>(result);
        }

    }
}
