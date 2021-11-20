
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //Kategori ıd si
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //ürün birim fiyatı
        public int UnitsInStock { get; set; } //ürün stok adeti

    }
}
