using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfShop.Data.Dao
{
    public interface ProductDao
    {
          void insert(Product product);
          void update(Product product);
          List<Product> findAll();
          int count();
          Product findById(int id);
          void deleteById(int id);
    }
}
