
namespace Project4
{
    partial class formPriceSheet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.formBoxVanilla = new System.Windows.Forms.TextBox();
            this.formBoxChocolate = new System.Windows.Forms.TextBox();
            this.formBoxStrawberry = new System.Windows.Forms.TextBox();
            this.formBoxChoppedNuts = new System.Windows.Forms.TextBox();
            this.formBoxCherry = new System.Windows.Forms.TextBox();
            this.formBoxSprinkles = new System.Windows.Forms.TextBox();
            this.buttonSetPrices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vanilla Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strawberry Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cherry Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chocolate Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sprinkles Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chopped Nuts Price";
            // 
            // formBoxVanilla
            // 
            this.formBoxVanilla.Location = new System.Drawing.Point(185, 127);
            this.formBoxVanilla.Name = "formBoxVanilla";
            this.formBoxVanilla.Size = new System.Drawing.Size(100, 20);
            this.formBoxVanilla.TabIndex = 6;
            // 
            // formBoxChocolate
            // 
            this.formBoxChocolate.Location = new System.Drawing.Point(185, 178);
            this.formBoxChocolate.Name = "formBoxChocolate";
            this.formBoxChocolate.Size = new System.Drawing.Size(100, 20);
            this.formBoxChocolate.TabIndex = 7;
            // 
            // formBoxStrawberry
            // 
            this.formBoxStrawberry.Location = new System.Drawing.Point(185, 229);
            this.formBoxStrawberry.Name = "formBoxStrawberry";
            this.formBoxStrawberry.Size = new System.Drawing.Size(100, 20);
            this.formBoxStrawberry.TabIndex = 8;
            // 
            // formBoxChoppedNuts
            // 
            this.formBoxChoppedNuts.Location = new System.Drawing.Point(424, 178);
            this.formBoxChoppedNuts.Name = "formBoxChoppedNuts";
            this.formBoxChoppedNuts.Size = new System.Drawing.Size(100, 20);
            this.formBoxChoppedNuts.TabIndex = 9;
            // 
            // formBoxCherry
            // 
            this.formBoxCherry.Location = new System.Drawing.Point(424, 229);
            this.formBoxCherry.Name = "formBoxCherry";
            this.formBoxCherry.Size = new System.Drawing.Size(100, 20);
            this.formBoxCherry.TabIndex = 10;
            // 
            // formBoxSprinkles
            // 
            this.formBoxSprinkles.Location = new System.Drawing.Point(424, 127);
            this.formBoxSprinkles.Name = "formBoxSprinkles";
            this.formBoxSprinkles.Size = new System.Drawing.Size(100, 20);
            this.formBoxSprinkles.TabIndex = 11;
            // 
            // buttonSetPrices
            // 
            this.buttonSetPrices.Location = new System.Drawing.Point(316, 277);
            this.buttonSetPrices.Name = "buttonSetPrices";
            this.buttonSetPrices.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPrices.TabIndex = 12;
            this.buttonSetPrices.Text = "Set Prices!";
            this.buttonSetPrices.UseVisualStyleBackColor = true;
            this.buttonSetPrices.Click += new System.EventHandler(this.buttonSetPrices_Click);
            // 
            // formPriceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSetPrices);
            this.Controls.Add(this.formBoxSprinkles);
            this.Controls.Add(this.formBoxCherry);
            this.Controls.Add(this.formBoxChoppedNuts);
            this.Controls.Add(this.formBoxStrawberry);
            this.Controls.Add(this.formBoxChocolate);
            this.Controls.Add(this.formBoxVanilla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formPriceSheet";
            this.Text = "Price Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox formBoxVanilla;
        private System.Windows.Forms.TextBox formBoxChocolate;
        private System.Windows.Forms.TextBox formBoxStrawberry;
        private System.Windows.Forms.TextBox formBoxChoppedNuts;
        private System.Windows.Forms.TextBox formBoxCherry;
        private System.Windows.Forms.TextBox formBoxSprinkles;
        private System.Windows.Forms.Button buttonSetPrices;
    }
}