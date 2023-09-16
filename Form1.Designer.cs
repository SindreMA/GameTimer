namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.bAddP = new System.Windows.Forms.Button();
            this.bUnistall = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAddP
            // 
            this.bAddP.Location = new System.Drawing.Point(12, 12);
            this.bAddP.Name = "bAddP";
            this.bAddP.Size = new System.Drawing.Size(195, 37);
            this.bAddP.TabIndex = 0;
            this.bAddP.Text = "Add Program";
            this.bAddP.UseVisualStyleBackColor = true;
            this.bAddP.Click += new System.EventHandler(this.bAddP_Click);
            // 
            // bUnistall
            // 
            this.bUnistall.Location = new System.Drawing.Point(12, 97);
            this.bUnistall.Name = "bUnistall";
            this.bUnistall.Size = new System.Drawing.Size(195, 34);
            this.bUnistall.TabIndex = 2;
            this.bUnistall.Text = "Uninstall";
            this.bUnistall.UseVisualStyleBackColor = true;
            this.bUnistall.Click += new System.EventHandler(this.bUnistall_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show Total Time";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 145);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bUnistall);
            this.Controls.Add(this.bAddP);
            this.Name = "Form1";
            this.Text = "Process Tracker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddP;
        private System.Windows.Forms.Button bUnistall;
        private System.Windows.Forms.Button button3;
    }
}

