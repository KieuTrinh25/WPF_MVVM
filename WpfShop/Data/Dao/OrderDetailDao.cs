using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfShop.Data.Dao
{
    public interface OrderDetailDao
    {
          void insert(OrderDetail orderDetail);
          void update(OrderDetail orderDetail);
          List<OrderDetail> findAll();
          int count();
          OrderDetail findById(int id);
          void deleteById(int id);
    }
}
