using AITExcercise.DBEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AInfotecExerciseTest
{
    public class BookTestFakeService : IBookTestService
    {
        private readonly List<TblBook> _bookList;
        public BookTestFakeService()
        {
            _bookList = new List<TblBook>()
            {
                new TblBook() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    Name = "Book1", AuthorName="Author1", CreatedBy ="Soumen roy" },
                new TblBook() { Id = new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"),
                    Name = "Book2", AuthorName="Author2",CreatedBy ="Soumen roy" },
                new TblBook() { Id = new Guid("33704c4a-5b87-464c-bfb6-51971b4d18ad"),
                    Name = "Book3", AuthorName="Author3", CreatedBy ="Soumen roy"}
            };
        }
        public IEnumerable<TblBook> GetAllItems()
        {
            return _bookList;
        }
        public TblBook GetById(string id)
        {
            return _bookList.Where(a => a.Id == new Guid(id))
                .FirstOrDefault();
        }
    }
}
