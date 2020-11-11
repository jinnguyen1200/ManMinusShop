using System;
using System.Collections.Generic;
using System.Text;

namespace ManMinusApplication.DTOs
{
    public class PagedViewModel<T>
    {
        public int TotalRecords { get; set; }
        public List<T> Result { get; set; }
    }
}
