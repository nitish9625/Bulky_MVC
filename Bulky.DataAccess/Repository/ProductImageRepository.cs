﻿using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using BulkyWeb.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {

        private ApplicationDbContext _db;

        public ProductImageRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        public void update(ProductImage obj)
        {
           _db.ProductImages.Update(obj);
        }
    }
}
