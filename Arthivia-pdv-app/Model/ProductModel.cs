using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthivia_pdv_app.Model
{
    public class ProductModel
    {
        public int Id { get; private set; } = 0;
        public string Name { get; private set; }
        public string BarCode { get; private set; }
        public  Boolean IsActive { get; private set; }
        public CategoryModel Category { get; private set; }
        public  UnitModel Unit { get; private set; }
        public decimal SalePrice { get; private set; }
        public decimal PurchasePrice { get; private set; }
        public decimal MarkupPercent { get; private set; }
        public string  description { get; private set; }
        public string UnitName => Unit?.Name ?? "";
        public string CategoryName => Category?.Name ?? "";

        private ProductModel() { }

        public class Builder
        {
            private readonly ProductModel _product = new ProductModel();
            public Builder WithId(int id)
            {
                _product.Id = id;
                return this;
            }
            public Builder WithName(string name)
            {
                _product.Name = name.ToUpper();
                return this;
            }
            public Builder withBarCode(string barCode)
            {
                _product.BarCode = barCode;
                return this;
            }
            public Builder WithIsActive(Boolean isActive)
            {
                _product.IsActive = isActive;
                return this;
            }
            public Builder WithCategory(CategoryModel category)
            {
                _product.Category = category;
                return this;
            }
            public Builder WithUnit(UnitModel unit)
            {
                _product.Unit = unit;
                return this;
            }
            public Builder WithSalePrice(decimal salePrice)
            {
                _product.SalePrice = salePrice;
                return this;
            }
            public Builder WithPurchasePrice(decimal purchasePrice)
            {
                _product.PurchasePrice = purchasePrice;
                return this;
            }
            public Builder WithMarkupPercent(decimal markupPercent)
            {
                _product.MarkupPercent = markupPercent;
                return this;
            }
            public Builder WithDescription(string description)
            {
                _product.description = description;
                return this;
            }
            public ProductModel Build()
            {
                if (string.IsNullOrWhiteSpace(_product.Name))
                {
                    throw new InvalidOperationException("Name cannot be null or empty.");
                }
                if (string.IsNullOrWhiteSpace(_product.BarCode))
                {
                    throw new InvalidOperationException("BarCode cannot be null or empty.");
                }
                if (_product.Category == null)
                {
                    throw new InvalidOperationException("Category cannot be null.");
                }
                if (_product.Unit == null)
                {
                    throw new InvalidOperationException("Unit cannot be null.");
                }
                if (_product.SalePrice <= 0)
                {
                    throw new InvalidOperationException("Sale Price must be greater than zero.");
                }
                if (_product.PurchasePrice < 0)
                {
                    throw new InvalidOperationException("Purchase Price cannot be negative.");
                }
                if (_product.MarkupPercent < 0)
                {
                    throw new InvalidOperationException("Markup Percent cannot be negative.");
                }
                return _product;
            }
        }
    }
}
