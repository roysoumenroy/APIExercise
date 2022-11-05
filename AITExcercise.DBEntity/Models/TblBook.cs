using System;
using System.Collections.Generic;

#nullable disable

namespace AITExcercise.DBEntity.Models
{
    public partial class TblBook
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
