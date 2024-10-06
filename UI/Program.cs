
using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;

ProductManager productManager=new ProductManager(new EfProductDal());

foreach (var product in productManager.getByUnitPrice(50,100))
{
    Console.WriteLine(product.ProductName);
}