using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Invertidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCaculcuar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumero.Text);
            int res = procesarNum(num);
            txtInvertido.Text = res.ToString();
        }
        int procesarNum(int num)
        {
            int invertido = 0;
            while (num >0)
            {
                invertido = invertido * 10 + num % 10;
                num = num / 10;
            }
            return invertido;
            
            
        }

    }
}
