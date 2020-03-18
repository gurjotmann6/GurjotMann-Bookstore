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
    public partial class frmAccessId : Form
    {
        public frmAccessId()
        {
            InitializeComponent();
        }

        private void frmAccessId_Load(object sender, EventArgs e)
        {
            Globals.BookStore.EmployeeList.initializeEntireList();
        }

        //
        private void btnFindMe_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeClass emp;
                bool found = false;
                if (Convert.ToString(txtAccessID.Text).Length != 5)
                {
                    MessageBox.Show("Input does not meet requirements.");
                    MessageBox.Show("Attempts Left: " + (2 - Globals.BookStore.getTryCount()), "Cannot find AccessID.");
                    Globals.BookStore.incrementTryCount();
                    txtAccessID.Focus();
                    txtAccessID.Clear();
                    return;
                }
                emp = Globals.BookStore.findEmployee(Convert.ToInt32(txtAccessID.Text), out found);
                if (found == true)
                {
                    MessageBox.Show("Employee Exists.");
                }
                else
                {
                    MessageBox.Show("Attempts Left: " + (2 - Globals.BookStore.getTryCount()), "Cannot find AccessID.");
                    Globals.BookStore.incrementTryCount();
                    txtAccessID.Focus();
                    txtAccessID.Clear();
                    if (!Globals.BookStore.checkTryCount())
                    {
                        MessageBox.Show("Max tries.");
                        System.Windows.Forms.Application.Exit();
                    }
                    return;
                }

                this.Visible = false;
                frmPin newForm = new frmPin();
                newForm.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input does not meet requirements.");
                MessageBox.Show("Attempts Left: " + (2 - Globals.BookStore.getTryCount()), "Cannot find AccessID.");
                Globals.BookStore.incrementTryCount();
                txtAccessID.Focus();
                txtAccessID.Clear();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
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
