namespace Stok_Programı
{
    partial class Form9
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cikiss = new System.Windows.Forms.Button();
            this.btn_tamekran = new System.Windows.Forms.Button();
            this.btn_simge = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Controls.Add(this.btn_cikiss, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_tamekran, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_simge, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(388, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(136, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_cikiss
            // 
            this.btn_cikiss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cikiss.FlatAppearance.BorderSize = 0;
            this.btn_cikiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikiss.Location = new System.Drawing.Point(100, 7);
            this.btn_cikiss.Name = "btn_cikiss";
            this.btn_cikiss.Size = new System.Drawing.Size(30, 30);
            this.btn_cikiss.TabIndex = 2;
            this.btn_cikiss.UseVisualStyleBackColor = true;
            this.btn_cikiss.Click += new System.EventHandler(this.btn_cikiss_Click);
            // 
            // btn_tamekran
            // 
            this.btn_tamekran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tamekran.FlatAppearance.BorderSize = 0;
            this.btn_tamekran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tamekran.Location = new System.Drawing.Point(54, 7);
            this.btn_tamekran.Name = "btn_tamekran";
            this.btn_tamekran.Size = new System.Drawing.Size(30, 30);
            this.btn_tamekran.TabIndex = 3;
            this.btn_tamekran.UseVisualStyleBackColor = true;
            this.btn_tamekran.Click += new System.EventHandler(this.btn_tamekran_Click);
            // 
            // btn_simge
            // 
            this.btn_simge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_simge.FlatAppearance.BorderSize = 0;
            this.btn_simge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simge.Location = new System.Drawing.Point(8, 7);
            this.btn_simge.Name = "btn_simge";
            this.btn_simge.Size = new System.Drawing.Size(30, 30);
            this.btn_simge.TabIndex = 1;
            this.btn_simge.UseVisualStyleBackColor = true;
            this.btn_simge.Click += new System.EventHandler(this.btn_simge_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 432);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form9";
            this.Text = "AYARLAR";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_cikiss;
        private System.Windows.Forms.Button btn_tamekran;
        private System.Windows.Forms.Button btn_simge;
    }
}