namespace P2_Code
{
    partial class FormSeeFish
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonThrowItBack = new System.Windows.Forms.Button();
            this.buttonKeepIt = new System.Windows.Forms.Button();
            this.pictureBoxFish = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFish)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(39, 319);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 40);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonThrowItBack
            // 
            this.buttonThrowItBack.Location = new System.Drawing.Point(164, 319);
            this.buttonThrowItBack.Name = "buttonThrowItBack";
            this.buttonThrowItBack.Size = new System.Drawing.Size(91, 40);
            this.buttonThrowItBack.TabIndex = 1;
            this.buttonThrowItBack.Text = "Throw it Back";
            this.buttonThrowItBack.UseVisualStyleBackColor = true;
            // 
            // buttonKeepIt
            // 
            this.buttonKeepIt.Location = new System.Drawing.Point(307, 319);
            this.buttonKeepIt.Name = "buttonKeepIt";
            this.buttonKeepIt.Size = new System.Drawing.Size(75, 40);
            this.buttonKeepIt.TabIndex = 2;
            this.buttonKeepIt.Text = "Keep it";
            this.buttonKeepIt.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFish
            // 
            this.pictureBoxFish.Location = new System.Drawing.Point(39, 32);
            this.pictureBoxFish.Name = "pictureBoxFish";
            this.pictureBoxFish.Size = new System.Drawing.Size(343, 257);
            this.pictureBoxFish.TabIndex = 3;
            this.pictureBoxFish.TabStop = false;
            // 
            // FormSeeFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 383);
            this.Controls.Add(this.pictureBoxFish);
            this.Controls.Add(this.buttonKeepIt);
            this.Controls.Add(this.buttonThrowItBack);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormSeeFish";
            this.Text = "Keep it or let it go";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonThrowItBack;
        private System.Windows.Forms.Button buttonKeepIt;
        private System.Windows.Forms.PictureBox pictureBoxFish;
    }
}