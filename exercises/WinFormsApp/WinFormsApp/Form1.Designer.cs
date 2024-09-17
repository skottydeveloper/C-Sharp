namespace WinFormsApp
{
    partial class Form1
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
            this.LunchMenu = new System.Windows.Forms.GroupBox();
            this.pricelist = new System.Windows.Forms.ListBox();
            this.menuItems = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Receipt = new System.Windows.Forms.GroupBox();
            this.receiptText = new System.Windows.Forms.Label();
            //this.LunchMenu.SuspendLayout();
            //this.Receipt.SuspendLayout();
            //this.SuspendLayout();
            // 
            // LunchMenu
            // 
            this.LunchMenu.Controls.Add(this.pricelist);
            this.LunchMenu.Controls.Add(this.menuItems);
            this.LunchMenu.Controls.Add(this.label7);
            this.LunchMenu.Controls.Add(this.label8);
            this.LunchMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchMenu.Location = new System.Drawing.Point(21, 80);
            this.LunchMenu.Name = "LunchMenu";
            this.LunchMenu.Size = new System.Drawing.Size(284, 239);
            this.LunchMenu.TabIndex = 11;
            this.LunchMenu.TabStop = false;
            this.LunchMenu.Text = "Menu";
            // 
            // pricelist
            // 
            this.pricelist.Enabled = false;
            this.pricelist.FormattingEnabled = true;
            this.pricelist.ItemHeight = 20;
            this.pricelist.Items.AddRange(new object[] {
            "4.80",
            "3.50",
            "2.50",
            "5.50",
            "3.00",
            "9.00",
            "3.50"});
            this.pricelist.Location = new System.Drawing.Point(208, 72);
            this.pricelist.Name = "pricelist";
            this.pricelist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pricelist.Size = new System.Drawing.Size(60, 144);
            this.pricelist.TabIndex = 11;
            // 
            // menuItems
            // 
            this.menuItems.FormattingEnabled = true;
            this.menuItems.ItemHeight = 20;
            this.menuItems.Items.AddRange(new object[] {
            "Tea/Coffee",
            "Juice",
            "Banana Bread",
            "Cereal",
            "Sushi",
            "Pizza",
            "Drinks"});
            this.menuItems.Location = new System.Drawing.Point(26, 72);
            this.menuItems.Name = "menuItems";
            this.menuItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.menuItems.Size = new System.Drawing.Size(125, 144);
            this.menuItems.TabIndex = 10;
            this.menuItems.SelectedIndexChanged += new System.EventHandler(this.menuItems_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Items";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price $";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(197, 346);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(114, 39);
            this.exit.TabIndex = 16;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(21, 346);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(141, 39);
            this.order.TabIndex = 18;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student Restaurant";
            // 
            // Receipt
            // 
            this.Receipt.Controls.Add(this.receiptText);
            this.Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receipt.Location = new System.Drawing.Point(374, 80);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(265, 305);
            this.Receipt.TabIndex = 20;
            this.Receipt.TabStop = false;
            this.Receipt.Text = "Receipt";
            // 
            // receiptText
            // 
            this.receiptText.AutoSize = true;
            this.receiptText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptText.Location = new System.Drawing.Point(21, 48);
            this.receiptText.Name = "receiptText";
            this.receiptText.Size = new System.Drawing.Size(0, 16);
            this.receiptText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 401);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.LunchMenu);
            this.Name = "Form1";
            this.Text = "Student Restaurant Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LunchMenu.ResumeLayout(false);
            this.LunchMenu.PerformLayout();
            this.Receipt.ResumeLayout(false);
            this.Receipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LunchMenu;
        private System.Windows.Forms.ListBox pricelist;
        private System.Windows.Forms.ListBox menuItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Receipt;
        private System.Windows.Forms.Label receiptText;
    }
}

