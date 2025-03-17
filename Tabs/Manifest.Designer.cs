namespace KCD2.Tabs
{
    partial class Manifest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            labelName = new Label();
            labelModId = new Label();
            labelDescription = new Label();
            textBoxModId = new TextBox();
            textBoxDescription = new TextBox();
            labelAuthor = new Label();
            labelVersion = new Label();
            labelModifiesLevel = new Label();
            labelCreatedOn = new Label();
            textBoxAuthor = new TextBox();
            textBoxVersion = new TextBox();
            dateTimePickerCreatedOn = new DateTimePicker();
            checkBoxModifiesLevel = new CheckBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(98, 9);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(305, 23);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(9, 12);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelModId
            // 
            labelModId.AutoSize = true;
            labelModId.Location = new Point(9, 41);
            labelModId.Name = "labelModId";
            labelModId.Size = new Size(46, 15);
            labelModId.TabIndex = 2;
            labelModId.Text = "Mod ID";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(9, 70);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(67, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description";
            // 
            // textBoxModId
            // 
            textBoxModId.Location = new Point(98, 38);
            textBoxModId.Name = "textBoxModId";
            textBoxModId.Size = new Size(305, 23);
            textBoxModId.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(98, 67);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(305, 23);
            textBoxDescription.TabIndex = 5;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(9, 99);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(44, 15);
            labelAuthor.TabIndex = 6;
            labelAuthor.Text = "Author";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(9, 128);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(45, 15);
            labelVersion.TabIndex = 7;
            labelVersion.Text = "Version";
            // 
            // labelModifiesLevel
            // 
            labelModifiesLevel.AutoSize = true;
            labelModifiesLevel.Location = new Point(9, 186);
            labelModifiesLevel.Name = "labelModifiesLevel";
            labelModifiesLevel.Size = new Size(83, 15);
            labelModifiesLevel.TabIndex = 8;
            labelModifiesLevel.Text = "Modifies Level";
            // 
            // labelCreatedOn
            // 
            labelCreatedOn.AutoSize = true;
            labelCreatedOn.Location = new Point(9, 160);
            labelCreatedOn.Name = "labelCreatedOn";
            labelCreatedOn.Size = new Size(67, 15);
            labelCreatedOn.TabIndex = 9;
            labelCreatedOn.Text = "Created On";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(98, 96);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(305, 23);
            textBoxAuthor.TabIndex = 10;
            // 
            // textBoxVersion
            // 
            textBoxVersion.Location = new Point(98, 125);
            textBoxVersion.Name = "textBoxVersion";
            textBoxVersion.Size = new Size(305, 23);
            textBoxVersion.TabIndex = 11;
            // 
            // dateTimePickerCreatedOn
            // 
            dateTimePickerCreatedOn.Location = new Point(98, 154);
            dateTimePickerCreatedOn.Name = "dateTimePickerCreatedOn";
            dateTimePickerCreatedOn.Size = new Size(305, 23);
            dateTimePickerCreatedOn.TabIndex = 12;
            // 
            // checkBoxModifiesLevel
            // 
            checkBoxModifiesLevel.Location = new Point(98, 183);
            checkBoxModifiesLevel.Name = "checkBoxModifiesLevel";
            checkBoxModifiesLevel.Size = new Size(24, 23);
            checkBoxModifiesLevel.TabIndex = 13;
            checkBoxModifiesLevel.UseVisualStyleBackColor = true;
            // 
            // Manifest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBoxModifiesLevel);
            Controls.Add(dateTimePickerCreatedOn);
            Controls.Add(textBoxVersion);
            Controls.Add(textBoxAuthor);
            Controls.Add(labelCreatedOn);
            Controls.Add(labelModifiesLevel);
            Controls.Add(labelVersion);
            Controls.Add(labelAuthor);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxModId);
            Controls.Add(labelDescription);
            Controls.Add(labelModId);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Name = "Manifest";
            Padding = new Padding(6);
            Size = new Size(412, 312);
            Load += Manifest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label labelName;
        private Label labelModId;
        private Label labelDescription;
        private TextBox textBoxModId;
        private TextBox textBoxDescription;
        private Label labelAuthor;
        private Label labelVersion;
        private Label labelModifiesLevel;
        private Label labelCreatedOn;
        private TextBox textBoxAuthor;
        private TextBox textBoxVersion;
        private DateTimePicker dateTimePickerCreatedOn;
        private CheckBox checkBoxModifiesLevel;
    }
}
