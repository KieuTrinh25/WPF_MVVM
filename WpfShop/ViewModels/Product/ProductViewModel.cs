
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfShop.Data.Dao;

namespace WpfShop.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        public MainViewModel _mainViewModel;
        
        public ObservableCollection<Product> _productList;

        public ObservableCollection<Product> ProductList
        {
            get { return _productList; }
            set
            {
                _productList = value;
                OnPropertyChanged(nameof(ProductList));
            }
        }

        public ICommand ShowCreateProductViewCommand { get; }
        public ICommand ShowEditProductViewCommand { get; }

        public ICommand DeleteProductViewCommand { get; }

        public ProductViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            ShowCreateProductViewCommand = new ViewModelCommand(ExecuteShowCreateProductViewCommand);
            ShowEditProductViewCommand = new ViewModelCommand(ExecuteShowEditProductViewCommand);
            DeleteProductViewCommand = new ViewModelCommand(ExecuteDeleteProductViewCommand);
            InitData();
        }
        private void InitData()
        {
            ProductDao productDao = DataDao.Instance().GetProductDao();
            List<Product> list = productDao.findAll();

            _productList = new ObservableCollection<Product>();
            foreach (Product product in list)
            {
                _productList.Add(product);
            }
        }
        private void ExecuteShowCreateProductViewCommand(object obj)
        {
            _mainViewModel.CurrentChildView = new CreateProductViewModel();
            _mainViewModel.Caption = "Create Products";
            _mainViewModel.Icon = IconChar.ShoppingBag;
        }
        private void ExecuteShowEditProductViewCommand(object obj)
        {
            int Id = (int)obj;
            _mainViewModel.CurrentChildView = new EditProductViewModel(Id);
            _mainViewModel.Caption = "Edit Products";
            _mainViewModel.Icon = IconChar.ShoppingBag;

        }
        private void ExecuteDeleteProductViewCommand(object obj)
        {
            int Id = (int)obj;
            DataDao.Instance().GetProductDao().deleteById(Id);
        }

    }
}
