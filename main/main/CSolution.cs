using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
  class CSolution
  {
    //public int startTime = 0;
    //public int startPoint = 0;
    //список высадки/посадки 
    //один 
    //public List<int> points = new List<int>();
    /// <summary>
    /// List of vertextes of path
    /// </summary>
    public List<Order> orders = new List<Order>();
    public override string ToString()
    {
        string str = string.Format("{0} {1} {2},", orders[0].departTime, orders[0].start, orders[0].id);
        for (int i = 1; i < orders.Count; i++)
        {
            str += GetOrder(i) + ",";
        }
        return str;
    }
    public string GetOrder(int pos)
    {
        Order now = orders[pos];
        Order prev = orders[pos - 1];
        bool nowWas = CheckWas(pos);
        bool prevWas = CheckWas(pos);
        return GetStrFull(now, nowWas);
    }
      private string GetStrFull(Order ord, bool was)
    {
        return string.Format("{0} {1}", was ? ord.finish : ord.start, ord.id);
    }
      private string GetStrPart(Order ord)
      {
          return string.Format("{0}", ord.id);
      }
      public bool CheckWas(int pos)
    {
        Order now = orders[pos];
        for (int i = 0; i < pos; i++)
        {
            if (orders[i] == now)
                return true;
        }
        return false;
    }
  }
}
 