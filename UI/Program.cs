﻿
using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;

ProductTest();

//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetail())
    {
        Console.WriteLine(product.ProductName+" "+ product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}