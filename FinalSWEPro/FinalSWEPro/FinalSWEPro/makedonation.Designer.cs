namespace FinalSWEPro
{
    partial class makedonation
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
            this.UserID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DatetxtBox = new System.Windows.Forms.TextBox();
            this.DonBtn = new System.Windows.Forms.Button();
            this.DonTyetxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(331, 121);
            this.UserID.Margin = new System.Windows.Forms.Padding(4);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(401, 24);
            this.UserID.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Date";
            // 
            // DatetxtBox
            // 
            this.DatetxtBox.Location = new System.Drawing.Point(331, 343);
            this.DatetxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.DatetxtBox.Name = "DatetxtBox";
            this.DatetxtBox.Size = new System.Drawing.Size(401, 22);
            this.DatetxtBox.TabIndex = 35;
            // 
            // DonBtn
            // 
            this.DonBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.DonBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DonBtn.Location = new System.Drawing.Point(404, 427);
            this.DonBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DonBtn.Name = "DonBtn";
            this.DonBtn.Size = new System.Drawing.Size(223, 44);
            this.DonBtn.TabIndex = 34;
            this.DonBtn.Text = "Save Donation";
            this.DonBtn.UseVisualStyleBackColor = false;
            this.DonBtn.Click += new System.EventHandler(this.DonBtn_Click);
            // 
            // DonTyetxtBox
            // 
            this.DonTyetxtBox.Location = new System.Drawing.Point(331, 236);
            this.DonTyetxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.DonTyetxtBox.Name = "DonTyetxtBox";
            this.DonTyetxtBox.Size = new System.Drawing.Size(401, 22);
            this.DonTyetxtBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Donation Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Donate Screen";
            // 
            // makedonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 498);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DatetxtBox);
            this.Controls.Add(this.DonBtn);
            this.Controls.Add(this.DonTyetxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "makedonation";
            this.Text = "makedonation";
            this.Load += new System.EventHandler(this.makedonation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DatetxtBox;
        private System.Windows.Forms.Button DonBtn;
        private System.Windows.Forms.TextBox DonTyetxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}