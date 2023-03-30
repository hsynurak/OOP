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

namespace Poly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Poly my_poly = new Poly();

            //null atama
            //my_poly.a = null;
            //my_poly.b = null;
            //my_poly.c = null;
            //my_poly.d = null;
            //my_poly.ex = null;
            //my_poly.f = null;
            //my_poly.X = null;



            //int.TryParse(txta.Text, out my_poly.a);

            
            //txta.Text = my_poly.a.ToInt32();
            //txtb.Text = my_poly.b.ToString();
            //txtc.Text = my_poly.c.ToString();
            //txtd.Text = my_poly.d.ToString();
            //txte.Text = my_poly.e.ToString();
            //txtf.Text = my_poly.f.ToString();
            //txtX.Text = my_poly.X.ToString();


            if (txtc.Text == null || txtX.Text == null)
            {
                MessageBox.Show("Error!!! Please enter variables at least for second order equations or check X value.");
            }
            else if (txtd.Text == null) my_poly.poly_second_degree();
            else if (txte.Text == null) my_poly.poly_third_degree();
            else if (txtf.Text == null) my_poly.poly_fourth_degree();
            else if (txtf.Text != null) my_poly.poly_fifth_degree();
            else MessageBox.Show("Error!!");

            txtAnswer.Text = my_poly.answer.ToString();

            
        }

        
    }

    public class Poly
    {
        //public int? a,b,c,d,e,f,X,answer;
        //public int a { get; set; }
        //public int b { get; set; }
        //public int c { get; set; }
        //public int d { get; set; }
        //public int ex { get; set; }
        //public int f { get; set; }
        //public int X { get; set; }
        //public int answer { get; set; }

        int? a,b,c,d,ex,f,X = null;
        int? answer = 0;
        //int b = int.Parse(txtb.Text);
        //int c = int.Parse(txtc.Text);
        //int d = int.Parse(txtd.Text);
        //int ex = int.Parse(txte.Text);
        //int f = int.Parse(txtf.Text);
        //int X = int.Parse(txtX.Text);


        public int? poly_second_degree()
        {
            answer = (a * X * X) + (b * X) + (c);
            return answer;
        }
        public int? poly_third_degree()
        {
            answer = (a * X * X * X) + (b * X * X) + (c * X) + (d);
            return answer;
        }
        public int? poly_fourth_degree()
        {
            answer = (a * X * X * X * X ) + (b * X * X * X ) + (c * X * X) + (d * X) + (ex);
            return answer;
        }
        public int? poly_fifth_degree()
        {
            answer = (a * X * X * X * X * X) + (b * X * X * X * X ) + (c * X * X * X) + (d * X * X) + (ex * X) + (f);
            return answer;
        }
    }
}
