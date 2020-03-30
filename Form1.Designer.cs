namespace StringManipulator
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
            this.btnToUpper = new System.Windows.Forms.Button();
            this.txtStringInput = new System.Windows.Forms.TextBox();
            this.btnAlternate = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToUpper
            // 
            this.btnToUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToUpper.Location = new System.Drawing.Point(163, 141);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(213, 60);
            this.btnToUpper.TabIndex = 0;
            this.btnToUpper.Text = "To Upper";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // txtStringInput
            // 
            this.txtStringInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringInput.Location = new System.Drawing.Point(209, 76);
            this.txtStringInput.Name = "txtStringInput";
            this.txtStringInput.Size = new System.Drawing.Size(400, 38);
            this.txtStringInput.TabIndex = 1;
            // 
            // btnAlternate
            // 
            this.btnAlternate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternate.Location = new System.Drawing.Point(468, 141);
            this.btnAlternate.Name = "btnAlternate";
            this.btnAlternate.Size = new System.Drawing.Size(213, 60);
            this.btnAlternate.TabIndex = 2;
            this.btnAlternate.Text = "Alternate";
            this.btnAlternate.UseVisualStyleBackColor = true;
            this.btnAlternate.Click += new System.EventHandler(this.btnAlternate_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.Location = new System.Drawing.Point(313, 251);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(216, 62);
            this.btnCreateFile.TabIndex = 3;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnAlternate);
            this.Controls.Add(this.txtStringInput);
            this.Controls.Add(this.btnToUpper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.TextBox txtStringInput;
        private System.Windows.Forms.Button btnAlternate;
        private System.Windows.Forms.Button btnCreateFile;
    }
}

