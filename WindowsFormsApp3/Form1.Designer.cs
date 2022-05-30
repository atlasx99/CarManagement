namespace WindowsFormsApp3
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
            this.txtcarbrand = new System.Windows.Forms.TextBox();
            this.lblcarbrd = new System.Windows.Forms.Label();
            this.lblcarvrn = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtcarversion = new System.Windows.Forms.TextBox();
            this.txtplatenumber = new System.Windows.Forms.TextBox();
            this.lblpnum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcarbrand
            // 
            this.txtcarbrand.Location = new System.Drawing.Point(161, 38);
            this.txtcarbrand.Name = "txtcarbrand";
            this.txtcarbrand.Size = new System.Drawing.Size(162, 20);
            this.txtcarbrand.TabIndex = 0;
            // 
            // lblcarbrd
            // 
            this.lblcarbrd.AutoSize = true;
            this.lblcarbrd.Location = new System.Drawing.Point(85, 38);
            this.lblcarbrd.Name = "lblcarbrd";
            this.lblcarbrd.Size = new System.Drawing.Size(55, 13);
            this.lblcarbrd.TabIndex = 1;
            this.lblcarbrd.Text = "Car brand";
            // 
            // lblcarvrn
            // 
            this.lblcarvrn.AutoSize = true;
            this.lblcarvrn.Location = new System.Drawing.Point(85, 83);
            this.lblcarvrn.Name = "lblcarvrn";
            this.lblcarvrn.Size = new System.Drawing.Size(62, 13);
            this.lblcarvrn.TabIndex = 2;
            this.lblcarvrn.Text = "Car version";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 159);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(161, 194);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtcarversion
            // 
            this.txtcarversion.Location = new System.Drawing.Point(161, 83);
            this.txtcarversion.Name = "txtcarversion";
            this.txtcarversion.Size = new System.Drawing.Size(162, 20);
            this.txtcarversion.TabIndex = 5;
            this.txtcarversion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtplatenumber
            // 
            this.txtplatenumber.Location = new System.Drawing.Point(161, 131);
            this.txtplatenumber.Name = "txtplatenumber";
            this.txtplatenumber.Size = new System.Drawing.Size(162, 20);
            this.txtplatenumber.TabIndex = 7;
            this.txtplatenumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblpnum
            // 
            this.lblpnum.AutoSize = true;
            this.lblpnum.Location = new System.Drawing.Point(85, 131);
            this.lblpnum.Name = "lblpnum";
            this.lblpnum.Size = new System.Drawing.Size(70, 13);
            this.lblpnum.TabIndex = 6;
            this.lblpnum.Text = "Plate number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 458);
            this.Controls.Add(this.txtplatenumber);
            this.Controls.Add(this.lblpnum);
            this.Controls.Add(this.txtcarversion);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblcarvrn);
            this.Controls.Add(this.lblcarbrd);
            this.Controls.Add(this.txtcarbrand);
            this.Name = "Form1";
            this.Text = "Car management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcarbrand;
        private System.Windows.Forms.Label lblcarbrd;
        private System.Windows.Forms.Label lblcarvrn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtcarversion;
        private System.Windows.Forms.TextBox txtplatenumber;
        private System.Windows.Forms.Label lblpnum;
    }
}

