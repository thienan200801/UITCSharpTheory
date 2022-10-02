using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApp1
{
    //internal class Program
    //{
    //    //static void Main(string[] args)
    //    //{
    //    //    Form f = new Form();
    //    //    Application.Run(f);
    //    //}
    //    static TextBox t1, t2, t3;
    //    public static void Main()
    //    {
    //        //Form form1 = new Form();
    //        //Form form2 = new Form();

    //        //form1.Text = "Form passed to Run()";

    //        //form2.Text = "Second form";
    //        //form2.Show(); //other forms

    //        //Application.Run(form1); // default form, this's the first form that run when code run

    //        //MessageBox.Show("Application.Run() has returned control back to Main.Bye, bye!", "TwoForms");
    //        Form form = new Form();
    //        form.Text = "Form Properties";
    //        form.BackColor = System.Drawing.Color.AliceBlue;
    //        form.Width *= 2;
    //        form.Height *= 2;
    //        form.FormBorderStyle = FormBorderStyle.FixedSingle;
    //        form.MaximizeBox = false;
    //        form.Cursor = Cursors.SizeAll;
    //        form.StartPosition = FormStartPosition.CenterScreen;

    //        Button btn = new Button();
    //        btn.Text = "=";
    //        btn.BackColor = System.Drawing.Color.White;
    //        btn.Cursor = Cursors.Hand;
    //        btn.Click += new EventHandler(MyButtonHandler);

    //        t1 = new TextBox();
    //        t1.Top = 50;
    //        form.Controls.Add(t1);
    //        t2 = new TextBox();
    //        t2.Top = 80;
    //        form.Controls.Add(t2);
    //        t3 = new TextBox();
    //        form.Controls.Add(t3);
    //        t3.Top = 120;

    //        form.Controls.Add(btn);
    //        Application.Run(form);
    //    }

    //    static void MyButtonHandler(object sender, EventArgs e)
    //    {
    //        int a = int.Parse(t1.Text);
    //        int b = int.Parse(t2.Text);
    //        t3.Text = (a+b).ToString();            
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "Calculator";
            form.BackColor = System.Drawing.Color.AliceBlue;
            form.Width *= 2;
            form.Height *= 2;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Cursor = Cursors.SizeAll;
            form.StartPosition = FormStartPosition.CenterScreen;

            TextBox res = new TextBox();
            res.Text = "0";
            res.Dock = DockStyle.Fill;
            res.TextAlign = HorizontalAlignment.Right;
            res.Font = new Font("Arial", 24);
            form.Controls.Add(res);

            Button[,] btn = new Button[4, 6];
      
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    //btn[i,j].Text = i.ToString();
                    //btn[i,j].Size = new Size(20, 20);                
                    form.Controls.Add((btn[i,j]));
                }
            }
            btn[0, 0].Top = 50;
            btn[0, 0].Left = 20;
            int i2, j2;
            for(i2 = 0; i2 < 4; i2++)
            {
                for(j2 = 0; j2 < 6; j2++)
                {
                    btn[i2, j2].Left = btn[i2 - 1, j2 - 1].Left + 20;
                }
                btn[i2, j2].Top = btn[i2 - 1, j2 - 1].Top + 20;
            }

            Application.Run(form);
        }
        
    }
}
