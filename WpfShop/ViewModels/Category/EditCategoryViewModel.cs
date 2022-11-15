using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;
using WpfShop.Data.Dao;

namespace WpfShop.ViewModels
{
    public class EditCategoryViewModel : ViewModelBase
    {
        private String _name;
        private String _description;

        public ICommand UpdateCategoryCommand { get; }

        private int Id { get; set; }

        public EditCategoryViewModel(int id)
        {
            this.Id = id;
            UpdateCategoryCommand = new ViewModelCommand(ExcuteUpdateCategoryCommand);
        }
        private void InitData()
        {
            CategoryDao categoryDao = DataDao.Instance().GetCategoryDao();
            Category category = categoryDao.findById(Id);
            Name = category.Name;
            Description = category.Description;
        }
        private void ExcuteUpdateCategoryCommand(object obj)
        {
            CategoryDao categoryDao = DataDao.Instance().GetCategoryDao();
            Category category = categoryDao.findById(Id);
            Name = category.Name;
            Description = category.Description;
            categoryDao.update(category);
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
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
    }
}
