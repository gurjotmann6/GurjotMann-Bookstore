namespace GurjotMann_Bookstore
{
    partial class frmPin
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblDirections1 = new System.Windows.Forms.Label();
            this.lblDigits = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnOKPin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(449, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Worm Book Store";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(174, 68);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(127, 20);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = "Pin Entry Form";
            // 
            // lblDirections1
            // 
            this.lblDirections1.AutoSize = true;
            this.lblDirections1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections1.Location = new System.Drawing.Point(69, 150);
            this.lblDirections1.Name = "lblDirections1";
            this.lblDirections1.Size = new System.Drawing.Size(183, 18);
            this.lblDirections1.TabIndex = 2;
            this.lblDirections1.Text = "Enter Pin and press OK...";
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigits.Location = new System.Drawing.Point(69, 217);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(118, 16);
            this.lblDigits.TabIndex = 3;
            this.lblDigits.Text = "Pin(4 digit number)";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(222, 216);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 4;
            // 
            // btnOKPin
            // 
            this.btnOKPin.BackColor = System.Drawing.Color.Lime;
            this.btnOKPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKPin.Location = new System.Drawing.Point(177, 286);
            this.btnOKPin.Name = "btnOKPin";
            this.btnOKPin.Size = new System.Drawing.Size(75, 30);
            this.btnOKPin.TabIndex = 5;
            this.btnOKPin.Text = "OK";
            this.btnOKPin.UseVisualStyleBackColor = false;
            this.btnOKPin.Click += new System.EventHandler(this.btnOKPin_Click);
            // 
            // frmPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 356);
            this.Controls.Add(this.btnOKPin);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblDigits);
            this.Controls.Add(this.lblDirections1);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPin";
            this.Text = "Pin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblDirections1;
        private System.Windows.Forms.Label lblDigits;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnOKPin;
    }
}