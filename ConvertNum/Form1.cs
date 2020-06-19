using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Box1
            OneNum.Items.Add("мм"); //0
            OneNum.Items.Add("см"); //1
            OneNum.Items.Add("дм"); //2
            OneNum.Items.Add("м");  //3
            OneNum.Items.Add("км"); //4
            #endregion
            #region Box2
            EndNum.Items.Add("мм");
            EndNum.Items.Add("см");
            EndNum.Items.Add("дм");
            EndNum.Items.Add("м");
            EndNum.Items.Add("км");
            #endregion
        }
        #region Box
        private void SetNum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OneNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EndNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        #endregion
        double num;
        double rez;
        #region variables MM
        double MMsm = 10;
        double MMdm = 100;
        double MMm = 1000;
        double MMkm = 1000000;
        #endregion

        private void Sum_Click(object sender, EventArgs e)
        {
            #region Index
            bool Mm = OneNum.SelectedIndex == 0;
            bool s = EndNum.SelectedIndex == 1;
            bool d = EndNum.SelectedIndex == 2;
            bool m = EndNum.SelectedIndex == 3;
            bool k = EndNum.SelectedIndex == 4;
            #endregion

            num = Convert.ToDouble(SetNum.Text);

            #region MM
            if (Mm && s)
            {
                rez = num / MMsm;
                Rezultat.Text = "Результат: " + rez.ToString() + " см";
            }

            /*if (s == Mm)
            {
                rez = num * MMsm;
                Rezultat.Text = "Результат: " + rez.ToString() + " мм";
            }*/

            if (Mm && d)
            {
                rez = num / MMdm;
                Rezultat.Text = "Результат: " + rez.ToString() + " дм";
            }

            if (Mm && m)
            {
                rez = num / MMm;
                Rezultat.Text = "Результат: " + rez.ToString() + " м";
            }

            if (Mm && k)
            {
                rez = num / MMkm;
                Rezultat.Text = "Результат: " + rez.ToString() + " км";
            }
            #endregion
        }
        #region Text
        private void UserNum_Click(object sender, EventArgs e)
        {

        }

        private void Rezultat_Click(object sender, EventArgs e)
        {
            
        }

        private void IzNum_Click(object sender, EventArgs e)
        {

        }

        private void Vnum_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
