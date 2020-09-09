namespace P2_Code
{
    partial class FormMain
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
            this.groupBoxChooseFishToSee = new System.Windows.Forms.GroupBox();
            this.radioButtonWalleye = new System.Windows.Forms.RadioButton();
            this.radioButtonPerch = new System.Windows.Forms.RadioButton();
            this.radioButtonCrappie = new System.Windows.Forms.RadioButton();
            this.buttonSeeFish = new System.Windows.Forms.Button();
            this.groupBoxChooseFishToSee.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChooseFishToSee
            // 
            this.groupBoxChooseFishToSee.Controls.Add(this.radioButtonWalleye);
            this.groupBoxChooseFishToSee.Controls.Add(this.radioButtonPerch);
            this.groupBoxChooseFishToSee.Controls.Add(this.radioButtonCrappie);
            this.groupBoxChooseFishToSee.Location = new System.Drawing.Point(65, 42);
            this.groupBoxChooseFishToSee.Name = "groupBoxChooseFishToSee";
            this.groupBoxChooseFishToSee.Size = new System.Drawing.Size(272, 178);
            this.groupBoxChooseFishToSee.TabIndex = 3;
            this.groupBoxChooseFishToSee.TabStop = false;
            this.groupBoxChooseFishToSee.Text = "Choose a fish to see";
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
            this.radioButtonWalleye.CheckedChanged += new System.EventHandler(this.radioButtonWalleye_CheckedChanged);
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
            this.radioButtonPerch.CheckedChanged += new System.EventHandler(this.radioButtonPerch_CheckedChanged);
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
            // buttonSeeFish
            // 
            this.buttonSeeFish.Location = new System.Drawing.Point(262, 261);
            this.buttonSeeFish.Name = "buttonSeeFish";
            this.buttonSeeFish.Size = new System.Drawing.Size(75, 23);
            this.buttonSeeFish.TabIndex = 4;
            this.buttonSeeFish.Text = "See Fish";
            this.buttonSeeFish.UseVisualStyleBackColor = true;
            this.buttonSeeFish.Click += new System.EventHandler(this.buttonSeeFish_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 334);
            this.Controls.Add(this.buttonSeeFish);
            this.Controls.Add(this.groupBoxChooseFishToSee);
            this.Name = "FormMain";
            this.Text = "CSC470 - P2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxChooseFishToSee.ResumeLayout(false);
            this.groupBoxChooseFishToSee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChooseFishToSee;
        private System.Windows.Forms.RadioButton radioButtonWalleye;
        private System.Windows.Forms.RadioButton radioButtonPerch;
        private System.Windows.Forms.RadioButton radioButtonCrappie;
        private System.Windows.Forms.Button buttonSeeFish;
    }
}