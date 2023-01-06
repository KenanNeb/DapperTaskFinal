namespace DapperTask
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.prodcost_tbox = new System.Windows.Forms.TextBox();
            this.prodcountry_tbox = new System.Windows.Forms.TextBox();
            this.prodname_tbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Product Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Origin Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product Name";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(217, 198);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(82, 22);
            this.cancel_btn.TabIndex = 16;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(28, 198);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(82, 22);
            this.ok_btn.TabIndex = 17;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // prodcost_tbox
            // 
            this.prodcost_tbox.Location = new System.Drawing.Point(28, 157);
            this.prodcost_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodcost_tbox.Name = "prodcost_tbox";
            this.prodcost_tbox.Size = new System.Drawing.Size(272, 23);
            this.prodcost_tbox.TabIndex = 15;
            // 
            // prodcountry_tbox
            // 
            this.prodcountry_tbox.Location = new System.Drawing.Point(28, 103);
            this.prodcountry_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodcountry_tbox.Name = "prodcountry_tbox";
            this.prodcountry_tbox.Size = new System.Drawing.Size(272, 23);
            this.prodcountry_tbox.TabIndex = 14;
            // 
            // prodname_tbox
            // 
            this.prodname_tbox.Location = new System.Drawing.Point(28, 50);
            this.prodname_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodname_tbox.Name = "prodname_tbox";
            this.prodname_tbox.Size = new System.Drawing.Size(272, 23);
            this.prodname_tbox.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.prodcost_tbox);
            this.Controls.Add(this.prodcountry_tbox);
            this.Controls.Add(this.prodname_tbox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button cancel_btn;
        private Button ok_btn;
        public TextBox prodcost_tbox;
        public TextBox prodcountry_tbox;
        public TextBox prodname_tbox;
    }
}