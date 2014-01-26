namespace TestHaarCSharp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransformTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.btnForwardSafe = new System.Windows.Forms.Button();
            this.btnForwardUnsafe = new System.Windows.Forms.Button();
            this.btnInverseUnsafe = new System.Windows.Forms.Button();
            this.btnInverseSafe = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TestHaarCSharp.Properties.Resources.lena;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(180, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(150, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnInverseUnsafe);
            this.panel1.Controls.Add(this.btnInverseSafe);
            this.panel1.Controls.Add(this.btnForwardUnsafe);
            this.panel1.Controls.Add(this.btnForwardSafe);
            this.panel1.Controls.Add(this.txtIterations);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 512);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 512);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblDirection);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.lblTransformTime);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblHeight);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblWidth);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(692, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 512);
            this.panel3.TabIndex = 2;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(65, 42);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(25, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "512";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(65, 22);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(25, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "512";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transform Time:";
            // 
            // lblTransformTime
            // 
            this.lblTransformTime.AutoSize = true;
            this.lblTransformTime.Location = new System.Drawing.Point(106, 71);
            this.lblTransformTime.Name = "lblTransformTime";
            this.lblTransformTime.Size = new System.Drawing.Size(13, 13);
            this.lblTransformTime.TabIndex = 5;
            this.lblTransformTime.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iterations:";
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(72, 68);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(90, 20);
            this.txtIterations.TabIndex = 7;
            this.txtIterations.Text = "1";
            // 
            // btnForwardSafe
            // 
            this.btnForwardSafe.Location = new System.Drawing.Point(16, 113);
            this.btnForwardSafe.Name = "btnForwardSafe";
            this.btnForwardSafe.Size = new System.Drawing.Size(146, 23);
            this.btnForwardSafe.TabIndex = 8;
            this.btnForwardSafe.Text = "Forward (Safe Code)";
            this.btnForwardSafe.UseVisualStyleBackColor = true;
            this.btnForwardSafe.Click += new System.EventHandler(this.btnForwardSafe_Click);
            // 
            // btnForwardUnsafe
            // 
            this.btnForwardUnsafe.Location = new System.Drawing.Point(16, 143);
            this.btnForwardUnsafe.Name = "btnForwardUnsafe";
            this.btnForwardUnsafe.Size = new System.Drawing.Size(146, 23);
            this.btnForwardUnsafe.TabIndex = 9;
            this.btnForwardUnsafe.Text = "Forward (Unsafe Code)";
            this.btnForwardUnsafe.UseVisualStyleBackColor = true;
            this.btnForwardUnsafe.Click += new System.EventHandler(this.btnForwardUnsafe_Click);
            // 
            // btnInverseUnsafe
            // 
            this.btnInverseUnsafe.Location = new System.Drawing.Point(16, 234);
            this.btnInverseUnsafe.Name = "btnInverseUnsafe";
            this.btnInverseUnsafe.Size = new System.Drawing.Size(146, 23);
            this.btnInverseUnsafe.TabIndex = 11;
            this.btnInverseUnsafe.Text = "Inverse (Unsafe Code)";
            this.btnInverseUnsafe.UseVisualStyleBackColor = true;
            this.btnInverseUnsafe.Click += new System.EventHandler(this.btnInverseUnsafe_Click);
            // 
            // btnInverseSafe
            // 
            this.btnInverseSafe.Location = new System.Drawing.Point(16, 204);
            this.btnInverseSafe.Name = "btnInverseSafe";
            this.btnInverseSafe.Size = new System.Drawing.Size(146, 23);
            this.btnInverseSafe.TabIndex = 10;
            this.btnInverseSafe.Text = "Inverse (Safe Code)";
            this.btnInverseSafe.UseVisualStyleBackColor = true;
            this.btnInverseSafe.Click += new System.EventHandler(this.btnInverseSafe_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(20, 88);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 13);
            this.lblDirection.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 512);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTransformTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Button btnInverseUnsafe;
        private System.Windows.Forms.Button btnInverseSafe;
        private System.Windows.Forms.Button btnForwardUnsafe;
        private System.Windows.Forms.Button btnForwardSafe;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDirection;
    }
}

