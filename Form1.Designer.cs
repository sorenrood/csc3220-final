
namespace Project4 {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBoxSelection = new System.Windows.Forms.GroupBox();
            this.buttonClearOrders = new System.Windows.Forms.Button();
            this.labelListBox = new System.Windows.Forms.Label();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxCherry = new System.Windows.Forms.CheckBox();
            this.checkBoxChoppedNuts = new System.Windows.Forms.CheckBox();
            this.checkBoxSprinkles = new System.Windows.Forms.CheckBox();
            this.groupBoxFlavor = new System.Windows.Forms.GroupBox();
            this.radioButtonStrawberry = new System.Windows.Forms.RadioButton();
            this.radioButtonVanilla = new System.Windows.Forms.RadioButton();
            this.radioButtonChocolate = new System.Windows.Forms.RadioButton();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonTotalPrice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxCustomerOrders = new System.Windows.Forms.GroupBox();
            this.labelTotalTransactions = new System.Windows.Forms.Label();
            this.buttonTotalUp = new System.Windows.Forms.Button();
            this.listBoxAllOrders = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.priceFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSelection.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.groupBoxFlavor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxCustomerOrders.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelection
            // 
            this.groupBoxSelection.AccessibleName = "groupBoxSelection";
            this.groupBoxSelection.Controls.Add(this.buttonClearOrders);
            this.groupBoxSelection.Controls.Add(this.labelListBox);
            this.groupBoxSelection.Controls.Add(this.listBoxOrders);
            this.groupBoxSelection.Controls.Add(this.buttonAddOrder);
            this.groupBoxSelection.Controls.Add(this.groupBoxToppings);
            this.groupBoxSelection.Controls.Add(this.groupBoxFlavor);
            this.groupBoxSelection.Location = new System.Drawing.Point(43, 32);
            this.groupBoxSelection.Name = "groupBoxSelection";
            this.groupBoxSelection.Size = new System.Drawing.Size(591, 248);
            this.groupBoxSelection.TabIndex = 0;
            this.groupBoxSelection.TabStop = false;
            this.groupBoxSelection.Text = "Select Ice Cream Cone";
            // 
            // buttonClearOrders
            // 
            this.buttonClearOrders.Location = new System.Drawing.Point(411, 182);
            this.buttonClearOrders.Name = "buttonClearOrders";
            this.buttonClearOrders.Size = new System.Drawing.Size(154, 48);
            this.buttonClearOrders.TabIndex = 5;
            this.buttonClearOrders.Text = "Clear Ice Cream Cone Orders";
            this.buttonClearOrders.UseVisualStyleBackColor = true;
            this.buttonClearOrders.Click += new System.EventHandler(this.buttonClearOrders_Click);
            // 
            // labelListBox
            // 
            this.labelListBox.Location = new System.Drawing.Point(411, 9);
            this.labelListBox.Name = "labelListBox";
            this.labelListBox.Size = new System.Drawing.Size(154, 16);
            this.labelListBox.TabIndex = 4;
            this.labelListBox.Text = "Ice Cream Cone Orders";
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.Location = new System.Drawing.Point(411, 28);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(154, 147);
            this.listBoxOrders.TabIndex = 3;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(25, 181);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(370, 49);
            this.buttonAddOrder.TabIndex = 2;
            this.buttonAddOrder.Text = "Add Ice Cream Cone Order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxCherry);
            this.groupBoxToppings.Controls.Add(this.checkBoxChoppedNuts);
            this.groupBoxToppings.Controls.Add(this.checkBoxSprinkles);
            this.groupBoxToppings.Location = new System.Drawing.Point(212, 19);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(183, 156);
            this.groupBoxToppings.TabIndex = 1;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxCherry
            // 
            this.checkBoxCherry.AutoSize = true;
            this.checkBoxCherry.Location = new System.Drawing.Point(27, 99);
            this.checkBoxCherry.Name = "checkBoxCherry";
            this.checkBoxCherry.Size = new System.Drawing.Size(56, 17);
            this.checkBoxCherry.TabIndex = 2;
            this.checkBoxCherry.Text = "Cherry";
            this.checkBoxCherry.UseVisualStyleBackColor = true;
            // 
            // checkBoxChoppedNuts
            // 
            this.checkBoxChoppedNuts.AutoSize = true;
            this.checkBoxChoppedNuts.Location = new System.Drawing.Point(27, 66);
            this.checkBoxChoppedNuts.Name = "checkBoxChoppedNuts";
            this.checkBoxChoppedNuts.Size = new System.Drawing.Size(94, 17);
            this.checkBoxChoppedNuts.TabIndex = 1;
            this.checkBoxChoppedNuts.Text = "Chopped Nuts";
            this.checkBoxChoppedNuts.UseVisualStyleBackColor = true;
            // 
            // checkBoxSprinkles
            // 
            this.checkBoxSprinkles.AutoSize = true;
            this.checkBoxSprinkles.Location = new System.Drawing.Point(27, 33);
            this.checkBoxSprinkles.Name = "checkBoxSprinkles";
            this.checkBoxSprinkles.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSprinkles.TabIndex = 0;
            this.checkBoxSprinkles.Text = "Sprinkles";
            this.checkBoxSprinkles.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlavor
            // 
            this.groupBoxFlavor.AccessibleName = "groupBoxFlavor";
            this.groupBoxFlavor.Controls.Add(this.radioButtonStrawberry);
            this.groupBoxFlavor.Controls.Add(this.radioButtonVanilla);
            this.groupBoxFlavor.Controls.Add(this.radioButtonChocolate);
            this.groupBoxFlavor.Location = new System.Drawing.Point(25, 19);
            this.groupBoxFlavor.Name = "groupBoxFlavor";
            this.groupBoxFlavor.Size = new System.Drawing.Size(172, 156);
            this.groupBoxFlavor.TabIndex = 0;
            this.groupBoxFlavor.TabStop = false;
            this.groupBoxFlavor.Text = "Flavor";
            // 
            // radioButtonStrawberry
            // 
            this.radioButtonStrawberry.AutoSize = true;
            this.radioButtonStrawberry.Location = new System.Drawing.Point(17, 99);
            this.radioButtonStrawberry.Name = "radioButtonStrawberry";
            this.radioButtonStrawberry.Size = new System.Drawing.Size(75, 17);
            this.radioButtonStrawberry.TabIndex = 2;
            this.radioButtonStrawberry.TabStop = true;
            this.radioButtonStrawberry.Text = "Strawberry";
            this.radioButtonStrawberry.UseVisualStyleBackColor = true;
            // 
            // radioButtonVanilla
            // 
            this.radioButtonVanilla.AutoSize = true;
            this.radioButtonVanilla.Location = new System.Drawing.Point(17, 66);
            this.radioButtonVanilla.Name = "radioButtonVanilla";
            this.radioButtonVanilla.Size = new System.Drawing.Size(56, 17);
            this.radioButtonVanilla.TabIndex = 1;
            this.radioButtonVanilla.TabStop = true;
            this.radioButtonVanilla.Text = "Vanilla";
            this.radioButtonVanilla.UseVisualStyleBackColor = true;
            // 
            // radioButtonChocolate
            // 
            this.radioButtonChocolate.AutoSize = true;
            this.radioButtonChocolate.Location = new System.Drawing.Point(17, 33);
            this.radioButtonChocolate.Name = "radioButtonChocolate";
            this.radioButtonChocolate.Size = new System.Drawing.Size(73, 17);
            this.radioButtonChocolate.TabIndex = 0;
            this.radioButtonChocolate.TabStop = true;
            this.radioButtonChocolate.Text = "Chocolate";
            this.radioButtonChocolate.UseVisualStyleBackColor = true;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalPrice.Location = new System.Drawing.Point(349, 30);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(216, 23);
            this.labelTotalPrice.TabIndex = 3;
            // 
            // buttonTotalPrice
            // 
            this.buttonTotalPrice.Location = new System.Drawing.Point(16, 30);
            this.buttonTotalPrice.Name = "buttonTotalPrice";
            this.buttonTotalPrice.Size = new System.Drawing.Size(279, 23);
            this.buttonTotalPrice.TabIndex = 2;
            this.buttonTotalPrice.Text = "Total Price";
            this.buttonTotalPrice.UseVisualStyleBackColor = true;
            this.buttonTotalPrice.Click += new System.EventHandler(this.buttonTotalPrice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTotalPrice);
            this.groupBox1.Controls.Add(this.labelTotalPrice);
            this.groupBox1.Location = new System.Drawing.Point(43, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBoxCustomerOrders
            // 
            this.groupBoxCustomerOrders.Controls.Add(this.labelTotalTransactions);
            this.groupBoxCustomerOrders.Controls.Add(this.buttonTotalUp);
            this.groupBoxCustomerOrders.Controls.Add(this.listBoxAllOrders);
            this.groupBoxCustomerOrders.Location = new System.Drawing.Point(640, 32);
            this.groupBoxCustomerOrders.Name = "groupBoxCustomerOrders";
            this.groupBoxCustomerOrders.Size = new System.Drawing.Size(189, 330);
            this.groupBoxCustomerOrders.TabIndex = 5;
            this.groupBoxCustomerOrders.TabStop = false;
            this.groupBoxCustomerOrders.Text = "All Customer Orders";
            // 
            // labelTotalTransactions
            // 
            this.labelTotalTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalTransactions.Location = new System.Drawing.Point(7, 284);
            this.labelTotalTransactions.Name = "labelTotalTransactions";
            this.labelTotalTransactions.Size = new System.Drawing.Size(176, 23);
            this.labelTotalTransactions.TabIndex = 2;
            // 
            // buttonTotalUp
            // 
            this.buttonTotalUp.Location = new System.Drawing.Point(7, 222);
            this.buttonTotalUp.Name = "buttonTotalUp";
            this.buttonTotalUp.Size = new System.Drawing.Size(176, 42);
            this.buttonTotalUp.TabIndex = 1;
            this.buttonTotalUp.Text = "Total Up All Transactions";
            this.buttonTotalUp.UseVisualStyleBackColor = true;
            this.buttonTotalUp.Click += new System.EventHandler(this.buttonTotalUp_Click);
            // 
            // listBoxAllOrders
            // 
            this.listBoxAllOrders.FormattingEnabled = true;
            this.listBoxAllOrders.Location = new System.Drawing.Point(7, 28);
            this.listBoxAllOrders.Name = "listBoxAllOrders";
            this.listBoxAllOrders.Size = new System.Drawing.Size(176, 173);
            this.listBoxAllOrders.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formMenu
            // 
            this.formMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceFormToolStripMenuItem});
            this.formMenu.Name = "formMenu";
            this.formMenu.Size = new System.Drawing.Size(52, 20);
            this.formMenu.Text = "Forms";
            // 
            // priceFormToolStripMenuItem
            // 
            this.priceFormToolStripMenuItem.Name = "priceFormToolStripMenuItem";
            this.priceFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.priceFormToolStripMenuItem.Text = "Price Form";
            this.priceFormToolStripMenuItem.Click += new System.EventHandler(this.priceFormToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 374);
            this.Controls.Add(this.groupBoxCustomerOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSelection);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.groupBoxSelection.ResumeLayout(false);
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.groupBoxFlavor.ResumeLayout(false);
            this.groupBoxFlavor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxCustomerOrders.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelection;
        private System.Windows.Forms.GroupBox groupBoxFlavor;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonTotalPrice;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxCherry;
        private System.Windows.Forms.CheckBox checkBoxChoppedNuts;
        private System.Windows.Forms.CheckBox checkBoxSprinkles;
        private System.Windows.Forms.RadioButton radioButtonStrawberry;
        private System.Windows.Forms.RadioButton radioButtonVanilla;
        private System.Windows.Forms.RadioButton radioButtonChocolate;
        private System.Windows.Forms.Button buttonClearOrders;
        private System.Windows.Forms.Label labelListBox;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxCustomerOrders;
        private System.Windows.Forms.Label labelTotalTransactions;
        private System.Windows.Forms.Button buttonTotalUp;
        private System.Windows.Forms.ListBox listBoxAllOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formMenu;
        private System.Windows.Forms.ToolStripMenuItem priceFormToolStripMenuItem;
    }
}

