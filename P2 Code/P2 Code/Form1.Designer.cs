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
            this.buttonSeeFish = new System.Windows.Forms.Button();
            this.groupBoxChooseFishToSee = new System.Windows.Forms.GroupBox();
            this.radioButtonCrappie = new System.Windows.Forms.RadioButton();
            this.radioButtonPerch = new System.Windows.Forms.RadioButton();
            this.radioButtonWalleye = new System.Windows.Forms.RadioButton();
            this.groupBoxChooseFishToSee.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSeeFish
            // 
            this.buttonSeeFish.Location = new System.Drawing.Point(242, 261);
            this.buttonSeeFish.Name = "buttonSeeFish";
            this.buttonSeeFish.Size = new System.Drawing.Size(75, 23);
            this.buttonSeeFish.TabIndex = 0;
            this.buttonSeeFish.Text = "See Fish";
            this.buttonSeeFish.UseVisualStyleBackColor = true;
            this.buttonSeeFish.Click += new System.EventHandler(this.buttonSeeFish_Click);
            // 
            // groupBoxChooseFishToSee
            // 
            this.groupBoxChooseFishToSee.Controls.Add(this.radioButtonWalleye);
            this.groupBoxChooseFishToSee.Controls.Add(this.radioButtonPerch);
            this.groupBoxChooseFishToSee.Controls.Add(this.radioButtonCrappie);
            this.groupBoxChooseFishToSee.Location = new System.Drawing.Point(45, 45);
            this.groupBoxChooseFishToSee.Name = "groupBoxChooseFishToSee";
            this.groupBoxChooseFishToSee.Size = new System.Drawing.Size(272, 178);
            this.groupBoxChooseFishToSee.TabIndex = 1;
            this.groupBoxChooseFishToSee.TabStop = false;
            this.groupBoxChooseFishToSee.Text = "Choose a fish to see";
            this.groupBoxChooseFishToSee.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonCrappie
            // 
            this.radioButtonCrappie.AutoSize = true;
            this.radioButtonCrappie.Location = new System.Drawing.Point(37, 44);
            this.radioButtonCrappie.Name = "radioButtonCrappie";
            this.radioButtonCrappie.Size = new System.Drawing.Size(61, 17);
            this.radioButtonCrappie.TabIndex = 2;
            this.radioButtonCrappie.TabStop = true;
            this.radioButtonCrappie.Text = "Crappie";
            this.radioButtonCrappie.UseVisualStyleBackColor = true;
            this.radioButtonCrappie.CheckedChanged += new System.EventHandler(this.radioButtonCrappie_CheckedChanged);
            // 
            // radioButtonPerch
            // 
            this.radioButtonPerch.AutoSize = true;
            this.radioButtonPerch.Location = new System.Drawing.Point(37, 82);
            this.radioButtonPerch.Name = "radioButtonPerch";
            this.radioButtonPerch.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPerch.TabIndex = 3;
            this.radioButtonPerch.TabStop = true;
            this.radioButtonPerch.Text = "Perch";
            this.radioButtonPerch.UseVisualStyleBackColor = true;
            // 
            // radioButtonWalleye
            // 
            this.radioButtonWalleye.AutoSize = true;
            this.radioButtonWalleye.Location = new System.Drawing.Point(37, 123);
            this.radioButtonWalleye.Name = "radioButtonWalleye";
            this.radioButtonWalleye.Size = new System.Drawing.Size(63, 17);
            this.radioButtonWalleye.TabIndex = 4;
            this.radioButtonWalleye.TabStop = true;
            this.radioButtonWalleye.Text = "Walleye";
            this.radioButtonWalleye.UseVisualStyleBackColor = true;
            // 
            // FormSeeFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 309);
            this.Controls.Add(this.groupBoxChooseFishToSee);
            this.Controls.Add(this.buttonSeeFish);
            this.Name = "FormSeeFish";
            this.Text = "CSC470 - P2";
            this.groupBoxChooseFishToSee.ResumeLayout(false);
            this.groupBoxChooseFishToSee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSeeFish;
        private System.Windows.Forms.GroupBox groupBoxChooseFishToSee;
        private System.Windows.Forms.RadioButton radioButtonWalleye;
        private System.Windows.Forms.RadioButton radioButtonPerch;
        private System.Windows.Forms.RadioButton radioButtonCrappie;
    }
}

