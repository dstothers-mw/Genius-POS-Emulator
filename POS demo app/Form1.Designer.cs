namespace POS_demo_app
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSale = new System.Windows.Forms.TabPage();
            this.gbTestDetails = new System.Windows.Forms.GroupBox();
            this.picCopy = new System.Windows.Forms.PictureBox();
            this.btnStage = new System.Windows.Forms.Button();
            this.cbTransType = new System.Windows.Forms.ComboBox();
            this.lblTPToken = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubtractQuantity = new System.Windows.Forms.Button();
            this.btnAddQuantity = new System.Windows.Forms.Button();
            this.btnRemoveDrink = new System.Windows.Forms.LinkLabel();
            this.btnRemoveFries = new System.Windows.Forms.LinkLabel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.btnRemoveHotDog = new System.Windows.Forms.LinkLabel();
            this.btnRemoveBurger = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.buttonSale = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.btnEndOrder = new System.Windows.Forms.Button();
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnFries = new System.Windows.Forms.Button();
            this.btnHotDog = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.cbTransDetails = new System.Windows.Forms.CheckBox();
            this.cbShowLog = new System.Windows.Forms.CheckBox();
            this.btnOrderStatus = new System.Windows.Forms.Button();
            this.cbSKU = new System.Windows.Forms.CheckBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSiteID = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.cbAllowDuplicates = new System.Windows.Forms.CheckBox();
            this.lblAmount = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.LinkLabel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnSKUTest = new System.Windows.Forms.Button();
            this.tabSKU = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabSale.SuspendLayout();
            this.gbTestDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabSKU.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSale);
            this.tabControl1.Controls.Add(this.tabSKU);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(6, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 334);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSale
            // 
            this.tabSale.Controls.Add(this.gbTestDetails);
            this.tabSale.Controls.Add(this.groupBox1);
            this.tabSale.Location = new System.Drawing.Point(4, 22);
            this.tabSale.Name = "tabSale";
            this.tabSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabSale.Size = new System.Drawing.Size(712, 308);
            this.tabSale.TabIndex = 0;
            this.tabSale.Text = "Sale";
            this.tabSale.UseVisualStyleBackColor = true;
            // 
            // gbTestDetails
            // 
            this.gbTestDetails.Controls.Add(this.picCopy);
            this.gbTestDetails.Controls.Add(this.btnStage);
            this.gbTestDetails.Controls.Add(this.cbTransType);
            this.gbTestDetails.Controls.Add(this.lblTPToken);
            this.gbTestDetails.Controls.Add(this.btnProcess);
            this.gbTestDetails.Location = new System.Drawing.Point(9, 249);
            this.gbTestDetails.Name = "gbTestDetails";
            this.gbTestDetails.Size = new System.Drawing.Size(690, 51);
            this.gbTestDetails.TabIndex = 6;
            this.gbTestDetails.TabStop = false;
            this.gbTestDetails.Text = "Test functions";
            // 
            // picCopy
            // 
            this.picCopy.Image = ((System.Drawing.Image)(resources.GetObject("picCopy.Image")));
            this.picCopy.Location = new System.Drawing.Point(565, 19);
            this.picCopy.Name = "picCopy";
            this.picCopy.Size = new System.Drawing.Size(18, 19);
            this.picCopy.TabIndex = 17;
            this.picCopy.TabStop = false;
            this.picCopy.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnStage
            // 
            this.btnStage.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnStage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStage.Location = new System.Drawing.Point(132, 14);
            this.btnStage.Name = "btnStage";
            this.btnStage.Size = new System.Drawing.Size(88, 26);
            this.btnStage.TabIndex = 8;
            this.btnStage.Text = "Stage";
            this.btnStage.UseVisualStyleBackColor = true;
            this.btnStage.Click += new System.EventHandler(this.btnStage_Click);
            // 
            // cbTransType
            // 
            this.cbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTransType.FormattingEnabled = true;
            this.cbTransType.Items.AddRange(new object[] {
            "SALE",
            "LEVEL2SALE",
            "PREAUTH",
            "_REFUND"});
            this.cbTransType.Location = new System.Drawing.Point(9, 18);
            this.cbTransType.Name = "cbTransType";
            this.cbTransType.Size = new System.Drawing.Size(117, 21);
            this.cbTransType.TabIndex = 6;
            // 
            // lblTPToken
            // 
            this.lblTPToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTPToken.Location = new System.Drawing.Point(224, 17);
            this.lblTPToken.Name = "lblTPToken";
            this.lblTPToken.Size = new System.Drawing.Size(335, 21);
            this.lblTPToken.TabIndex = 4;
            this.lblTPToken.Text = "« »";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnProcess.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(591, 15);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(88, 26);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Initiate";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubtractQuantity);
            this.groupBox1.Controls.Add(this.btnAddQuantity);
            this.groupBox1.Controls.Add(this.btnRemoveDrink);
            this.groupBox1.Controls.Add(this.btnRemoveFries);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.btnRemoveHotDog);
            this.groupBox1.Controls.Add(this.btnRemoveBurger);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.buttonSale);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtOrderNumber);
            this.groupBox1.Controls.Add(this.btnEndOrder);
            this.groupBox1.Controls.Add(this.btnStartOrder);
            this.groupBox1.Controls.Add(this.btnDrink);
            this.groupBox1.Controls.Add(this.btnFries);
            this.groupBox1.Controls.Add(this.btnHotDog);
            this.groupBox1.Controls.Add(this.btnBurger);
            this.groupBox1.Location = new System.Drawing.Point(9, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 228);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test payment";
            // 
            // btnSubtractQuantity
            // 
            this.btnSubtractQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractQuantity.Location = new System.Drawing.Point(205, 36);
            this.btnSubtractQuantity.Name = "btnSubtractQuantity";
            this.btnSubtractQuantity.Size = new System.Drawing.Size(23, 27);
            this.btnSubtractQuantity.TabIndex = 16;
            this.btnSubtractQuantity.Text = "-";
            this.btnSubtractQuantity.UseVisualStyleBackColor = true;
            this.btnSubtractQuantity.Click += new System.EventHandler(this.btnSubtractQuantity_Click);
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuantity.Location = new System.Drawing.Point(205, 10);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(23, 27);
            this.btnAddQuantity.TabIndex = 15;
            this.btnAddQuantity.Text = "+";
            this.btnAddQuantity.UseVisualStyleBackColor = true;
            this.btnAddQuantity.Click += new System.EventHandler(this.btnAddQuantity_Click);
            // 
            // btnRemoveDrink
            // 
            this.btnRemoveDrink.AutoSize = true;
            this.btnRemoveDrink.Location = new System.Drawing.Point(387, 193);
            this.btnRemoveDrink.Name = "btnRemoveDrink";
            this.btnRemoveDrink.Size = new System.Drawing.Size(42, 13);
            this.btnRemoveDrink.TabIndex = 14;
            this.btnRemoveDrink.TabStop = true;
            this.btnRemoveDrink.Text = "remove";
            this.btnRemoveDrink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRemoveDrink_LinkClicked);
            // 
            // btnRemoveFries
            // 
            this.btnRemoveFries.AutoSize = true;
            this.btnRemoveFries.Location = new System.Drawing.Point(267, 193);
            this.btnRemoveFries.Name = "btnRemoveFries";
            this.btnRemoveFries.Size = new System.Drawing.Size(42, 13);
            this.btnRemoveFries.TabIndex = 13;
            this.btnRemoveFries.TabStop = true;
            this.btnRemoveFries.Text = "remove";
            this.btnRemoveFries.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRemoveFries_LinkClicked);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(628, 193);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(49, 26);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnRemoveHotDog
            // 
            this.btnRemoveHotDog.AutoSize = true;
            this.btnRemoveHotDog.Location = new System.Drawing.Point(159, 193);
            this.btnRemoveHotDog.Name = "btnRemoveHotDog";
            this.btnRemoveHotDog.Size = new System.Drawing.Size(42, 13);
            this.btnRemoveHotDog.TabIndex = 12;
            this.btnRemoveHotDog.TabStop = true;
            this.btnRemoveHotDog.Text = "remove";
            this.btnRemoveHotDog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRemoveHotDog_LinkClicked);
            // 
            // btnRemoveBurger
            // 
            this.btnRemoveBurger.AutoSize = true;
            this.btnRemoveBurger.Location = new System.Drawing.Point(45, 193);
            this.btnRemoveBurger.Name = "btnRemoveBurger";
            this.btnRemoveBurger.Size = new System.Drawing.Size(42, 13);
            this.btnRemoveBurger.TabIndex = 11;
            this.btnRemoveBurger.TabStop = true;
            this.btnRemoveBurger.Text = "remove";
            this.btnRemoveBurger.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRemoveBurger_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Qnty:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(158, 25);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(43, 26);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.Text = "1";
            // 
            // buttonSale
            // 
            this.buttonSale.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.buttonSale.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSale.Image = global::POS_demo_app.Properties.Resources.tag;
            this.buttonSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSale.Location = new System.Drawing.Point(516, 100);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(161, 73);
            this.buttonSale.TabIndex = 6;
            this.buttonSale.Text = "Sale";
            this.buttonSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Order:";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(48, 25);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(70, 26);
            this.txtOrderNumber.TabIndex = 6;
            this.txtOrderNumber.Text = "1234";
            // 
            // btnEndOrder
            // 
            this.btnEndOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEndOrder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEndOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnEndOrder.Image")));
            this.btnEndOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndOrder.Location = new System.Drawing.Point(350, 19);
            this.btnEndOrder.Name = "btnEndOrder";
            this.btnEndOrder.Size = new System.Drawing.Size(110, 38);
            this.btnEndOrder.TabIndex = 6;
            this.btnEndOrder.Text = "End Order";
            this.btnEndOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEndOrder.UseVisualStyleBackColor = true;
            this.btnEndOrder.Click += new System.EventHandler(this.btnEndOrder_Click);
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnStartOrder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStartOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnStartOrder.Image")));
            this.btnStartOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartOrder.Location = new System.Drawing.Point(236, 19);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(108, 38);
            this.btnStartOrder.TabIndex = 6;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartOrder.UseVisualStyleBackColor = true;
            this.btnStartOrder.Click += new System.EventHandler(this.btnStartOrder_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDrink.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDrink.Image = global::POS_demo_app.Properties.Resources.soft_drink_72;
            this.btnDrink.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDrink.Location = new System.Drawing.Point(350, 67);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(110, 123);
            this.btnDrink.TabIndex = 6;
            this.btnDrink.Text = "$2.08\r\n(1.95+0.13)";
            this.btnDrink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnFries
            // 
            this.btnFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFries.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFries.Image = global::POS_demo_app.Properties.Resources.french_fries_72;
            this.btnFries.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFries.Location = new System.Drawing.Point(236, 67);
            this.btnFries.Name = "btnFries";
            this.btnFries.Size = new System.Drawing.Size(110, 123);
            this.btnFries.TabIndex = 5;
            this.btnFries.Text = "$2.94 (EBT)\r\n(2.75+0.19)";
            this.btnFries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFries.UseVisualStyleBackColor = true;
            this.btnFries.Click += new System.EventHandler(this.btnFries_Click);
            // 
            // btnHotDog
            // 
            this.btnHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHotDog.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHotDog.Image = global::POS_demo_app.Properties.Resources.hot_dog_72;
            this.btnHotDog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHotDog.Location = new System.Drawing.Point(122, 67);
            this.btnHotDog.Name = "btnHotDog";
            this.btnHotDog.Size = new System.Drawing.Size(110, 123);
            this.btnHotDog.TabIndex = 4;
            this.btnHotDog.Text = "$3.48\r\n(3.25+0.23)";
            this.btnHotDog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHotDog.UseVisualStyleBackColor = true;
            this.btnHotDog.Click += new System.EventHandler(this.btnHotDog_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBurger.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBurger.Image = global::POS_demo_app.Properties.Resources.hamburger_72;
            this.btnBurger.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBurger.Location = new System.Drawing.Point(8, 67);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(110, 123);
            this.btnBurger.TabIndex = 3;
            this.btnBurger.Text = "$5.87\r\n(5.49+0.39)";
            this.btnBurger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBurger.UseVisualStyleBackColor = true;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.cbTransDetails);
            this.tabSettings.Controls.Add(this.cbShowLog);
            this.tabSettings.Controls.Add(this.btnOrderStatus);
            this.tabSettings.Controls.Add(this.cbSKU);
            this.tabSettings.Controls.Add(this.btnStatus);
            this.tabSettings.Controls.Add(this.groupBox3);
            this.tabSettings.Controls.Add(this.groupBox2);
            this.tabSettings.Controls.Add(this.btnSaveSettings);
            this.tabSettings.Controls.Add(this.cbAllowDuplicates);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(712, 308);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // cbTransDetails
            // 
            this.cbTransDetails.AutoSize = true;
            this.cbTransDetails.Location = new System.Drawing.Point(28, 275);
            this.cbTransDetails.Name = "cbTransDetails";
            this.cbTransDetails.Size = new System.Drawing.Size(118, 17);
            this.cbTransDetails.TabIndex = 11;
            this.cbTransDetails.Text = "Show Trans Details";
            this.cbTransDetails.UseVisualStyleBackColor = true;
            // 
            // cbShowLog
            // 
            this.cbShowLog.AutoSize = true;
            this.cbShowLog.Location = new System.Drawing.Point(28, 252);
            this.cbShowLog.Name = "cbShowLog";
            this.cbShowLog.Size = new System.Drawing.Size(74, 17);
            this.cbShowLog.TabIndex = 10;
            this.cbShowLog.Text = "Show Log";
            this.cbShowLog.UseVisualStyleBackColor = true;
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrderStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderStatus.Image")));
            this.btnOrderStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderStatus.Location = new System.Drawing.Point(587, 250);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnOrderStatus.Size = new System.Drawing.Size(102, 32);
            this.btnOrderStatus.TabIndex = 9;
            this.btnOrderStatus.Text = "Order Status";
            this.btnOrderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderStatus.UseVisualStyleBackColor = true;
            this.btnOrderStatus.Click += new System.EventHandler(this.btnOrderStatus_Click);
            // 
            // cbSKU
            // 
            this.cbSKU.AutoSize = true;
            this.cbSKU.Location = new System.Drawing.Point(28, 229);
            this.cbSKU.Name = "cbSKU";
            this.cbSKU.Size = new System.Drawing.Size(76, 17);
            this.cbSKU.TabIndex = 8;
            this.cbSKU.Text = "Send SKU";
            this.cbSKU.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnStatus.Image")));
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(587, 212);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnStatus.Size = new System.Drawing.Size(102, 32);
            this.btnStatus.TabIndex = 7;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSiteID);
            this.groupBox3.Controls.Add(this.txtKey);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(19, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 88);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Merchant settings";
            // 
            // txtSiteID
            // 
            this.txtSiteID.Location = new System.Drawing.Point(413, 25);
            this.txtSiteID.Name = "txtSiteID";
            this.txtSiteID.Size = new System.Drawing.Size(236, 20);
            this.txtSiteID.TabIndex = 3;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(75, 57);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(574, 20);
            this.txtKey.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 20);
            this.txtName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SiteID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxServer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFormat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtURL);
            this.groupBox2.Location = new System.Drawing.Point(19, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminal settings";
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Items.AddRange(new object[] {
            "PS1",
            "PC"});
            this.comboBoxServer.Location = new System.Drawing.Point(555, 35);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(94, 21);
            this.comboBoxServer.TabIndex = 5;
            this.comboBoxServer.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(369, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Example:  &&Format=XML";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Server";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(372, 35);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(119, 20);
            this.txtFormat.TabIndex = 7;
            this.txtFormat.Text = "&Format=XML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Format";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(72, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Example: http://[ip-address]:8080/pos?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(75, 35);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(246, 20);
            this.txtURL.TabIndex = 0;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveSettings.Image = global::POS_demo_app.Properties.Resources.Save;
            this.btnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSettings.Location = new System.Drawing.Point(302, 204);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(99, 42);
            this.btnSaveSettings.TabIndex = 6;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // cbAllowDuplicates
            // 
            this.cbAllowDuplicates.AutoSize = true;
            this.cbAllowDuplicates.Checked = true;
            this.cbAllowDuplicates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllowDuplicates.Location = new System.Drawing.Point(28, 206);
            this.cbAllowDuplicates.Name = "cbAllowDuplicates";
            this.cbAllowDuplicates.Size = new System.Drawing.Size(102, 17);
            this.cbAllowDuplicates.TabIndex = 5;
            this.cbAllowDuplicates.Text = "Allow duplicates";
            this.cbAllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAmount.Location = new System.Drawing.Point(111, 13);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(98, 43);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "0.00";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(638, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 13);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TabStop = true;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCancel_LinkClicked);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(7, 15);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(706, 153);
            this.txtLog.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(26, 17);
            this.statusLabel.Text = "idle";
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(6, 425);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(719, 173);
            this.gbLog.TabIndex = 5;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.MintCream;
            this.groupBox7.Controls.Add(this.lblAmount);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.btnCancel);
            this.groupBox7.Location = new System.Drawing.Point(6, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(713, 67);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.SteelBlue;
            this.label18.Location = new System.Drawing.Point(10, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 37);
            this.label18.TabIndex = 8;
            this.label18.Text = "Total  $";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 603);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(731, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StripStatusLabel
            // 
            this.StripStatusLabel.Name = "StripStatusLabel";
            this.StripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(664, 73);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(43, 13);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "9.24.13";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // btnSKUTest
            // 
            this.btnSKUTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSKUTest.Location = new System.Drawing.Point(31, 24);
            this.btnSKUTest.Name = "btnSKUTest";
            this.btnSKUTest.Size = new System.Drawing.Size(147, 69);
            this.btnSKUTest.TabIndex = 1;
            this.btnSKUTest.Text = "Launch SKU test form";
            this.btnSKUTest.UseVisualStyleBackColor = true;
            this.btnSKUTest.Click += new System.EventHandler(this.btnSKUTest_Click);
            // 
            // tabSKU
            // 
            this.tabSKU.Controls.Add(this.btnSKUTest);
            this.tabSKU.Location = new System.Drawing.Point(4, 22);
            this.tabSKU.Name = "tabSKU";
            this.tabSKU.Size = new System.Drawing.Size(712, 308);
            this.tabSKU.TabIndex = 2;
            this.tabSKU.Text = "SKU";
            this.tabSKU.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 625);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius POS Emulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabSale.ResumeLayout(false);
            this.gbTestDetails.ResumeLayout(false);
            this.gbTestDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCopy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabSKU.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSale;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbTestDetails;
        private System.Windows.Forms.CheckBox cbAllowDuplicates;
        private System.Windows.Forms.TextBox txtSiteID;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnFries;
        private System.Windows.Forms.Button btnHotDog;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.LinkLabel btnCancel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox lblTPToken;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblAmount;
        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbSKU;
        private System.Windows.Forms.Button btnEndOrder;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.LinkLabel btnRemoveDrink;
        private System.Windows.Forms.LinkLabel btnRemoveFries;
        private System.Windows.Forms.LinkLabel btnRemoveHotDog;
        private System.Windows.Forms.LinkLabel btnRemoveBurger;
        private System.Windows.Forms.Button btnOrderStatus;
        private System.Windows.Forms.ComboBox cbTransType;
        private System.Windows.Forms.Button btnStage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSubtractQuantity;
        private System.Windows.Forms.Button btnAddQuantity;
        private System.Windows.Forms.PictureBox picCopy;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabel;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.CheckBox cbShowLog;
        private System.Windows.Forms.CheckBox cbTransDetails;
        private System.Windows.Forms.TabPage tabSKU;
        private System.Windows.Forms.Button btnSKUTest;
    }
}

