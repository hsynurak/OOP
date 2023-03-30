using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poly_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public void btn_calc_Click(object sender, EventArgs e)
        {
            
            poly my_poly = new poly();

            my_poly.a = int.Parse(txta.Text);
            my_poly.b = int.Parse(txtb.Text);
            my_poly.c = int.Parse(txtc.Text);
            my_poly.d = int.Parse(txtd.Text);
            my_poly.e = int.Parse(txte.Text);
            my_poly.f = int.Parse(txtf.Text);
            my_poly.X = int.Parse(txtX.Text);

            if (txtc.Text == "" || txtX.Text == "")
            {
                MessageBox.Show("Error, please check values or X");
            }
            else
            {
                if(txtd.Text == "")
                {
                    my_poly.poly_second_degree();
                }
                else
                {
                    if(txte.Text == "")
                    {
                        my_poly.poly_third_degree();
                    }
                    else
                    {
                        if(txtf.Text == "")
                        {
                            my_poly.poly_fourth_degree();
                        }
                        else
                        {
                            if(txtf.Text != "")
                            {
                                my_poly.poly_fifth_degree();
                            }
                            else
                            {
                                MessageBox.Show("Error!!");
                            }
                        }
                    }
                }
            }
            
            txt_answer.Text = my_poly.answer.ToString();

        }
    }

    public class poly
    {
        public int a, b, c, d, e, f, X;
        public int answer = 0;
        public int poly_second_degree()
        {
            answer = (a * X * X) + (b * X) + (c);
            return answer;
        }
        public int poly_third_degree()
        {
            answer = (a * X * X * X) + (b * X * X) + (c * X) + (d);
            return answer;
        }
        public int poly_fourth_degree()
        {
            answer = (a * X * X * X * X) + (b * X * X * X) + (c * X * X) + (d * X) + (e);
            return answer;
        }
        public int poly_fifth_degree()
        {
            answer = (a * X * X * X * X * X) + (b * X * X * X * X) + (c * X * X * X) + (d * X * X) + (e * X) + (f);
            return answer;
        }
    }

}
