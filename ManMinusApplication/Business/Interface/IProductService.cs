using ManMinusApplication.DTOs;
using ManMinusData.Entities.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManMinusApplication.Business.Interface
{
    public interface IProductService
    {
        public void Add();

        public PagedViewModel<Product> GetAllWithPaging(string keyword, int pageIndex, int pageSize);
    }
}
