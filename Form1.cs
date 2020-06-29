using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFormater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
            string s = "   str1 str2   ";
            string o = s.TrimStart(' ');
            o = o.TrimEnd(' ');

            
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            n_tb.Text = n_tb.Text.TrimStart(' ');
            n_tb.Text = n_tb.Text.ToLower();
            n_tb.Text = n_tb.Text.Remove(0, 1).Insert(0, Char.ToUpper(n_tb.Text[0]).ToString());

            s_tb.Text = s_tb.Text.TrimStart(' ');
            s_tb.Text = s_tb.Text.ToLower();
            s_tb.Text = s_tb.Text.Remove(0, 1).Insert(0, Char.ToUpper(s_tb.Text[0]).ToString());

            ot_tb.Text = ot_tb.Text.TrimStart(' ');
            ot_tb.Text = ot_tb.Text.ToLower();
            ot_tb.Text = ot_tb.Text.Remove(0, 1).Insert(0, Char.ToUpper(ot_tb.Text[0]).ToString());

            in_tb.Text = (s_tb.Text) + " " + n_tb.Text[0] + "." + " " + ot_tb.Text[0] + ".";
        }
    }
}
