using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using WpfShop.Data.Dao;

namespace WpfShop.ViewModels
{
    internal class EditProductViewModel : ViewModelBase
    {
        private String _name;
        private decimal _price;
        private int _quantity;
        private String _description;
        private int _categoryId;

        public ICommand UpdateProductCommand { get; }

        public int Id { get; set; }

        public EditProductViewModel(int id)
        {
            this.Id = id;
            UpdateProductCommand = new ViewModelCommand(ExcuteUpdateProductCommand);

        }
        private void InitData()
        {
            ProductDao productDao = DataDao.Instance().GetProductDao();
            Product product = productDao.findById(Id);
            Name = product.Name;
            Price = (decimal)product.Price;
            Quantity = (int)product.Quantity;
            Description = product.Description;
            CategoryId = (int)product.CategoryId;
        }
        private void ExcuteUpdateProductCommand(object obj)
        {
            ProductDao productDao = DataDao.Instance().GetProductDao();
            Product product = productDao.findById(Id);
            product.Name = _name;
            product.Price = _price;
            product.Quantity = _quantity;
            product.Description = _description;
            product.CategoryId = _categoryId;
            productDao.update(product);
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }
        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public int CategoryId
        {
            get => _categoryId;
            set
            {
                _categoryId = value;
                OnPropertyChanged(nameof(CategoryId));
            }
        }

    }
}
