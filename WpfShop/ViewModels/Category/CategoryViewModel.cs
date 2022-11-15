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
    public class CategoryViewModel : ViewModelBase
    {
        public MainViewModel _mainViewModel;

        public ObservableCollection<Category> _categoryList;

        public ObservableCollection<Category> CategoryList
        {
            get { return _categoryList; }

            set 
            { 
                _categoryList = value;
                OnPropertyChanged(nameof(CategoryList));
            }
        }
        public ICommand ShowCreateCategoryViewCommand { get; }
        public ICommand ShowEditCategoryViewCommand { get; }
        public ICommand DeleteCategoryViewCommand { get; }
        public CategoryViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            ShowCreateCategoryViewCommand = new ViewModelCommand(ExecuteShowCreateCategoryViewCommand);
            ShowEditCategoryViewCommand = new ViewModelCommand(ExecuteShowEditCategoryViewCommand);
            DeleteCategoryViewCommand = new ViewModelCommand(ExecuteDeleteCategoryViewCommand);
            InitData();
        }

        private void InitData()
        {
            CategoryDao categoryDao = DataDao.Instance().GetCategoryDao();
            List<Category> list = categoryDao.findAll();

            _categoryList = new ObservableCollection<Category>();
            foreach (Category category in list)
            {
                _categoryList.Add(category);
            }
        }
        private void ExecuteShowCreateCategoryViewCommand(object obj)
        {
            _mainViewModel.CurrentChildView = new CreateCategoryViewModel();
            _mainViewModel.Caption = "Create Categories";
            _mainViewModel.Icon = IconChar.Box;
        }
        private void ExecuteShowEditCategoryViewCommand(object obj)
        {
            int Id = (int)obj;
            _mainViewModel.CurrentChildView = new EditCategoryViewModel(Id);
            _mainViewModel.Caption = "Edit Categories";
            _mainViewModel.Icon = IconChar.Box;

        }
        private void ExecuteDeleteCategoryViewCommand(object obj)
        {
            int Id = (int)obj;
            DataDao.Instance().GetCategoryDao().deleteById(Id);
        }
    }
}
