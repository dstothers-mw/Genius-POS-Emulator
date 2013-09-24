using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace POS_demo_app
{
    public partial class SKUTestForm : Form
    {
        public SKUTestForm()
        {
            InitializeComponent();

            txtURL.Text = Properties.Settings.Default.TransportURL;
            txtFormat.Text = Properties.Settings.Default.Format;
        }

        private void btnSendItem_Click(object sender, EventArgs e)
        {
            string message = "";
            message += "Action=" + txtAction.Text + "&";
            message += "Order=" + txtOrder.Text + "&";
            message += "ItemID=" + txtItemID.Text + "&";
            message += "Type=" + txtType.Text + "&";
            message += "Value=" + txtValue.Text + "&";
            message += "UPC=" + txtUPC.Text + "&";
            message += "Quantity=" + txtQuantity.Text + "&";
            message += "Description=" + txtDescription.Text + "&";
            message += "Amount=" + txtAmount.Text + "&";
            message += "AddTaxAmount=" + txtTaxAmount.Text + "&";
            message += "TotalAmount=" + txtTotalAmount.Text + "&";
            message += "TotalTax=" + txtTotalTax.Text + "&";
            message += "Category=" + txtCategory.Text + "&";
            message += "DisplayOverride=" + txtDisplayOverride.Text + "&";
            message += "DisplayCustomSubTotal=" + txtDisplayCustomSubTotal.Text;
            message += txtFormat.Text;

            SendRequest(message);
        }


        private void btnStartOrder_Click(object sender, EventArgs e)
        {
            SendRequest("Action=StartOrder&Order=" + txtOrder.Text + "&Format=" + txtFormat.Text);
        }

        private void btnEndOrder_Click(object sender, EventArgs e)
        {
            SendRequest("Action=EndOrder&Order=" + txtOrder.Text + "&ExternalPaymentType=&Format=" + txtFormat.Text);
        }

        private void SendRequest(String message)
        {
            string uri = txtURL.Text;

            //Initialization
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(uri + "{0}", message));
            WebReq.Method = "GET";

            txtLog.AppendText("-------------------------------------------------------------------------------------------------------------------------\n");
            txtLog.AppendText(DateTime.Now + ": Starting SKU request\n");
            txtLog.AppendText(DateTime.Now + ": Target URL » " + string.Format(uri + "{0}\n", message));

            try
            {
                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
                //Let's show some information about the response
                txtLog.AppendText(DateTime.Now + ": Status code: " + WebResp.StatusCode + "\n");
                txtLog.AppendText(DateTime.Now + ": Server: " + WebResp.Server + "\n");

                //Now, we read the response (the string), and output it.
                Stream Answer = WebResp.GetResponseStream();
                // StreamReader _Answer = new StreamReader(Answer);
                //Console.WriteLine(_Answer.ReadToEnd());

                txtLog.AppendText(DateTime.Now + ": Reading response...\n");

                List<string> list = new List<string>();
                using (StreamReader reader = new StreamReader(Answer))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        list.Add(line); // Add to list.
                        Console.WriteLine(line); // Write to console.
                        txtLog.AppendText(line + "\n");
                    }

                    txtLog.AppendText(DateTime.Now + ": Finished reading response\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect: " + ex.Message);
            }

            txtLog.AppendText(DateTime.Now + ": Function finished\n");
            txtLog.AppendText("-------------------------------------------------------------------------------------------------------------------------\n");
        }

        private void btnClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtLog.Text = "";
        }
    }

    class OrderDetail
    {
        public string Amount { get; set; }
    }
}
