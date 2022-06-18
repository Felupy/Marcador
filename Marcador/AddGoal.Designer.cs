namespace Marcador
{
    partial class AddGoal
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
            this.HidePlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GoalLabel = new System.Windows.Forms.Label();
            this.GoalPlayerComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HidePlayerCheckBox
            // 
            this.HidePlayerCheckBox.AutoSize = true;
            this.HidePlayerCheckBox.Location = new System.Drawing.Point(68, 105);
            this.HidePlayerCheckBox.Name = "HidePlayerCheckBox";
            this.HidePlayerCheckBox.Size = new System.Drawing.Size(79, 17);
            this.HidePlayerCheckBox.TabIndex = 0;
            this.HidePlayerCheckBox.Text = "Hide player";
            this.HidePlayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(68, 128);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player: ";
            // 
            // GoalLabel
            // 
            this.GoalLabel.AutoSize = true;
            this.GoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalLabel.Location = new System.Drawing.Point(63, 24);
            this.GoalLabel.Name = "GoalLabel";
            this.GoalLabel.Size = new System.Drawing.Size(26, 25);
            this.GoalLabel.TabIndex = 4;
            this.GoalLabel.Text = "\"\"";
            // 
            // GoalPlayerComboBox
            // 
            this.GoalPlayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoalPlayerComboBox.FormattingEnabled = true;
            this.GoalPlayerComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.GoalPlayerComboBox.Location = new System.Drawing.Point(101, 55);
            this.GoalPlayerComboBox.Name = "GoalPlayerComboBox";
            this.GoalPlayerComboBox.Size = new System.Drawing.Size(57, 21);
            this.GoalPlayerComboBox.TabIndex = 5;
            // 
            // AddGoal
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 161);
            this.Controls.Add(this.GoalPlayerComboBox);
            this.Controls.Add(this.GoalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HidePlayerCheckBox);
            this.Name = "AddGoal";
            this.Text = "AddGoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox HidePlayerCheckBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GoalLabel;
        private System.Windows.Forms.ComboBox GoalPlayerComboBox;
    }
}