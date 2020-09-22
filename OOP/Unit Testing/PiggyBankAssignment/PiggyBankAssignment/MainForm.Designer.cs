namespace PiggyBankAssignment
{
    partial class MainForm
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
            this.removeButton = new System.Windows.Forms.Button();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(146, 245);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(141, 55);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove it!";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsLabel.Location = new System.Drawing.Point(332, 82);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(57, 39);
            this.savingsLabel.TabIndex = 8;
            this.savingsLabel.Text = "<>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Savings: ";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(146, 184);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(141, 55);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save it!";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(302, 222);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(127, 34);
            this.amountTextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 382);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.savingsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.amountTextBox);
            this.Name = "MainForm";
            this.Text = "Piggy Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}

