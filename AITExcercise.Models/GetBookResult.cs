using System;
using System.Collections.Generic;
using System.Text;

namespace AITExcercise.Models
{
    public class GetBookResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
