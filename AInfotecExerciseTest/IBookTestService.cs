using AITExcercise.DBEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AInfotecExerciseTest
{
    public interface IBookTestService
    {
        IEnumerable<TblBook> GetAllItems();
        TblBook GetById(string id);
    }
}
