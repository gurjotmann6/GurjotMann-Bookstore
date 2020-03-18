using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GurjotMann_Bookstore.classes;

//Gurjot Mann
//Cis 3309-Section 1
//Frank Friedman
//Lab Bookstore Project

namespace GurjotMann_Bookstore
{
    public partial class frmPin : Form
    {
        public frmPin()
        {
            InitializeComponent();
        }

        private void btnOKPin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(txtPin.Text).Length != 4)
                {
                    MessageBox.Show("Input does not meet requirements.");
                    MessageBox.Show("Attempts Left: " + (2 - Globals.BookStore.getTryCount()), "Pin does not match AccessID.");
                    Globals.BookStore.incrementTryCount();
                    txtPin.Focus();
                    txtPin.Clear();
                    return;
                }
                if (!Globals.BookStore.EmployeeList.verifyPin(Convert.ToInt32(txtPin.Text)))
                {
                    MessageBox.Show("Attempts Left: " + (2 - Globals.BookStore.getTryCount()), "Pin does not match AccessID.");
                    Globals.BookStore.incrementTryCount();
                    txtPin.Focus();
                    txtPin.Clear();
                    if (!Globals.BookStore.checkTryCount())
                    {
                        MessageBox.Show("Max tries.");
                        System.Windows.Forms.Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Pin match.");
                    this.Visible = false;
                    frmTransaction newForm = new frmTransaction();
                    newForm.Show();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input does not meet requirements.");
                txtPin.Focus();
                txtPin.Clear();
                MessageBox.Show("Attempts Left: " + (2 - Globals.BookStore.getTryCount()), "Pin does not match AccessID.");
                Globals.BookStore.incrementTryCount();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            Application.Exit();
        }
    }
}
