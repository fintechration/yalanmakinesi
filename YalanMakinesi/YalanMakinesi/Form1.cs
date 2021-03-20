using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YalanMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            MessageBox.Show("TEBRIKLER DOĞRU CEVAP");
            
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            MessageBox.Show("MAALESEF BILEMEDINIZ :(");
          

        }
    }
}
