using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;



namespace YalanMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.File("logs/yalanmakinesi_.log", rollingInterval: RollingInterval.Day,
               outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
               .CreateLogger();

            InitializeComponent();
            Log.Information("--------------------------Uygulama calıstırıldı--------------------------");
            FormClosed += Form1_Formclosed;
            FormClosing += Form1_FormClosing;
          
        }

        private void Form1_Formclosed(object sender, FormClosedEventArgs e)
        {
            Log.Information("Uygulama kapatıldı");
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Log.Information("Yes butonuna tıklandı.");
            this.BackColor = Color.Green;
            Log.Information("Arka plan rengi yesile dönüstürüldü.");
            MessageBox.Show("TEBRIKLER DOĞRU CEVAP");
            Log.Information("Mesaj kutusunda bilgi verildi");


        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            Log.Information("No butonuna tıklandı.");
            this.BackColor = Color.Red;
            Log.Information("Arka plan rengi kırmızıya dönüstürüldü.");
            MessageBox.Show("MAALESEF BILEMEDINIZ :(");
            Log.Information("Mesaj kutusunda bilgi verildi");

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.Debug("Uygulama kapatma dügmesine basıldı.");
            
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?"," ",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                Log.Information("Kapatma işlemi iptal edildi.");

                // iptal ederseniz ne yapacağınızı buraya yazın
                
            }
           
                
           

        }
    }
}
