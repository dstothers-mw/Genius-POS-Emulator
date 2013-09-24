using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Threading;
using POS_demo_app.TP4;
using POS_demo_app.PaycubeTP4;

namespace POS_demo_app
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            cbTransType.Text = "SALE";

             txtName.Text = Properties.Settings.Default.MerchantName;
             txtSiteID.Text = Properties.Settings.Default.MerchantSiteID;
             txtKey.Text = Properties.Settings.Default.MerchantKey;
             txtURL.Text = Properties.Settings.Default.TransportURL;
             txtFormat.Text = Properties.Settings.Default.Format;
             comboBoxServer.Text = Properties.Settings.Default.Server;

             if (Properties.Settings.Default.AllowDuplicates)
                 cbAllowDuplicates.Checked = true;
             else
                 cbAllowDuplicates.Checked = false;

             if (Properties.Settings.Default.ShowLog)
                 gbLog.Visible = true;
             else
                 gbLog.Visible = false;

             if (Properties.Settings.Default.ShowTransDetails)
                 gbTestDetails.Visible = true;
             else
                 gbTestDetails.Visible = false;

             if (Properties.Settings.Default.SendSKU)
                 cbSKU.Checked = true;
             else
             {
                 cbSKU.Checked = false;
                 btnRemoveBurger.Enabled = false;
                 btnRemoveHotDog.Enabled = false;
                 btnRemoveFries.Enabled = false;
                 btnRemoveDrink.Enabled = false;
                 btnOrderStatus.Enabled = false;
             }

             if (txtName.Text == "" || txtSiteID.Text == "" || txtKey.Text == "" || txtURL.Text == "")
                 tabControl1.SelectedTab = tabSettings;
        }
        
        private void btnStage_Click(object sender, EventArgs e)
        {
            txtLog.AppendText("-------------------------------------------------------------------------------------------------------------------------\n");
            txtLog.AppendText(DateTime.Now + ": (" + cbTransType.Text + ") requesting token from server\n");

            if (String.IsNullOrEmpty(lblAmount.Text) || (lblAmount.Text == "0.00"))
            {
                txtLog.AppendText(DateTime.Now + ": amount is $0.00.\n");
                MessageBox.Show("Amount is $0.00. Please select at least one item.");
                txtLog.AppendText(DateTime.Now + ": aborting function\n");
                return;
            }

            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSiteID.Text) || String.IsNullOrEmpty(txtKey.Text))
            {
                txtLog.AppendText(DateTime.Now + ": merchantware credentials missing missing\n");
                MessageBox.Show("Enter your MerchantWARE credentials on the settings tab.");
                txtLog.AppendText(DateTime.Now + ": aborting function\n");
                return;
            }

            if (comboBoxServer.Text == "PC")
            {
                PaycubeTP4.TransportServiceSoapClient ws = new PaycubeTP4.TransportServiceSoapClient();
                PaycubeTP4.TransportRequest request = new PaycubeTP4.TransportRequest();
                PaycubeTP4.TransportResponse response = new PaycubeTP4.TransportResponse();

                request = SetPaycubeRequest(request, cbTransType.Text);

                try
                {
                    response = ws.CreateTransaction(txtName.Text, txtSiteID.Text, txtKey.Text, request);
                    txtLog.AppendText(DateTime.Now + ": CreateTransaction response received\n");
                }
                catch
                {
                    txtLog.AppendText(DateTime.Now + ": CreateTransaction failed. Aborting\n");
                    MessageBox.Show("CreateTransaction call failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (String.IsNullOrEmpty(response.TransportKey))
                {
                    txtLog.AppendText(DateTime.Now + ": Transaction Key field empty. Error: " + response.Messages[0].Information + "\n");
                    MessageBox.Show("No transport key.\n\n Error: \n" + response.Messages[0].Information);
                }

                txtLog.AppendText(DateTime.Now + ": Transport Key received: " + response.TransportKey + "\n");
                lblTPToken.Text = response.TransportKey;
            }
            else
            {
                TP4.TransportServiceSoapClient ws = new TP4.TransportServiceSoapClient();
                TP4.TransportRequest request = new TP4.TransportRequest();
                TP4.TransportResponse response = new TP4.TransportResponse();

                request = SetRequest(request, cbTransType.Text);

                try
                {
                    response = ws.CreateTransaction(txtName.Text, txtSiteID.Text, txtKey.Text, request);
                    txtLog.AppendText(DateTime.Now + ": CreateTransaction response received\n");
                }
                catch
                {
                    txtLog.AppendText(DateTime.Now + ": CreateTransaction failed. Aborting\n");
                    MessageBox.Show("CreateTransaction call failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (String.IsNullOrEmpty(response.TransportKey))
                {
                    txtLog.AppendText(DateTime.Now + ": Transaction Key field empty. Error: " + response.Messages[0].Information + "\n");
                    MessageBox.Show("No transport key.\n\n Error: \n" + response.Messages[0].Information);
                }

                txtLog.AppendText(DateTime.Now + ": Transport Key received: " + response.TransportKey + "\n");
                lblTPToken.Text = response.TransportKey;
            }

        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            btnStage_Click(sender, e);
            btnProcess_Click(sender, e);
        }

        private PaycubeTP4.TransportRequest SetPaycubeRequest(PaycubeTP4.TransportRequest request, string transType)
        {
            txtLog.AppendText(DateTime.Now + ": building transport request object\n");

            string tempAmount = lblAmount.Text;
            request.TransactionType = transType;
                if (transType.ToLower() == "level2sale")
                {
                    request.CustomerCode = "1234";
                    request.TaxAmount = 1.00m;
                    request.PoNumber = "12345";
                }
            request.Amount = Decimal.Parse(tempAmount);
            request.OrderNumber = "12345678";
            request.ClerkId = "1234";
            request.Dba = "POS Demo";
            request.SoftwareName = "POS Demo";
            request.SoftwareVersion = lblVersion.Text;

            if (cbAllowDuplicates.Checked)
                request.ForceDuplicate = true;
            else
                request.ForceDuplicate = false;

            txtLog.AppendText(DateTime.Now + ": transport request built\n");
            txtLog.AppendText(DateTime.Now + ": calling CreateTransaction web service method\n");

            return request;
        }

        private TP4.TransportRequest SetRequest(TP4.TransportRequest request, string transType)
        {
            txtLog.AppendText(DateTime.Now + ": building transport request object\n");

            string tempAmount = lblAmount.Text;
            request.TransactionType = transType;
                if (transType.ToLower() == "level2sale")
                {
                    request.CustomerCode = "1234";
                    request.TaxAmount = 1.00m;
                    request.PoNumber = "12345";
                }
            request.Amount = Decimal.Parse(tempAmount);
            request.OrderNumber = "12345678";
            request.ClerkId = "1234";
            request.Dba = "POS Demo";
            request.SoftwareName = "POS Demo";
            request.SoftwareVersion = lblVersion.Text;

            if (cbAllowDuplicates.Checked)
                request.ForceDuplicate = true;
            else
                request.ForceDuplicate = false;

            txtLog.AppendText(DateTime.Now + ": transport request built\n");
            txtLog.AppendText(DateTime.Now + ": calling CreateTransaction web service method\n");

            return request;
        }
        
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSiteID.Text) || String.IsNullOrEmpty(txtKey.Text) || String.IsNullOrEmpty(txtURL.Text))
            {
                MessageBox.Show("URL, Name, SiteID and Key are all required.");
                return;
            }

            Properties.Settings.Default.MerchantName = txtName.Text;
            Properties.Settings.Default.MerchantSiteID = txtSiteID.Text;
            Properties.Settings.Default.MerchantKey = txtKey.Text;
            Properties.Settings.Default.TransportURL = txtURL.Text;
            Properties.Settings.Default.Format = txtFormat.Text;
            Properties.Settings.Default.Server = comboBoxServer.Text;

            if(cbAllowDuplicates.Checked)
                Properties.Settings.Default.AllowDuplicates = true;
            else
                Properties.Settings.Default.AllowDuplicates = false;

            if (cbShowLog.Checked)
            {
                Properties.Settings.Default.ShowLog = true;
                gbLog.Visible = true;
            }
            else
            {
                Properties.Settings.Default.ShowLog = false;
                gbLog.Visible = false;
            }


            if (cbTransDetails.Checked)
            {
                Properties.Settings.Default.ShowTransDetails = true;
                gbTestDetails.Visible = true;
            }
            else
            {
                Properties.Settings.Default.ShowTransDetails = false;
                gbTestDetails.Visible = false;
            }

            if (cbSKU.Checked)
            {
                Properties.Settings.Default.SendSKU = true;
                btnRemoveBurger.Enabled = true;
                btnRemoveHotDog.Enabled = true;
                btnRemoveFries.Enabled = true;
                btnRemoveDrink.Enabled = true;
                btnOrderStatus.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.SendSKU = false;
                btnRemoveBurger.Enabled = false;
                btnRemoveHotDog.Enabled = false;
                btnRemoveFries.Enabled = false;
                btnRemoveDrink.Enabled = false;
                btnOrderStatus.Enabled = false;
            }

            Properties.Settings.Default.Save();

            MessageBox.Show("Saved.");
            
            tabControl1.SelectedTab = tabSale;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Thread threadProcess = new Thread(Process);
            threadProcess.Start();
        }

        private void Process()
        {
            string uri = txtURL.Text;
            string getVars = lblTPToken.Text;
            string format = txtFormat.Text;

            txtLog.Invoke(new MethodInvoker(delegate {
                txtLog.AppendText("-------------------------------------------------------------------------------------------------------------------------\n");
                txtLog.AppendText(DateTime.Now + ": Starting HttpWebRequest init\n");
                txtLog.AppendText(DateTime.Now + ": Target URL » " + string.Format(uri + "{0}{1}\n", "TransportKey=" + getVars, format));
            }));
             
            //Initialization
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(uri + "{0}{1}\n", "TransportKey=" + getVars, format));

            txtLog.Invoke(new MethodInvoker(delegate
            {
                txtLog.AppendText(DateTime.Now + "WebReq: " + WebReq + "\n");
                txtLog.AppendText(DateTime.Now + "TransportKey: " + getVars + "\n");
            }));

            //This time, our method is GET.
            WebReq.Method = "GET";
            //From here on, it's all the same as above.

            txtLog.Invoke(new MethodInvoker(delegate
            {
                txtLog.AppendText(DateTime.Now + ": Starting WebReq.GetResponse call\n");
            }));

            try
            {
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            //Let's show some information about the response
            txtLog.Invoke(new MethodInvoker(delegate
            {
                txtLog.AppendText(DateTime.Now + ": Request Uri: " + WebReq.RequestUri + "\n");
                txtLog.AppendText(DateTime.Now + ": Status code: " + WebResp.StatusCode + "\n");
                txtLog.AppendText(DateTime.Now + ": Server: " + WebResp.Server + "\n");
            }));

                //Now, we read the response (the string), and output it.
                Stream Answer = WebResp.GetResponseStream();
                // StreamReader _Answer = new StreamReader(Answer);
                //Console.WriteLine(_Answer.ReadToEnd());

                txtLog.Invoke(new MethodInvoker(delegate
                {
                    txtLog.AppendText(DateTime.Now + ": Reading response...\n");
                }));

                List<string> list = new List<string>();
                using (StreamReader reader = new StreamReader(Answer))
                {
                    string line;
                    string XML = "";

                    while ((line = reader.ReadLine()) != null)
                    {
                        XML += line;
                        list.Add(line); // Add to list.
                        Console.WriteLine(line); // Write to console.
                        txtLog.Invoke(new MethodInvoker(delegate
                        {
                            txtLog.AppendText(line + "\n");
                        }));
                    }

                    ShowResult(XML);

                    txtLog.Invoke(new MethodInvoker(delegate
                    {
                        txtLog.AppendText(DateTime.Now + ": Finished reading response\n");
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect: " + ex.Message);
            }
            txtLog.Invoke(new MethodInvoker(delegate
            {
                txtLog.AppendText(DateTime.Now + ": Function finished\n");
                txtLog.AppendText("-------------------------------------------------------------------------------------------------------------------------\n");
            }));
        }

        private void ShowResult(string rawXML)
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(rawXML)))
            {
                reader.ReadToFollowing("Status");
                MessageBox.Show(reader.ReadElementContentAsString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reader.ReadToFollowing("AmountApproved");
                //amount = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("AuthorizationCode");
                //authCode = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("Cardholder");
                //cardholder = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("AccountNumber");
                //accountNum = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("PaymentType");
                //paymentType = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("EntryMode");
                //entryMode = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("ErrorMessage");
                //errorMsg = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("Token");
                //token = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("TransactionDate");
                //transDate = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("TransactionType");
                //transType = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("ResponseType");
                //responseType = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("ValidationKey");
                //valKey = reader.ReadElementContentAsString();

                //reader.ReadToFollowing("SignatureData");
                //sigData = reader.ReadElementContentAsString();
            }
        }

#region ADD SKU ITEMS
        private void btnBurger_Click(object sender, EventArgs e)
        {
            _AddItem(5.49m + 0.38m);

            if (cbSKU.Checked)
                _AddItemSKU("AddItem", "SKU", "SKU3453456", "UPC345346334", "Burger", "5.49", "0.38", "None");
        }

        private void btnHotDog_Click(object sender, EventArgs e)
        {
            _AddItem(3.25m + 0.23m); 
            
            if (cbSKU.Checked)
                _AddItemSKU("AddItem", "SKU", "SKU636362", "UPC343245", "Hot Dog", "3.25", "0.23", "None");
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            _AddItem(2.75m + 0.19m);

            if (cbSKU.Checked)
                _AddItemSKU("AddItem", "SKU", "SKU88858", "UPC858585", "Fries", "2.75", "0.19", "EBT");
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            _AddItem(1.95m + 0.13m);

            if(cbSKU.Checked)
                _AddItemSKU("AddItem", "SKU", "SKU23434", "UPC2324243", "Drink", "1.95", "0.13", "None");
        }
#endregion ADD SKU ITEMS

#region REMOVE SKU ITEMS
        private void btnRemoveBurger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RemoveItem(5.49m + 0.38m);
            _AddItemSKU("RemoveItem", "SKU", "SKU3453456", "UPC345346334", "Remove - Burger", "5.49", "0.38", "None");
        }

        private void btnRemoveHotDog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RemoveItem(3.25m + 0.23m);
            _AddItemSKU("RemoveItem", "SKU", "SKU636362", "UPC343245", "Remove - Hot Dog", "3.25", "0.23", "None");
        }

        private void btnRemoveFries_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RemoveItem(2.75m + 0.19m);
            _AddItemSKU("RemoveItem", "SKU", "SKU88858", "UPC858585", "Remove - Fries", "2.75", "0.19", "EBT");
        }

        private void btnRemoveDrink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RemoveItem(1.95m + 0.13m);
            _AddItemSKU("RemoveItem", "SKU", "SKU23434", "UPC2324243", "Remove - Drink", "1.95", "0.13", "None");
        }
