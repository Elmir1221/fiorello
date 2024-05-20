﻿using fiorellopb101.Models;

namespace fiorellopb101.Servioces.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
    }
}
