using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OnscreenKeyboardForm
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        //Declare boolean value to control letter case
        bool caps = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        #region Letter Keys
        private void buttonA_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps==false)
                InsertCharacter("a");
            else
            InsertCharacter("A");
            FocusInput();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("b");
            else
                InsertCharacter("B");
            FocusInput();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("c");
            else
                InsertCharacter("C");
            FocusInput();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("d");
            else
                InsertCharacter("D");
            FocusInput();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("e");
            else
                InsertCharacter("E");
            FocusInput();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("f");
            else
                InsertCharacter("F");
            FocusInput();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("g");
            else
                InsertCharacter("G");
            FocusInput();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("h");
            else
                InsertCharacter("H");
            FocusInput();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("i");
            else
                InsertCharacter("I");
            FocusInput();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("j");
            else
                InsertCharacter("J");
            FocusInput();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("k");
            else
                InsertCharacter("K");
            FocusInput();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("l");
            else
                InsertCharacter("L");
            FocusInput();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("m");
            else
                InsertCharacter("M");
            FocusInput();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("n");
            else
                InsertCharacter("N");
            FocusInput();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("o");
            else
                InsertCharacter("O");
            FocusInput();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("p");
            else
                InsertCharacter("P");
            FocusInput();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("q");
            else
                InsertCharacter("Q");
            FocusInput();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("r");
            else
                InsertCharacter("R");
            FocusInput();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps==false)
            InsertCharacter("s");
            else
                InsertCharacter("S");
            FocusInput();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("t");
            else
                InsertCharacter("T");
            FocusInput();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("u");
            else
                InsertCharacter("U");
            FocusInput();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("v");
            else
                InsertCharacter("V");
            FocusInput();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("w");
            else
                InsertCharacter("W");
            FocusInput();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("x");
            else
                InsertCharacter("X");
            FocusInput();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("y");
            else
                InsertCharacter("Y");
            FocusInput();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            //Types respective letter
            if (caps == false)
                InsertCharacter("z");
            else
                InsertCharacter("Z");
            FocusInput();
        }

        #endregion

        #region Symbols
        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            //Types period, and capitalises the next letter
            InsertCharacter(".");
            caps = true;
            FocusInput();
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            //Types comma
            InsertCharacter(",");
            FocusInput();
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            //Types space
            InsertCharacter(" ");
            FocusInput();
        }

        private void buttonQmark_Click(object sender, EventArgs e)
        {
            //Types question mark
            InsertCharacter("?");
            FocusInput();
        }

        private void buttonExclaim_Click(object sender, EventArgs e)
        {
            //Types exclamation mark
            InsertCharacter("!");
            FocusInput();
        }

        #endregion

        #region Special Keys

        private void buttonCaps_Click(object sender, EventArgs e)
        {
            ChangeCaps();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DeleteCharacter();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            InsertCharacter(" "+ Environment.NewLine);
            FocusInput();
        }

        #endregion

        #region Text Formatting Functions
        //Functions which are performed after keypresses
        private void FocusInput()
        {
            //returns focus to the rich textbox
            this.richEditText.Focus();
        }

        private void InsertCharacter(string v)
        {
            //adds new character to the textbox

            //mark location of cursor
            int selectionIndex = this.richEditText.SelectionStart;

            //add value to string
            this.richEditText.Text = this.richEditText.Text.Insert(this.richEditText.SelectionStart, v);

            //Move cursor to next position
            this.richEditText.SelectionStart = selectionIndex + v.Length;

            //set selection length to zero (this prevents FocusInput() from highlighting entire textbox)
            this.richEditText.SelectionLength = 0;

        }

        private void DeleteCharacter()
        {
            /*returns if no value can be deleted
            if (this.richEditText.Text.Length < this.richEditText.SelectionStart + )
                return;
            - Edited out; doesnt allow for deletion of the last character in a string
             */

            //remember selection start
            int selectionIndex = this.richEditText.SelectionStart;

            //delete value before selection
            this.richEditText.Text = this.richEditText.Text.Remove((this.richEditText.SelectionStart)-1, 1);

            //restore selection start
            this.richEditText.SelectionStart = selectionIndex;

            //set selection length to zero
            this.richEditText.SelectionLength = 0;
        }

        private void ChangeCaps()
        {
            if (caps == true)
                caps = false;

            else caps = true;
            //this.buttonCaps.Text

        }



        #endregion


        #region Click Automation
        //Region currently
        private void timer1_Tick(object sender, EventArgs e)
        {
            DoMouseClick();
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        #endregion


        #region Automated Clicks (enter and leave)
        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonA_Enter(object sender, EventArgs e)
        {
            //timer1.Start(); -Clicks outside window
            //buttonA.PerformClick(); - Clicks on start, doesnt work
        }

        private void buttonA_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        #endregion

    }
}