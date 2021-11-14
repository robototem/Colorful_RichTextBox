using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Created by @github.com/robototem
/// </summary>
namespace RichTextBox_DifferentColors
{
    public partial class Colorful_RichTextBox : Form
    {
        public Colorful_RichTextBox()
        {
            InitializeComponent();
        }

        private void Colorful_RichTextBox_Load(object sender, EventArgs e)
        {
            Log("Click buttons to print messages.");
        }


        /// <summary>
        /// Takes string messages as input. The code of message should be declared in the beginning of the string.
        /// </summary>
        /// <param name="mymessage"></param>
        private void Log(string mymessage)
        {
            // (1000) ERROR message
            // (2000) SUCCESS message
            // (1002) OTHER messages
            if (mymessage.Substring(0, 6) == "(1000)")
            {
                string newmessage = DateTime.Now + ": " + mymessage + "\n";

                richTextBox1.Select(richTextBox1.TextLength, newmessage.Length);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText(newmessage);
                
            }
            else if (mymessage.Substring(0, 6) == "(2000)")
            {
                string newmessage = DateTime.Now + ": " + mymessage + "\n";

                richTextBox1.Select(richTextBox1.TextLength, newmessage.Length);
                richTextBox1.SelectionColor = Color.Green;
                richTextBox1.AppendText(newmessage);
            }
            else
            {
                string newmessage = DateTime.Now + ": " + mymessage + "\n";

                richTextBox1.Select(richTextBox1.TextLength, newmessage.Length);
                richTextBox1.SelectionColor = Color.Gray;
                richTextBox1.AppendText(newmessage);

            }

        }

        private void buttonError_Click(object sender, EventArgs e)
        {
            Log("(1000) This is an ERROR message.");
        }

        private void buttonSuccess_Click(object sender, EventArgs e)
        {
            Log("(2000) This is a SUCCESS message.");
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            Log("This is a normal message.");
        }
    }
}
