using System;

class Cart
{
    public int id;
    public string customer;
    public double grandTotal;
    public List<Product> productList;

    public void addProduct(Product product)
    {
        productList.Add(product);
        Console.WriteLine("Them san pham" + product.name + "thanh cong");
    }
    public void deleteProduct(Product product)
    {
        productList.Remove(product);
        Console.WriteLine("Xoa san pham" + product.name + "thanh cong");
    }
    public void CaculateMoney()
    {
        foreach(Product product in productList)
        {
            this.grandTotal += (product.price*product.qty);
        }

        if (country.Equals("VietNam"))
        {
            if (city.Equals("Ha Noi") || city.Equals("HCM"))
            {
                this.grandTotal *= 1.01;
            }
            else
            {
                this.grandTotal *= 1.02;
            }

        }
        else
        {
            this.grandTotal *= 1.05;
        }
    }

}