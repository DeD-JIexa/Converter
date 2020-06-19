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
        #region variables SM
        double SMmm = 10;
        double SMdm = 10;
        double SMm = 100;
        double SMkm = 1000;
        #endregion
        #region variables DM
        double DMmm = 100;
        double DMsm = 10;
        double DMm = 10;
        double DMkm = 10000;
        #endregion
        #region variables M
        double Mmm = 1000;
        double Msm = 100;
        double Mdm = 10;
        double Mkm = 1000;
        #endregion
        #region variables KM
        double KMmm = 1000000;
        double KMsm = 100000;
        double KMdm = 10000;
        double KMm = 1000;
        #endregion

        private void Sum_Click(object sender, EventArgs e)
        {
            #region Index1
            bool OMm = OneNum.SelectedIndex == 0;
            bool Os = OneNum.SelectedIndex == 1;
            bool Od = OneNum.SelectedIndex == 2;
            bool Om = OneNum.SelectedIndex == 3;
            bool Ok = OneNum.SelectedIndex == 4;
            #endregion
            #region Index2
            bool EMm = EndNum.SelectedIndex == 0;
            bool Es = EndNum.SelectedIndex == 1;
            bool Ed = EndNum.SelectedIndex == 2;
            bool Em = EndNum.SelectedIndex == 3;
            bool Ek = EndNum.SelectedIndex == 4;
            #endregion

            num = Convert.ToDouble(SetNum.Text);

            #region MM
            if (OMm && Es)
            {
                rez = num / MMsm;
                Rezultat.Text = "Результат: " + rez.ToString() + " см";
            }

            if (OMm && Ed)
            {
                rez = num / MMdm;
                Rezultat.Text = "Результат: " + rez.ToString() + " дм";
            }

            if (OMm && Em)
            {
                rez = num / MMm;
                Rezultat.Text = "Результат: " + rez.ToString() + " м";
            }

            if (OMm && Ek)
            {
                rez = num / MMkm;
                Rezultat.Text = "Результат: " + rez.ToString() + " км";
            }
            #endregion
            #region SM
            if (Os && EMm)
            {
                rez = num * SMmm;
                Rezultat.Text = "Результат: " + rez.ToString() + " мм";
            }

            if (Os && Ed)
            {
                rez = num / SMdm;
                Rezultat.Text = "Результат: " + rez.ToString() + " дм";
            }

            if (Os && Em)
            {
                rez = num / SMm;
                Rezultat.Text = "Результат: " + rez.ToString() + " м";
            }

            if (Os && Ek)
            {
                rez = num / SMkm;
                Rezultat.Text = "Результат: " + rez.ToString() + " км";
            }
            #endregion
            #region DM
            if (Od && EMm)
            {
                rez = num * DMmm;
                Rezultat.Text = "Результат: " + rez.ToString() + " мм";
            }

            if (Od && Es)
            {
                rez = num * DMsm;
                Rezultat.Text = "Результат: " + rez.ToString() + " см";
            }

            if (Od && Em)
            {
                rez = num / DMm;
                Rezultat.Text = "Результат: " + rez.ToString() + " м";
            }

            if (Od && Ek)
            {
                rez = num / DMkm;
                Rezultat.Text = "Результат: " + rez.ToString() + " км";
            }
            #endregion
            #region M
            if (Om && EMm)
            {
                rez = num * Mmm;
                Rezultat.Text = "Результат: " + rez.ToString() + " мм";
            }

            if (Om && Es)
            {
                rez = num * Msm;
                Rezultat.Text = "Результат: " + rez.ToString() + " см";
            }

            if (Om && Ed)
            {
                rez = num * Mdm;
                Rezultat.Text = "Результат: " + rez.ToString() + " дм";
            }

            if (Om && Ek)
            {
                rez = num / Mkm;
                Rezultat.Text = "Результат: " + rez.ToString() + " км";
            }
            #endregion
            #region KM
            if (Ok && EMm)
            {
                rez = num * KMmm;
                Rezultat.Text = "Результат: " + rez.ToString() + " мм";
            }

            if (Ok && Es)
            {
                rez = num * KMsm;
                Rezultat.Text = "Результат: " + rez.ToString() + " см";
            }

            if (Ok && Ed)
            {
                rez = num * KMdm;
                Rezultat.Text = "Результат: " + rez.ToString() + " дм";
            }

            if (Ok && Em)
            {
                rez = num * KMm;
                Rezultat.Text = "Результат: " + rez.ToString() + " м";
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
