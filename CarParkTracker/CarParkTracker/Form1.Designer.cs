namespace CarParkTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOpenFile = new Button();
            buttonDeletePlate = new Button();
            buttonEditPlate = new Button();
            buttonAddPlate = new Button();
            buttonSavePlate = new Button();
            buttonLinearSearch = new Button();
            buttonBinarySearch = new Button();
            buttonTagPlate = new Button();
            listBoxEnteringVehicles = new ListBox();
            listBoxExitingVehicles = new ListBox();
            textBoxRegoPlate = new TextBox();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(48, 115);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(94, 38);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Open File";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDeletePlate
            // 
            buttonDeletePlate.Location = new Point(48, 234);
            buttonDeletePlate.Name = "buttonDeletePlate";
            buttonDeletePlate.Size = new Size(94, 50);
            buttonDeletePlate.TabIndex = 1;
            buttonDeletePlate.Text = "Delete Plate";
            buttonDeletePlate.UseVisualStyleBackColor = true;
            buttonDeletePlate.Click += buttonDeletePlate_Click;
            // 
            // buttonEditPlate
            // 
            buttonEditPlate.Location = new Point(182, 174);
            buttonEditPlate.Name = "buttonEditPlate";
            buttonEditPlate.Size = new Size(94, 38);
            buttonEditPlate.TabIndex = 2;
            buttonEditPlate.Text = "Edit Plate";
            buttonEditPlate.UseVisualStyleBackColor = true;
            buttonEditPlate.Click += buttonEditPlate_Click;
            // 
            // buttonAddPlate
            // 
            buttonAddPlate.Location = new Point(182, 115);
            buttonAddPlate.Name = "buttonAddPlate";
            buttonAddPlate.Size = new Size(94, 38);
            buttonAddPlate.TabIndex = 3;
            buttonAddPlate.Text = "Add Plate";
            buttonAddPlate.UseVisualStyleBackColor = true;
            buttonAddPlate.Click += buttonAddPlate_Click;
            // 
            // buttonSavePlate
            // 
            buttonSavePlate.Location = new Point(48, 174);
            buttonSavePlate.Name = "buttonSavePlate";
            buttonSavePlate.Size = new Size(94, 38);
            buttonSavePlate.TabIndex = 4;
            buttonSavePlate.Text = "Save Plate";
            buttonSavePlate.UseVisualStyleBackColor = true;
            buttonSavePlate.Click += buttonSavePlate_Click;
            // 
            // buttonLinearSearch
            // 
            buttonLinearSearch.Location = new Point(48, 290);
            buttonLinearSearch.Name = "buttonLinearSearch";
            buttonLinearSearch.Size = new Size(94, 38);
            buttonLinearSearch.TabIndex = 5;
            buttonLinearSearch.Text = "Linear Search";
            buttonLinearSearch.UseVisualStyleBackColor = true;
            buttonLinearSearch.Click += buttonLinearSearch_Click;
            // 
            // buttonBinarySearch
            // 
            buttonBinarySearch.Location = new Point(182, 234);
            buttonBinarySearch.Name = "buttonBinarySearch";
            buttonBinarySearch.Size = new Size(94, 38);
            buttonBinarySearch.TabIndex = 6;
            buttonBinarySearch.Text = "Binary Search";
            buttonBinarySearch.UseVisualStyleBackColor = true;
            buttonBinarySearch.Click += buttonBinarySearch_Click;
            // 
            // buttonTagPlate
            // 
            buttonTagPlate.Location = new Point(182, 290);
            buttonTagPlate.Name = "buttonTagPlate";
            buttonTagPlate.Size = new Size(94, 38);
            buttonTagPlate.TabIndex = 7;
            buttonTagPlate.Text = "Tag Plate";
            buttonTagPlate.UseVisualStyleBackColor = true;
            buttonTagPlate.Click += buttonTagPlate_Click;
            // 
            // listBoxEnteringVehicles
            // 
            listBoxEnteringVehicles.FormattingEnabled = true;
            listBoxEnteringVehicles.Location = new Point(313, 84);
            listBoxEnteringVehicles.Name = "listBoxEnteringVehicles";
            listBoxEnteringVehicles.Size = new Size(167, 244);
            listBoxEnteringVehicles.TabIndex = 8;
            // 
            // listBoxExitingVehicles
            // 
            listBoxExitingVehicles.FormattingEnabled = true;
            listBoxExitingVehicles.Location = new Point(515, 84);
            listBoxExitingVehicles.Name = "listBoxExitingVehicles";
            listBoxExitingVehicles.Size = new Size(167, 244);
            listBoxExitingVehicles.TabIndex = 9;
            // 
            // textBoxRegoPlate
            // 
            textBoxRegoPlate.Location = new Point(48, 77);
            textBoxRegoPlate.Name = "textBoxRegoPlate";
            textBoxRegoPlate.Size = new Size(170, 27);
            textBoxRegoPlate.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxRegoPlate);
            Controls.Add(listBoxExitingVehicles);
            Controls.Add(listBoxEnteringVehicles);
            Controls.Add(buttonTagPlate);
            Controls.Add(buttonBinarySearch);
            Controls.Add(buttonLinearSearch);
            Controls.Add(buttonSavePlate);
            Controls.Add(buttonAddPlate);
            Controls.Add(buttonEditPlate);
            Controls.Add(buttonDeletePlate);
            Controls.Add(buttonOpenFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenFile;
        private Button buttonDeletePlate;
        private Button buttonEditPlate;
        private Button buttonAddPlate;
        private Button buttonSavePlate;
        private Button buttonLinearSearch;
        private Button buttonBinarySearch;
        private Button buttonTagPlate;
        private ListBox listBoxEnteringVehicles;
        private ListBox listBoxExitingVehicles;
        private TextBox textBoxRegoPlate;
    }
}
