﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Order
    {
        public int id;
        public int start;
        public int finish;
        public int departTime;
        private Order(int _id, int _ptx, int _pty, int _dep)
        {
            id = _id;
            start = _ptx;
            finish = _pty;
            departTime = _dep;
        }
        public static Order FromString(string line)
        {
            string[] split = line.Split(',');
            return new Order(
                int.Parse(split[0]),
                int.Parse(split[1]),
                int.Parse(split[2]),
                int.Parse(split[3])
                );
        }
    }
}
