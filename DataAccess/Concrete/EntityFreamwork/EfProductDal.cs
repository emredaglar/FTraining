﻿using Core.DataAccess.EntityFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfProductDal : EfEntityFreamworkBase<Product, NorthwindContext>, IProductDal
    {
        //public void Add(Product entity)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        var addedEntity = context.Entry(entity);
        //        addedEntity.State = EntityState.Added;
        //        context.SaveChanges();

        //    }
        //}

        //public void Delete(Product entity)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        var deletedEntity = context.Entry(entity);
        //        deletedEntity.State = EntityState.Deleted;
        //        context.SaveChanges();

        //    }
        //}

        //public Product Get(Expression<Func<Product, bool>> filter)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        return context.Set<Product>().SingleOrDefault(filter);
        //    }
        //}

        //public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        return filter == null
        //            ? context.Set<Product>().ToList()
        //            : context.Set<Product>().Where(filter).ToList();
        //    }
        //}

        //public void Update(Product entity)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        var updatedEntity = context.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;
        //        context.SaveChanges();

        //    }
        //}
        public List<ProductDetailDto> GetProductDetail()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }
        }
    }
}
