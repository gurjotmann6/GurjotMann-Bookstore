namespace GurjotMann_Bookstore
{
    partial class frmAccessId
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
            this.btnFindMe = new System.Windows.Forms.Button();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBookWorm = new System.Windows.Forms.Label();
            this.lblBookStore = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindMe
            // 
            this.btnFindMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFindMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMe.Location = new System.Drawing.Point(467, 411);
            this.btnFindMe.Name = "btnFindMe";
            this.btnFindMe.Size = new System.Drawing.Size(98, 37);
            this.btnFindMe.TabIndex = 0;
            this.btnFindMe.Text = "Find Me";
            this.btnFindMe.UseVisualStyleBackColor = false;
            this.btnFindMe.Click += new System.EventHandler(this.btnFindMe_Click);
            // 
            // txtAccessID
            // 
            this.txtAccessID.Location = new System.Drawing.Point(37, 411);
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(100, 20);
            this.txtAccessID.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(210, 33);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(157, 25);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to the...";
            // 
            // lblBookWorm
            // 
            this.lblBookWorm.AutoSize = true;
            this.lblBookWorm.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookWorm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBookWorm.Location = new System.Drawing.Point(57, 145);
            this.lblBookWorm.Name = "lblBookWorm";
            this.lblBookWorm.Size = new System.Drawing.Size(224, 39);
            this.lblBookWorm.TabIndex = 4;
            this.lblBookWorm.Text = "Book Worm";
            // 
            // lblBookStore
            // 
            this.lblBookStore.AutoSize = true;
            this.lblBookStore.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBookStore.Location = new System.Drawing.Point(57, 206);
            this.lblBookStore.Name = "lblBookStore";
            this.lblBookStore.Size = new System.Drawing.Size(232, 39);
            this.lblBookStore.TabIndex = 5;
            this.lblBookStore.Text = "Book Store";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(33, 354);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(569, 20);
            this.lblDirections.TabIndex = 6;
            this.lblDirections.Text = "Enter your FIVE DIGIT Access Id in the box below. Then click Find Me";
            // 
            // frmAccessId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 479);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblBookStore);
            this.Controls.Add(this.lblBookWorm);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtAccessID);
            this.Controls.Add(this.btnFindMe);
            this.Name = "frmAccessId";
            this.Text = "Access";
            this.Load += new System.EventHandler(this.frmAccessId_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindMe;
        private System.Windows.Forms.TextBox txtAccessID;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblBookWorm;
        private System.Windows.Forms.Label lblBookStore;
        private System.Windows.Forms.Label lblDirections;
    }
}

