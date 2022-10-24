
namespace RequestForm
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
            this.pokeGetButton = new System.Windows.Forms.Button();
            this.pokeNameTextBox = new System.Windows.Forms.TextBox();
            this.pokeNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pokeGetButton
            // 
            this.pokeGetButton.Location = new System.Drawing.Point(190, 275);
            this.pokeGetButton.Name = "pokeGetButton";
            this.pokeGetButton.Size = new System.Drawing.Size(159, 60);
            this.pokeGetButton.TabIndex = 0;
            this.pokeGetButton.Text = "Get Pokemon";
            this.pokeGetButton.UseVisualStyleBackColor = true;
            this.pokeGetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pokeNameTextBox
            // 
            this.pokeNameTextBox.Location = new System.Drawing.Point(219, 162);
            this.pokeNameTextBox.Name = "pokeNameTextBox";
            this.pokeNameTextBox.ReadOnly = true;
            this.pokeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.pokeNameTextBox.TabIndex = 1;
            this.pokeNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pokeNameLabel
            // 
            this.pokeNameLabel.AutoSize = true;
            this.pokeNameLabel.Location = new System.Drawing.Point(216, 127);
            this.pokeNameLabel.Name = "pokeNameLabel";
            this.pokeNameLabel.Size = new System.Drawing.Size(86, 13);
            this.pokeNameLabel.TabIndex = 2;
            this.pokeNameLabel.Text = "Pokemon Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.pokeNameLabel);
            this.Controls.Add(this.pokeNameTextBox);
            this.Controls.Add(this.pokeGetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pokeGetButton;
        private System.Windows.Forms.TextBox pokeNameTextBox;
        private System.Windows.Forms.Label pokeNameLabel;
    }
}