#endregion REMOVE SKU ITEMS

#region ADD/REMOVE SKU FUNCTIONS
       
        private void _AddItem(decimal addAmount)
        {
            string tempAmount = lblAmount.Text;
            decimal currentAmount = Decimal.Parse(tempAmount);

            currentAmount = currentAmount + (addAmount * int.Parse(txtQuantity.Text));
            lblAmount.Text = currentAmount.ToString();

            lblTPToken.Text = "« »";
        }

        private void _RemoveItem(decimal SubtractAmount)
        {
            string tempAmount = lblAmount.Text;
            decimal currentAmount = Decimal.Parse(tempAmount);

            currentAmount = currentAmount - (SubtractAmount * int.Parse(txtQuantity.Text));
            lblAmount.Text = currentAmount.ToString();

            lblTPToken.Text = "« »";
        }

        private void _AddItemSKU(string AddType,string Type, string Value, string UPC, string Description, string Amount, string addTaxAmount, string Category)
        {
            string OrderItem = "";
            OrderItem += "&Order=" + txtOrderNumber.Text;
            OrderItem += "&ItemID=" + "";
            OrderItem += "&Type=" + Type;
            OrderItem += "&Value=" + Value;
            OrderItem += "&UPC=" + UPC;
            OrderItem += "&Quantity=" + txtQuantity.Text;
            OrderItem += "&Description=" + Description;
            OrderItem += "&Amount=" + Amount;

            if (AddType == "AddItem")
            {
                OrderItem += "&AddTaxAmount=" + addTaxAmount;
            }
            else if (AddType == "RemoveDiscount" || AddType == "RemoveCoupon")
            {
                OrderItem += "&AddTaxAmount=" + addTaxAmount;
                //OrderItem += "&TargetSKU=" + txtTargetSKU.Text;
            }
            else
            {
                OrderItem += "&SubtractTaxAmount=" + addTaxAmount;
                //OrderItem += "&TargetSKU=" + txtTargetSKU.Text;
            }
            
            OrderItem += "&TotalAmount=" + lblAmount.Text;
            OrderItem += "&TotalTax=" + "0.01";
            OrderItem += "&Category=" + Category;
            OrderItem += "&DisplayOverride=" + ""; // Line 1
            //OrderItem += "&DisplayOverride=" + "4 Burger [8.00]"; // Line 1
            //OrderItem += "r(Buy 1 Get 1 discount) [-4.00]"; // Line 2
            //OrderItem += "r(Buy 1 Get 1 discount [-4.00])"; // Line 3
            OrderItem += "&DisplayCustomSubTotal=" + "";

            string uri = txtURL.Text;
            string format = txtFormat.Text;

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(uri + "{0}{1}{2}", "Action=" + AddType, OrderItem, format));
            WebReq.Method = "GET";

            txtLog.AppendText("-------------------------------------------------------------------------------------------------------------------------\n");
            txtLog.AppendText(DateTime.Now + ": Starting AddItem call\n");
            txtLog.AppendText(DateTime.Now + ": Target URL » " + string.Format(uri + "{0}{1}{2}\n", "Action=" + AddType, OrderItem, format));

            try
            {
                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                //Show some information about the response
                txtLog.AppendText(DateTime.Now + ": Status code: " + WebResp.StatusCode + "\n");
                txtLog.AppendText(DateTime.Now + ": Server: " + WebResp.Server + "\n");

                //Read the response (the string), and output it.
                Stream Answer = WebResp.GetResponseStream();

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
#endregion ADD/REMOVE SKU FUNCTIONS


        private void btnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblAmount.Text = "0.00";
            lblTPToken.Text = "« »";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            string uri = txtURL.Text;
            string format = txtFormat.Text;

            //Initialization
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(uri + "{0}{1}", "Action=Cancel", format));
            WebReq.Method = "GET";

            txtLog.AppendText("-------------------------------------------------------------------------------------------------------------------------\n");
            txtLog.AppendText(DateTime.Now + ": Starting Cancel\n");
            txtLog.AppendText(DateTime.Now + ": Target URL » " + string.Format(uri + "{0}{1}\n", "Action=Cancel", format));
            
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



        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            _CheckStatus("Action=OrderStatus&Order=" + txtOrderNumber.Text);
        }


        private void btnStatus_Click(object sender, EventArgs e)
        {
            _CheckStatus("Action=Status");
        }

        private void _CheckStatus(string StatusType)
        {
            string uri = txtURL.Text;
            string format = txtFormat.Text;
            
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(uri + "{0}{1}", StatusType, format));
            WebReq.Method = "GET";

            txtLog.AppendText("-------------------------------------------------------------------------------------------------------------------------\n");
            txtLog.AppendText(DateTime.Now + ": Starting Status Call\n");
            txtLog.AppendText(DateTime.Now + ": Target URL » " + string.Format(uri + "{0}{1}\n", StatusType, format));
            
            try
            {
                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                //Show some information about the response
                txtLog.AppendText(DateTime.Now + ": Status code: " + WebResp.StatusCode + "\n");
                txtLog.AppendText(DateTime.Now + ": Server: " + WebResp.Server + "\n");

                //Read the response (the string), and output it.
                Stream Answer = WebResp.GetResponseStream();

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

        private void btnStartOrder_Click(object sender, EventArgs e)
        {
            _SKUOrderToggle("Start");
        }

        private void btnEndOrder_Click(object sender, EventArgs e)
        {
            _SKUOrderToggle("End");
        }

        private void _SKUOrderToggle(string Action)
        {
            string uri = txtURL.Text;
            string parameters;

            if (!String.IsNullOrEmpty(txtOrderNumber.Text))
                parameters = "&Order=" + txtOrderNumber.Text;
            else
            {
                MessageBox.Show("Invalid Order Number: " + txtOrderNumber.Text + "\nRequired field.");
                return;
            }
            string format = txtFormat.Text;
            string function = "Action=";

            if (Action == "Start")
                function = "Action=StartOrder";
            else if (Action == "End")
                function = "Action=EndOrder";
            else
            {
                MessageBox.Show("Invalid Action: " + Action);
                return;
            }

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(uri + "{0}{1}{2}", function, parameters, format));
            WebReq.Method = "GET";

            txtLog.AppendText("-------------------------------------------------------------------------------------------------------------------------\n");
            txtLog.AppendText(DateTime.Now + ": Starting " + function + " Call\n");
            txtLog.AppendText(DateTime.Now + ": Target URL » " + string.Format(uri + "{0}{1}{2}\n", function, parameters, format));

            try
            {
                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                //Show some information about the response
                txtLog.AppendText(DateTime.Now + ": Status code: " + WebResp.StatusCode + "\n");
                txtLog.AppendText(DateTime.Now + ": Server: " + WebResp.Server + "\n");

                //Read the response (the string), and output it.
                Stream Answer = WebResp.GetResponseStream();

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

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = (int.Parse(txtQuantity.Text) + 1).ToString();
        }

        private void btnSubtractQuantity_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtQuantity.Text) > 1)
                txtQuantity.Text = (int.Parse(txtQuantity.Text) - 1).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblTPToken.Text);
            StripStatusLabel.Text = "» Copied TransportKey: " + lblTPToken.Text;
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PS1: https://transport.merchantware.net/v4/transportService.asmx" + "\n" + "PC: https://paycube.merchantware.net/transportweb4/transportService.asmx", "Version Information");
        }

        private void btnSKUTest_Click(object sender, EventArgs e)
        {
            SKUTestForm form = new SKUTestForm();
            form.Show();
        }
    }
}
