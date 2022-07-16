
namespace Marcador
{
    partial class LocalSB_Window
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VisitorName_Label = new System.Windows.Forms.Label();
            this.LocalScore_Label = new System.Windows.Forms.Label();
            this.VisitorScore_Label = new System.Windows.Forms.Label();
            this.Time_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LocalName_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44445F));
            this.tableLayoutPanel1.Controls.Add(this.VisitorName_Label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LocalScore_Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.VisitorScore_Label, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Time_Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LocalName_Label, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1252, 825);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // VisitorName_Label
            // 
            this.VisitorName_Label.AutoSize = true;
            this.VisitorName_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisitorName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitorName_Label.Location = new System.Drawing.Point(698, 0);
            this.VisitorName_Label.Name = "VisitorName_Label";
            this.VisitorName_Label.Size = new System.Drawing.Size(551, 82);
            this.VisitorName_Label.TabIndex = 5;
            this.VisitorName_Label.Text = "VISITOR";
            this.VisitorName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocalScore_Label
            // 
            this.LocalScore_Label.AutoSize = true;
            this.LocalScore_Label.BackColor = System.Drawing.SystemColors.Control;
            this.LocalScore_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalScore_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalScore_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocalScore_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalScore_Label.Location = new System.Drawing.Point(3, 247);
            this.LocalScore_Label.Name = "LocalScore_Label";
            this.LocalScore_Label.Size = new System.Drawing.Size(550, 578);
            this.LocalScore_Label.TabIndex = 0;
            this.LocalScore_Label.Text = "0";
            this.LocalScore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisitorScore_Label
            // 
            this.VisitorScore_Label.AutoSize = true;
            this.VisitorScore_Label.BackColor = System.Drawing.SystemColors.HotTrack;
            this.VisitorScore_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisitorScore_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisitorScore_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisitorScore_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitorScore_Label.Location = new System.Drawing.Point(698, 247);
            this.VisitorScore_Label.Name = "VisitorScore_Label";
            this.VisitorScore_Label.Size = new System.Drawing.Size(551, 578);
            this.VisitorScore_Label.TabIndex = 1;
            this.VisitorScore_Label.Text = "0";
            this.VisitorScore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Time_Label, 3);
            this.Time_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.Location = new System.Drawing.Point(3, 82);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(1246, 165);
            this.Time_Label.TabIndex = 2;
            this.Time_Label.Text = "00:00";
            this.Time_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 578);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocalName_Label
            // 
            this.LocalName_Label.AutoSize = true;
            this.LocalName_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalName_Label.Location = new System.Drawing.Point(3, 0);
            this.LocalName_Label.Name = "LocalName_Label";
            this.LocalName_Label.Size = new System.Drawing.Size(550, 82);
            this.LocalName_Label.TabIndex = 4;
            this.LocalName_Label.Text = "LOCAL";
            this.LocalName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocalSB_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 825);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "LocalSB_Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoreboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LocalScore_Label;
        public System.Windows.Forms.Label VisitorScore_Label;
        public System.Windows.Forms.Label Time_Label;
        public System.Windows.Forms.Label VisitorName_Label;
        public System.Windows.Forms.Label LocalName_Label;
    }
}