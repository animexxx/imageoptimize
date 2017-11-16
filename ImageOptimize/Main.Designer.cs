namespace ImageOptimize
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.txtImgFoldInput = new System.Windows.Forms.TextBox();
            this.btnImgFoldInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImgFoldOut = new System.Windows.Forms.TextBox();
            this.btnImgFoldOutput = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Optimize image before upload, for high google pagespeed and save hosting memory.";
            // 
            // txtImgFoldInput
            // 
            this.txtImgFoldInput.Location = new System.Drawing.Point(15, 48);
            this.txtImgFoldInput.Name = "txtImgFoldInput";
            this.txtImgFoldInput.Size = new System.Drawing.Size(310, 20);
            this.txtImgFoldInput.TabIndex = 1;
            // 
            // btnImgFoldInput
            // 
            this.btnImgFoldInput.Location = new System.Drawing.Point(331, 46);
            this.btnImgFoldInput.Name = "btnImgFoldInput";
            this.btnImgFoldInput.Size = new System.Drawing.Size(75, 23);
            this.btnImgFoldInput.TabIndex = 2;
            this.btnImgFoldInput.Text = "Pick";
            this.btnImgFoldInput.UseVisualStyleBackColor = true;
            this.btnImgFoldInput.Click += new System.EventHandler(this.btnImgFoldInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Images folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Images output folder:";
            // 
            // txtImgFoldOut
            // 
            this.txtImgFoldOut.Location = new System.Drawing.Point(15, 106);
            this.txtImgFoldOut.Name = "txtImgFoldOut";
            this.txtImgFoldOut.Size = new System.Drawing.Size(310, 20);
            this.txtImgFoldOut.TabIndex = 1;
            // 
            // btnImgFoldOutput
            // 
            this.btnImgFoldOutput.Location = new System.Drawing.Point(331, 104);
            this.btnImgFoldOutput.Name = "btnImgFoldOutput";
            this.btnImgFoldOutput.Size = new System.Drawing.Size(75, 23);
            this.btnImgFoldOutput.TabIndex = 2;
            this.btnImgFoldOutput.Text = "Pick";
            this.btnImgFoldOutput.UseVisualStyleBackColor = true;
            this.btnImgFoldOutput.Click += new System.EventHandler(this.btnImgFoldOutput_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 212);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(391, 23);
            this.progressBar.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 183);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Resize max width:";
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Location = new System.Drawing.Point(15, 157);
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(310, 20);
            this.txtMaxWidth.TabIndex = 1;
            this.txtMaxWidth.Text = "1024";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "px";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 247);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnImgFoldOutput);
            this.Controls.Add(this.btnImgFoldInput);
            this.Controls.Add(this.txtMaxWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImgFoldOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImgFoldInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Image optimize by DuyNV http://i-devso.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImgFoldInput;
        private System.Windows.Forms.Button btnImgFoldInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImgFoldOut;
        private System.Windows.Forms.Button btnImgFoldOutput;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxWidth;
        private System.Windows.Forms.Label label5;
    }
}

