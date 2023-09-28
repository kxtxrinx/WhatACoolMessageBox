using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WhatACoolMessageBoxes
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            chBYes.ForeColor = Color.White;

            //displaying current date at the corner
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();
        }

        private void chBYes_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCheckedBtns();
        }

        private void chBCancel_CheckedChanged(object sender, EventArgs e)
        {
            CheckForCheckedBtns();
        }

        private void chBNo_CheckedChanged(object sender, EventArgs e)
        {
            bool checkedBtnNo = chBNo.Checked;
            CheckForCheckedBtns();
        }

        private void CheckForCheckedBtns()
        {
            lblSelectedBtns.Text = "➼ Yes/OK Button";

            if (chBNo.Checked && chBCancel.Checked)
            {
                lblSelectedBtns.Text += "\n➼ No Button\n➼ Cancel Button";
            }else if (chBNo.Checked)
            {
                lblSelectedBtns.Text += "\n➼ No Button";
            }else if (chBCancel.Checked)
            {
                lblSelectedBtns.Text += "\n➼ Cancel Button";
            }
            else
            {
                //do nothing
            }
        }

        private void grBButtons_Enter(object sender, EventArgs e)
        {

        }

        //Generates the MessageBox
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string mbTitle = txBTitle.Text;
            string mbMessage = txBMessage.Text;
            MessageBoxButtons neededButtons;


            if (mbTitle == string.Empty || mbMessage == string.Empty)
            {
                MessageBox.Show("Enter a valid title and message", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (chBNo.Checked && chBCancel.Checked)
                {
                    neededButtons = MessageBoxButtons.YesNoCancel;
                }
                else if (chBNo.Checked)
                {
                    neededButtons = MessageBoxButtons.YesNo;
                }
                else
                {
                    neededButtons = MessageBoxButtons.OKCancel;
                }

                MessageBoxIcon neededIcon;
                if (rdBInfo.Checked)
                {
                    neededIcon = MessageBoxIcon.Information;
                }
                else if (rdBWarning.Checked)
                {
                    neededIcon = MessageBoxIcon.Warning;
                }
                else if (rdBError.Checked)
                {
                    neededIcon = MessageBoxIcon.Error;
                }
                else
                {
                    neededIcon = MessageBoxIcon.None;
                }

                DialogResult result = MessageBox.Show(mbMessage, mbTitle, neededButtons, neededIcon);
                //Displaying the selected option in the Notepad area
                lblSelectedOption.Text = "➼ Clicked: " + result.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chBYes_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a");
        }

        //Function needed to calculate the coordinates since putting a "non-visible" button wasn't working
        //Not optimal since it's not working if the windows is resized but it should be an easter egg so no (that big) problem, hehe
        private void mainWindow_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            //MyComputer area easter egg (Information sample)
            int minCoorXMC = 5;
            int minCoorYMC = 5;

            int maxCoorXMC = 90;
            int maxCoorYMC = 60;

            //Recycle Bin area easter egg (Error sample)
            int minCoorXRB = 22;
            int minCoorYRB = 290;

            int maxCoorXRB = 90;
            int maxCoorYRB = 350;

            //InternetExplorer easter egg
            int minCoorXIE = 95;
            int minCoorYIE = 590;

            int maxCoorXIE = 115;
            int maxCoorYIE = 610;

            if (x >= minCoorXRB && x <= maxCoorXRB && y >= minCoorYRB && y <= maxCoorYRB)
            {
               MessageBox.Show("Bin is at its limit.\nConsider permantly removing the 'final', 'final2', 'final23123', 'asdfd' folders.", "Unable to open the recycle bin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }else if(x >= minCoorXMC && x <= maxCoorXMC && y >= minCoorYMC && y <= maxCoorYMC)
            {
                MessageBox.Show("there's nothing here...just too many unfinished sketches and a mess of folders", "Personal Folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (x >= minCoorXIE && x <= maxCoorXIE && y >= minCoorYIE && y <= maxCoorYIE)
            {
                MessageBox.Show($"why-why would you open Internet Explorer in {DateTime.Now.Year}", "don't...please",MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


        }

        //Needed to make the date bigger so it fits in the corner if the window is resizable
        //didn't get it :(
        private void mainWindow_SizeChanged(object sender, EventArgs e)
        {
            /*
            int fontSize = this.Width / 85;

            lblCurrentDate.Font = new Font(lblCurrentDate.Font.FontFamily, fontSize);
            */
        }

        //Trying to close Notepad, easter egg (Warning sample)
        private void pBNotepad_Click(object sender, EventArgs e)
        {
            //Needed to get the coordinates this way since we didn't have MouseEventArgs as a parameter
            MouseEventArgs preCoordinates = (MouseEventArgs)e;
            Point coordinates = preCoordinates.Location;
            //MessageBox.Show($"click at X: {coordinates.X} Y: {coordinates.Y}");

            int minX = 200;
            int minY = 5;

            int maxX = 220;
            int maxY = 15;

            if((coordinates.X > minX && coordinates.Y > minY) && (coordinates.X < maxX && coordinates.Y < maxY))
            {
                MessageBox.Show("Your file has unsaved local changes.\nThey will be lost if you don't save them.", "Unsaved changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
