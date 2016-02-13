using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
  public partial class Form1 : Form
  {
      const string SOLNAME = "solution.txt";
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        DataContainer.Load("times.txt", "order.csv");
        //MessageBox.Show(string.Format("{0},{1}", DataContainer.routes.Length, DataContainer.orders.Count));
    }

    private void btCheck_Click(object sender, EventArgs e)
    {
        string checkResult = RunChecker();
        MessageBox.Show(checkResult);
    }
    private string RunChecker()
    {
        string procName = "python";
        string args = " check.py " + SOLNAME;
        Process p = new Process();
        p.StartInfo.FileName = procName;
        p.StartInfo.Arguments = args;
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardOutput = true;
        p.Start();
        string output = p.StandardOutput.ReadToEnd();
        return output;
    }
  }
}
