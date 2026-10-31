using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Software_sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtnumofpack.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Fadlan geli tiro sax ah oo xirmooyin ah.", "Cilad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtpriceper.Text, out double pricePerPackage) || pricePerPackage < 0)
            {
                MessageBox.Show("Fadlan geli qiimo sax ah.", "Cilad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 
            double subtotal = quantity * pricePerPackage;
            double discountRate = 0.0;

           //
            if (quantity >= 10 && quantity <= 19)
            {
                discountRate = 0.20; 
            }
            else if (quantity >= 20 && quantity <= 49)
            {
                discountRate = 0.30; 
            }
            else if (quantity >= 50 && quantity <= 99)
            {
                discountRate = 0.40; 
            }
            else if (quantity >= 100)
            {
                discountRate = 0.50; 
            }
            
            double discountAmount = subtotal * discountRate;
            double totalAmount = subtotal - discountAmount;

            //
            lstresult.Items.Clear();
            lstresult.Items.Add($"number of package: {quantity}");
            lstresult.Items.Add($"price of package: ${pricePerPackage:N2}");
            lstresult.Items.Add($"subtotsl (Before discount): ${subtotal:N2}");
            lstresult.Items.Add($"discountrate: {discountRate * 100}%");
            lstresult.Items.Add($"discountamount: ${discountAmount:N2}");
            lstresult.Items.Add("----------------------");
            lstresult.Items.Add($"totalamount : ${totalAmount:N2}");
        }





        //

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtnumofpack.Clear();
            txtpriceper.Clear();
            lstresult.Items.Clear();
            txtnumofpack.Focus();
        }



        private void btnExit_Click(object sender, EventArgs e)
            
        {
            this.Close();
        }

       
       
        }

        
           
          
        }
    

