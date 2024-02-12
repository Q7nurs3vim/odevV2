using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_koleksiyonu
{
    public partial class Form1 : Form
    {
        Stack yigin = new Stack();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            yigin.Push(txtAdSoyad.Text);
            Listele();
        }

        private void Listele()
        {
            lbStack.Items.Clear();
            foreach (string eleman in yigin)
            {
                lbStack.Items.Add(eleman);
            }
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            yigin.Pop();
            Listele();
        }
    }
}
