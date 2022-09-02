using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6activity7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double approx3(int terms)
            {
                double sum = 0.0;
                int i = 1, x = 1, po = 0;
                while (i <= terms)
                {
                    if (i % 2 != 0)
                        sum = sum + (double)sqrt(12) / (x * pow(3, po));
                    else
                        sum = sum - (double)sqrt(12) / (x * pow(3, po));
                    po++;
                    x += 2;
                    i++;
                }
                return sum;
            }
            double approx2(int terms)
            {
                double sum = 0.0;
                int i = 1, x = 1;
                while (i <= terms)
                {
                    if (i % 2 != 0)
                        sum = sum + (double)12 / (x * x);
                    else
                        sum = sum - (double)12 / (x * x);
                    x++;
                    i++;
                }
                return sqrt(sum);
            }
            double approx1(int terms)
            {
                double sum = 0.0;
                int i = 1, x = 1;
                while (i <= terms)
                {
                    if (i % 2 != 0)
                        sum = sum + (double)4 / x;
                    else
                        sum = sum - (double)4 / x;
                    x += 2;
                    i++;
                }
                return sum;
            }
            int main(void)
            {
                int terms;
                do
                {
                    printf("\n\nEnter the number of terms to approximate pi, or 0 to terminate: ");
                    Scale("%d", &terms);
                    if (terms < 0)
                    {
                        printf("\n\tWrong input, please try again..");
                        continue;
                    }
                    else if (terms == 0)
                    {
                        printf("\n\t***** Program Terminated *****");
                        break;
                    }
                    else
                    {
                        printf("\nFirst approximation of pi to 10000 terms is : %.8lf", approx1(terms));
                        printf("\nSecond approximation of pi to 10000 terms is : %.8lf", approx2(terms));
                        printf("\nThird approximation of pi to 10000 terms is : %.8lf", approx3(terms));
                    }
                } while (terms != 0);
                printf("\n");
                return 0;
            }
#pragma warning restore CS8321 // Local function is declared but never used
        }

        private void printf(string v1, double v2)
        {
            throw new NotImplementedException();
        }

        private unsafe void Scale(string v1, int* v2)
        {
            throw new NotImplementedException();
        }

        private void printf(string v)
        {
            throw new NotImplementedException();
        }

        private double sqrt(double sum)
        {
            throw new NotImplementedException();
        }

        private int pow(int v, int po)
        {
            throw new NotImplementedException();
        }

        private double sqrt(int v)
        {
            throw new NotImplementedException();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            OnClick(null);
        }
    }
}
