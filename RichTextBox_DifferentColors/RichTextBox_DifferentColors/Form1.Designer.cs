namespace RichTextBox_DifferentColors
{
    partial class Colorful_RichTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colorful_RichTextBox));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonError = new System.Windows.Forms.Button();
            this.buttonSuccess = new System.Windows.Forms.Button();
            this.buttonOther = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(26, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(457, 235);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonError
            // 
            this.buttonError.BackColor = System.Drawing.Color.Red;
            this.buttonError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonError.ForeColor = System.Drawing.Color.White;
            this.buttonError.Location = new System.Drawing.Point(520, 24);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(88, 34);
            this.buttonError.TabIndex = 1;
            this.buttonError.Text = "ERROR";
            this.buttonError.UseVisualStyleBackColor = false;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // buttonSuccess
            // 
            this.buttonSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuccess.ForeColor = System.Drawing.Color.White;
            this.buttonSuccess.Location = new System.Drawing.Point(520, 84);
            this.buttonSuccess.Name = "buttonSuccess";
            this.buttonSuccess.Size = new System.Drawing.Size(88, 34);
            this.buttonSuccess.TabIndex = 2;
            this.buttonSuccess.Text = "SUCCESS";
            this.buttonSuccess.UseVisualStyleBackColor = false;
            this.buttonSuccess.Click += new System.EventHandler(this.buttonSuccess_Click);
            // 
            // buttonOther
            // 
            this.buttonOther.BackColor = System.Drawing.Color.Gray;
            this.buttonOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOther.ForeColor = System.Drawing.Color.White;
            this.buttonOther.Location = new System.Drawing.Point(520, 145);
            this.buttonOther.Name = "buttonOther";
            this.buttonOther.Size = new System.Drawing.Size(88, 34);
            this.buttonOther.TabIndex = 3;
            this.buttonOther.Text = "OTHER";
            this.buttonOther.UseVisualStyleBackColor = false;
            this.buttonOther.Click += new System.EventHandler(this.buttonOther_Click);
            // 
            // Colorful_RichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 277);
            this.Controls.Add(this.buttonOther);
            this.Controls.Add(this.buttonSuccess);
            this.Controls.Add(this.buttonError);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Colorful_RichTextBox";
            this.Text = "Colorful RichTextBox";
            this.Load += new System.EventHandler(this.Colorful_RichTextBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.Button buttonSuccess;
        private System.Windows.Forms.Button buttonOther;
    }
}

