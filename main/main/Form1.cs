﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        DataContainer.Load("times.txt", "order.csv");
        MessageBox.Show(string.Format("{0},{1}", DataContainer.routes.Length, DataContainer.orders.Count));
    }
  }
}
