namespace GMinified
{
    partial class frmMinify
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
            this.btnMinify = new System.Windows.Forms.Button();
            this.fbdInput = new System.Windows.Forms.FolderBrowserDialog();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMinify
            // 
            this.btnMinify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinify.Location = new System.Drawing.Point(490, 100);
            this.btnMinify.Name = "btnMinify";
            this.btnMinify.Size = new System.Drawing.Size(117, 32);
            this.btnMinify.TabIndex = 0;
            this.btnMinify.Text = "&Minify";
            this.btnMinify.UseVisualStyleBackColor = true;
            this.btnMinify.Click += new System.EventHandler(this.btnMinify_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(22, 28);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(31, 23);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "...";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(22, 66);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(31, 23);
            this.btnOutput.TabIndex = 2;
            this.btnOutput.Text = "...";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(59, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(548, 20);
            this.txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(59, 69);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(548, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose input folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose output folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Develop By:  Gaurav Malviya";
            // 
            // frmMinify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 144);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnMinify);
            this.Name = "frmMinify";
            this.Text = "CSS & JS Minify  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinify;
        private System.Windows.Forms.FolderBrowserDialog fbdInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

