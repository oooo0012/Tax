using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxhomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Scooter = this.scooter();
            int Truck = this.truck();
            int Coach = this.coach();
            int PrivateCar = this.privatecar();
            int Taxicar = this.taxicar();
            int perc = 0;
            DateTime start = DTP1.Value;
            DateTime end = DTP2.Value;
            if (start > end)
            {
                MessageBox.Show("錯誤!!起始日大於結束日");
                return;
            }

            int years = 365;

            if (cbx1.Text == "機車")
                perc = Scooter;
            else if (cbx1.Text == "貨車")
                perc = Truck;
            else if (cbx1.Text == "大客車")
                perc = Coach;
            else if (cbx1.Text == "自用小客車")
                perc = PrivateCar;
            else if (cbx1.Text == "營業用小客車")
                perc = Taxicar;

            listBox1.Items.Clear();
            int m;
            int f;
            int em;
            int ef;

            for (var i = start.Year; i <= end.Year; i++)
            {
                if (i > start.Year)
                {
                    m = 1;
                    f = 1;
                }
                else
                {
                    m = start.Month;
                    f = start.Day;
                }

                DateTime start2 = new DateTime(i, m, f);
                if (i < end.Year)
                {
                    em = 12;
                    ef = 31;
                }
                else
                {
                    em = end.Month;
                    ef = end.Day;
                }

                DateTime end2 = new DateTime(i, em, ef);

                TimeSpan ts = end2.Subtract(start2);
                int dayCount = ts.Days + 1;
                if (i % 400 == 0)
                    years = 366;
                else if (i % 4 == 0 && i % 100 != 0)
                    years = 366;
                else
                    years = 365;



                decimal mony = perc * dayCount / years;
                mony = Math.Truncate(mony);


                listBox1.Items.Add($"使用期間: {i}-{m}-{f} ~ {i}-{em}-{ef} ");
                listBox1.Items.Add($"計算天數: {dayCount}");
                listBox1.Items.Add($"汽缸CC數: {cbxcc.Text}");
                listBox1.Items.Add($"用途: {cbx1.Text}");
                listBox1.Items.Add($"計算公式: {perc} * {dayCount} / {years} = {mony}元");
                listBox1.Items.Add($"應納稅額: 共 {mony} 元");
                listBox1.Items.Add("---------------------------------------------------------------");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx1.Text == "機車")
            {
                cbxcc.Items.Clear();
                cbxcc.Items.Add("150以下 / 12HP以下(12.2PS以下)");
                cbxcc.Items.Add("151-250 / 12.1-20HP(12.3-20.3PS)");
                cbxcc.Items.Add("251-500 / 20.1HP以上(20.4PS以上)");
                cbxcc.Items.Add("501-600");
                cbxcc.Items.Add("601-1200");
                cbxcc.Items.Add("1201-1800");
                cbxcc.Items.Add("1801或以上");
                cbxcc.SelectedIndex = 0;
            }
            else if (cbx1.Text == "貨車")
            {
                cbxcc.Items.Clear();
                cbxcc.Items.Add("500以下");
                cbxcc.Items.Add("501-600");
                cbxcc.Items.Add("601-1200");
                cbxcc.Items.Add("1201-1800");
                cbxcc.Items.Add("1801-2400");
                cbxcc.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                cbxcc.Items.Add("3001-3600");
                cbxcc.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                cbxcc.Items.Add("4201-4800");
                cbxcc.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                cbxcc.Items.Add("5401-6000");
                cbxcc.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                cbxcc.Items.Add("6601-7200");
                cbxcc.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                cbxcc.Items.Add("7801-8400");
                cbxcc.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                cbxcc.Items.Add("9001-9600");
                cbxcc.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                cbxcc.Items.Add("10201以上");
                cbxcc.SelectedIndex = 0;
            }
            else if (cbx1.Text == "大客車")
            {
                cbxcc.Items.Clear();
                cbxcc.Items.Add("600以下");
                cbxcc.Items.Add("601-1200");
                cbxcc.Items.Add("1201-1800");
                cbxcc.Items.Add("1801-2400");
                cbxcc.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                cbxcc.Items.Add("3001-3600");
                cbxcc.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                cbxcc.Items.Add("4201-4800");
                cbxcc.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                cbxcc.Items.Add("5401-6000");
                cbxcc.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                cbxcc.Items.Add("6601-7200");
                cbxcc.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                cbxcc.Items.Add("7801-8400");
                cbxcc.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                cbxcc.Items.Add("9001-9600");
                cbxcc.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                cbxcc.Items.Add("10201以上");
                cbxcc.SelectedIndex = 0;
            }
            else if (cbx1.Text =="自用小客車")
            {
                cbxcc.Items.Clear();
                cbxcc.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                cbxcc.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                cbxcc.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                cbxcc.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                cbxcc.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                cbxcc.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                cbxcc.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS");
                cbxcc.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                cbxcc.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                cbxcc.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                cbxcc.Items.Add("7801以上");
                cbxcc.SelectedIndex = 0;
            }
            else if (cbx1.Text == "營業用小客車")
            {
                cbxcc.Items.Clear();
                cbxcc.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                cbxcc.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                cbxcc.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                cbxcc.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                cbxcc.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                cbxcc.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                cbxcc.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS)");
                cbxcc.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                cbxcc.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                cbxcc.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                cbxcc.Items.Add("7801以上");
                cbxcc.SelectedIndex = 0;
            }
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            this.DTP1.Visible = false;
            this.DTP2.Visible = false;
            this.label5.Visible = false;
            this.label7.Visible = false;
            DTP1.Value = new DateTime(DateTime.Now.Year, 01, 01);
            DTP2.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            this.DTP1.Visible = true;
            this.DTP2.Visible = true;
            this.label5.Visible = true;
            this.label7.Visible = true;
        }
        
        private void Init()
        {
            this.rad1.Checked = true;
            this.cbx1.SelectedIndex = 0;
            listBox1.Items.Clear();
            this.cbxcc.SelectedIndex = 0;
            DTP1.Value = new DateTime(2021, 01, 01);
            DTP2.Value = new DateTime(2021, 12, 31);
        }

        private int scooter()
        {
            string texttype = this.cbxcc.Text;

            switch (texttype)
            {
                case "150以下 / 12HP以下(12.2PS以下)":
                    return 0;
                case "151-250 / 12.1-20HP(12.3-20.3PS)":
                    return 800;
                case "251-500 / 20.1HP以上(20.4PS以上)":
                    return 1620;
                case "501-600":
                    return 2160;
                case "601-1200":
                    return 4320;
                case "1201-1800":
                    return 7120;
                case "1801或以上":
                    return 11230;
                default:
                    return 0;
            }
        }
        private int truck()
        {
            string textt = this.cbxcc.Text;

            switch (textt)
            {
                case "500以下":
                    return 900;
                case "501-600":
                    return 1080;
                case "601-1200":
                    return 1800;
                case "1201-1800":
                    return 2700;
                case "1801-2400":
                    return 3600;
                case "2401-3000 / 138HP以下(140.1PS以下)":
                    return 4500;
                case "3001-3600":
                    return 5400;
                case "3601-4200 / 138.1-200HP(140.2-203.0PS)":
                    return 6300;
                case "4201-4800":
                    return 7200;
                case "4801-5400 / 200.1-247HP(203.1-250.7PS)":
                    return 8100;
                case "5401-6000":
                    return 9000;
                case "6001-6600 / 247.1-286HP(250.8-290.3PS)":
                    return 9900;
                case "6601-7200":
                    return 10800;
                case "7201-7800 / 286.1-336HP(290.4-341.0PS)":
                    return 11700;
                case "7801-8400":
                    return 12600;
                case "8401-9000 / 336.1-361HP(341.1-366.4PS)":
                    return 13500;
                case "9001-9600":
                    return 14400;
                case "9601-10200 / 361.1HP以上(366.5PS以上)":
                    return 15300;
                case "10201以上":
                    return 16200;
                default:
                    return 0;
            }
        }
        private int coach()
        {
            string textt = this.cbxcc.Text;

            switch (textt)
            {
                case "600以下":
                    return 1080;
                case "601-1200":
                    return 1800;
                case "1201-1800":
                    return 2700;
                case "1801-2400":
                    return 3600;
                case "2401-3000 / 138HP以下(140.1PS以下)":
                    return 4500;
                case "3001-3600":
                    return 5400;
                case "3601-4200 / 138.1-200HP(140.2-203.0PS)":
                    return 6300;
                case "4201-4800":
                    return 7200;
                case "4801-5400 / 200.1-247HP(203.1-250.7PS)":
                    return 8100;
                case "5401-6000":
                    return 9000;
                case "6001-6600 / 247.1-286HP(250.8-290.3PS)":
                    return 9900;
                case "6601-7200":
                    return 10800;
                case "7201-7800 / 286.1-336HP(290.4-341.0PS)":
                    return 11700;
                case "7801-8400":
                    return 12600;
                case "8401-9000 / 336.1-361HP(341.1-366.4PS)":
                    return 13500;
                case "9001-9600":
                    return 14400;
                case "9601-10200 / 361.1HP以上(366.5PS以上)":
                    return 15300;
                case "10201以上":
                    return 16200;
                default:
                    return 0;
            }
        }
        private int privatecar()
        {
            string texttype = this.cbxcc.Text;

            switch (texttype)
            {
                case "500以下 / 38HP以下(38.6PS以下)":
                    return 1620;
                case "501~600 / 38.1-56HP(38.7-56.8PS)":
                    return 2160;
                case "601~1200 / 56.1-83HP(56.9-84.2PS)":
                    return 4320;
                case "1201~1800 / 83.1-182HP(84.3-184.7PS)":
                    return 7120;
                case "1801~2400 / 182.1-262HP(184.8-265.9PS)":
                    return 11230;
                case "2401~3000 / 262.1-322HP(266-326.8PS)":
                    return 15210;
                case "3001-4200 / 322.1-414HP(326.9-420.2PS":
                    return 28220;
                case "4201-5400 / 414.1-469HP(420.3-476.0PS)":
                    return 46170;
                case "5401-6600 / 469.1-509HP(476.1-516.6PS)":
                    return 69690;
                case "6601-7800 / 509.1HP以上(516.7PS以上)":
                    return 117000;
                case "7801以上":
                    return 151200;
                default:
                    return 0;

            }
        }
        private int taxicar()
        {
            string texttype = this.cbxcc.Text;

            switch (texttype)
            {
                case "500以下 / 38HP以下(38.6PS以下)":
                    return 900;
                case "501~600 / 38.1-56HP(38.7-56.8PS)":
                    return 1260;
                case "601~1200 / 56.1-83HP(56.9-84.2PS)":
                    return 2160;
                case "1201~1800 / 83.1-182HP(84.3-184.7PS)":
                    return 3060;
                case "1801~2400 / 182.1-262HP(184.8-265.9PS)":
                    return 6480;
                case "2401~3000 / 262.1-322HP(266-326.8PS)":
                    return 9900;
                case "3001-4200 / 322.1-414HP(326.9-420.2PS":
                    return 16380;
                case "4201-5400 / 414.1-469HP(420.3-476.0PS)":
                    return 24300;
                case "5401-6600 / 469.1-509HP(476.1-516.6PS)":
                    return 33660;
                case "6601-7800 / 509.1HP以上(516.7PS以上)":
                    return 44460;
                case "7801以上":
                    return 56700;
                default:
                    return 0;

            }
        }
    }
}
