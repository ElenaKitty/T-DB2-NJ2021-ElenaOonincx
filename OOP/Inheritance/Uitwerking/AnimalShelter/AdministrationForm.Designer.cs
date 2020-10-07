namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.chipBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.chipLbl = new System.Windows.Forms.Label();
            this.birthLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.birthBox = new System.Windows.Forms.DateTimePicker();
            this.habitsBox = new System.Windows.Forms.TextBox();
            this.walkBox = new System.Windows.Forms.DateTimePicker();
            this.walkLbl = new System.Windows.Forms.Label();
            this.habitsLbl = new System.Windows.Forms.Label();
            this.animalLbl = new System.Windows.Forms.Label();
            this.animalBox = new System.Windows.Forms.ListBox();
            this.reservedBox = new System.Windows.Forms.ListBox();
            this.reservedLbl = new System.Windows.Forms.Label();
            this.reserveButton = new System.Windows.Forms.Button();
            this.unreserveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 0;
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(139, 10);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(209, 10);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // chipBox
            // 
            this.chipBox.Location = new System.Drawing.Point(102, 60);
            this.chipBox.Name = "chipBox";
            this.chipBox.Size = new System.Drawing.Size(100, 20);
            this.chipBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(102, 112);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 5;
            // 
            // chipLbl
            // 
            this.chipLbl.AutoSize = true;
            this.chipLbl.Location = new System.Drawing.Point(32, 63);
            this.chipLbl.Name = "chipLbl";
            this.chipLbl.Size = new System.Drawing.Size(66, 13);
            this.chipLbl.TabIndex = 6;
            this.chipLbl.Text = "Chip number";
            // 
            // birthLbl
            // 
            this.birthLbl.AutoSize = true;
            this.birthLbl.Location = new System.Drawing.Point(32, 92);
            this.birthLbl.Name = "birthLbl";
            this.birthLbl.Size = new System.Drawing.Size(66, 13);
            this.birthLbl.TabIndex = 7;
            this.birthLbl.Text = "Date of Birth";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(65, 118);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 8;
            this.nameLbl.Text = "Name";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(46, 226);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(482, 89);
            this.outputBox.TabIndex = 9;
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(46, 207);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(37, 13);
            this.outputLbl.TabIndex = 10;
            this.outputLbl.Text = "output";
            // 
            // birthBox
            // 
            this.birthBox.Location = new System.Drawing.Point(102, 86);
            this.birthBox.Name = "birthBox";
            this.birthBox.Size = new System.Drawing.Size(200, 20);
            this.birthBox.TabIndex = 4;
            // 
            // habitsBox
            // 
            this.habitsBox.Location = new System.Drawing.Point(260, 184);
            this.habitsBox.Name = "habitsBox";
            this.habitsBox.Size = new System.Drawing.Size(100, 20);
            this.habitsBox.TabIndex = 11;
            // 
            // walkBox
            // 
            this.walkBox.Location = new System.Drawing.Point(12, 181);
            this.walkBox.Name = "walkBox";
            this.walkBox.Size = new System.Drawing.Size(200, 20);
            this.walkBox.TabIndex = 12;
            // 
            // walkLbl
            // 
            this.walkLbl.AutoSize = true;
            this.walkLbl.Location = new System.Drawing.Point(83, 165);
            this.walkLbl.Name = "walkLbl";
            this.walkLbl.Size = new System.Drawing.Size(73, 13);
            this.walkLbl.TabIndex = 13;
            this.walkLbl.Text = "Last walk dog";
            // 
            // habitsLbl
            // 
            this.habitsLbl.AutoSize = true;
            this.habitsLbl.Location = new System.Drawing.Point(270, 165);
            this.habitsLbl.Name = "habitsLbl";
            this.habitsLbl.Size = new System.Drawing.Size(75, 13);
            this.habitsLbl.TabIndex = 14;
            this.habitsLbl.Text = "Bad habits cat";
            // 
            // animalLbl
            // 
            this.animalLbl.AutoSize = true;
            this.animalLbl.Location = new System.Drawing.Point(486, 19);
            this.animalLbl.Name = "animalLbl";
            this.animalLbl.Size = new System.Drawing.Size(97, 13);
            this.animalLbl.TabIndex = 16;
            this.animalLbl.Text = "Registered Animals";
            // 
            // animalBox
            // 
            this.animalBox.FormattingEnabled = true;
            this.animalBox.Location = new System.Drawing.Point(489, 36);
            this.animalBox.Name = "animalBox";
            this.animalBox.Size = new System.Drawing.Size(97, 121);
            this.animalBox.TabIndex = 17;
            // 
            // reservedBox
            // 
            this.reservedBox.FormattingEnabled = true;
            this.reservedBox.Location = new System.Drawing.Point(386, 36);
            this.reservedBox.Name = "reservedBox";
            this.reservedBox.Size = new System.Drawing.Size(97, 121);
            this.reservedBox.TabIndex = 19;
            // 
            // reservedLbl
            // 
            this.reservedLbl.AutoSize = true;
            this.reservedLbl.Location = new System.Drawing.Point(383, 19);
            this.reservedLbl.Name = "reservedLbl";
            this.reservedLbl.Size = new System.Drawing.Size(92, 13);
            this.reservedLbl.TabIndex = 18;
            this.reservedLbl.Text = "Reserved Animals";
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(522, 160);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(64, 23);
            this.reserveButton.TabIndex = 20;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // unreserveButton
            // 
            this.unreserveButton.Location = new System.Drawing.Point(419, 163);
            this.unreserveButton.Name = "unreserveButton";
            this.unreserveButton.Size = new System.Drawing.Size(64, 23);
            this.unreserveButton.TabIndex = 21;
            this.unreserveButton.Text = "Unreserve";
            this.unreserveButton.UseVisualStyleBackColor = true;
            this.unreserveButton.Click += new System.EventHandler(this.unreserveButton_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 327);
            this.Controls.Add(this.unreserveButton);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.reservedBox);
            this.Controls.Add(this.reservedLbl);
            this.Controls.Add(this.animalBox);
            this.Controls.Add(this.animalLbl);
            this.Controls.Add(this.habitsLbl);
            this.Controls.Add(this.walkLbl);
            this.Controls.Add(this.walkBox);
            this.Controls.Add(this.habitsBox);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.birthLbl);
            this.Controls.Add(this.chipLbl);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.birthBox);
            this.Controls.Add(this.chipBox);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox chipBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label chipLbl;
        private System.Windows.Forms.Label birthLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.DateTimePicker birthBox;
        private System.Windows.Forms.TextBox habitsBox;
        private System.Windows.Forms.DateTimePicker walkBox;
        private System.Windows.Forms.Label walkLbl;
        private System.Windows.Forms.Label habitsLbl;
        private System.Windows.Forms.Label animalLbl;
        private System.Windows.Forms.ListBox animalBox;
        private System.Windows.Forms.ListBox reservedBox;
        private System.Windows.Forms.Label reservedLbl;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button unreserveButton;
    }
}

