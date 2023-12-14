using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenRatioMethod
{
  public partial class SLAE : Form
  {
    double[,] Matrix;
    MainForm mainForm;
    public SLAE(MainForm form)
    {
      InitializeComponent();
      mainForm = form;
    }


    private void CreateRandomMatrix()
    {

    }

    private void SLAE_Load(object sender, EventArgs e)
    {

    }

    private void методыToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      mainForm.Show();
    }

    private void нахождениеЛогарифмаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      FindIntegral FindIntegral = new FindIntegral(mainForm);
      FindIntegral.Show();
    }

    private void сортировкиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      Sorting sorting = new Sorting(mainForm);
      sorting.Show();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
