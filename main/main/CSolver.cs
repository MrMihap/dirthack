using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
  class CSolver
  {
    public static void TrySolve()
    {
      
      DataContainer.orders.OrderBy(x => x.departTime);
      int matrix_lenth = DataContainer.routes.Length;
      
      while (DataContainer.orders.Count > 0)
      {
        int id = DataContainer.orders[0].id;
        runCab(id);
        return;
      }


    }
    private static void runCab(int id)
    {
      // single iter
      // get first
      CSolution sol = new CSolution();

      sol.orders.Add(DataContainer.orders[id]);
      DataContainer.orders.Remove(DataContainer.orders[id]);
      List<Order> avalible = GetAvalible(DataContainer.orders[id].start, DataContainer.orders[id].departTime);
      sol.orders.Add(avalible[0]);
      if (DataContainer.routes[sol.orders[1].start, sol.orders[0].finish] >
        DataContainer.routes[sol.orders[1].start, sol.orders[1].finish])
      {
        sol.orders.Add(sol.orders[1]);
        sol.orders.Add(sol.orders[0]);
      }
      else
      {
        sol.orders.Add(sol.orders[0]);
        sol.orders.Add(sol.orders[1]);
      }
      File.WriteAllText("answer.txt", sol.ToString());
      
      //while(avalible.Count > 0)
      //{
        
      //}

    }
    private static List<Order> GetAvalible(int P, int Time)
    {
      List<Order> result = new List<Order>();

      foreach (Order order in DataContainer.orders)
      {
        if (Time + DataContainer.routes[P, order.start] <= order.departTime + 15)
          result.Add(order);
      }
      result.OrderBy(i => DataContainer.routes[P, i.start]);

      return result;
    }
  }
}
