namespace FinalSWEPro
{
    partial class viewpreviousdonations
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.VPD_btn = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.txtbox_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "View Previous Donations";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 22);
            this.textBox1.TabIndex = 20;
            // 
            // VPD_btn
            // 
            this.VPD_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.VPD_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VPD_btn.Location = new System.Drawing.Point(290, 444);
            this.VPD_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VPD_btn.Name = "VPD_btn";
            this.VPD_btn.Size = new System.Drawing.Size(301, 41);
            this.VPD_btn.TabIndex = 23;
            this.VPD_btn.Text = "View Previous donations";
            this.VPD_btn.UseVisualStyleBackColor = false;
            this.VPD_btn.Click += new System.EventHandler(this.VPD_btn_Click);
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGV.Location = new System.Drawing.Point(135, 146);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(607, 274);
            this.DGV.TabIndex = 22;
            // 
            // txtbox_id
            // 
            this.txtbox_id.AutoSize = true;
            this.txtbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_id.Location = new System.Drawing.Point(218, 91);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(157, 25);
            this.txtbox_id.TabIndex = 21;
            this.txtbox_id.Text = "Enter user ID : ";
            // 
            // viewpreviousdonations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VPD_btn);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.txtbox_id);
            this.Name = "viewpreviousdonations";
            this.Text = "viewpreviousdonations";
            this.Load += new System.EventHandler(this.viewpreviousdonations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button VPD_btn;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label txtbox_id;
    }
}