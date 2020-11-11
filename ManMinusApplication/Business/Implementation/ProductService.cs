using ManMinusApplication.Business.Interface;
using ManMinusApplication.DTOs;
using ManMinusData.EF;
using ManMinusData.Entities.Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManMinusApplication.Business.Implementation
{
    public class ProductService : IProductService
    {
        #region fields
        private readonly ManMinusContext _context;
        private readonly DbSet<Product> _dbSet;
        #endregion

        #region ctors
        public ProductService(ManMinusContext context)
        {
            _context = context;
            _dbSet = _context.Set<Product>();

        }
        #endregion

        #region public methods
        public void Add()
        {
            throw new NotImplementedException();
        }

        public PagedViewModel<Product> GetAllWithPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
