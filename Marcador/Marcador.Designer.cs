using System.Drawing;
namespace Marcador
{
    partial class Marcador
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
            this.ScoreBoardPanel = new System.Windows.Forms.Panel();
            this.ScoreBoardSplitContainer = new System.Windows.Forms.SplitContainer();
            this.Team2Label = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Team1Label = new System.Windows.Forms.Label();
            this.Team2Split = new System.Windows.Forms.Splitter();
            this.ScoreSplit = new System.Windows.Forms.Splitter();
            this.Team1Split = new System.Windows.Forms.Splitter();
            this.TimeOutLabel = new System.Windows.Forms.Label();
            this.CronoLabel = new System.Windows.Forms.Label();
            this.HalfLabel = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ExpulsionDataView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreBoardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoardSplitContainer)).BeginInit();
            this.ScoreBoardSplitContainer.Panel1.SuspendLayout();
            this.ScoreBoardSplitContainer.Panel2.SuspendLayout();
            this.ScoreBoardSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpulsionDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreBoardPanel
            // 
            this.ScoreBoardPanel.Controls.Add(this.ScoreBoardSplitContainer);
            this.ScoreBoardPanel.Location = new System.Drawing.Point(38, 27);
            this.ScoreBoardPanel.Name = "ScoreBoardPanel";
            this.ScoreBoardPanel.Size = new System.Drawing.Size(279, 78);
            this.ScoreBoardPanel.TabIndex = 0;
            // 
            // ScoreBoardSplitContainer
            // 
            this.ScoreBoardSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreBoardSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ScoreBoardSplitContainer.Name = "ScoreBoardSplitContainer";
            this.ScoreBoardSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScoreBoardSplitContainer.Panel1
            // 
            this.ScoreBoardSplitContainer.Panel1.Controls.Add(this.Team2Label);
            this.ScoreBoardSplitContainer.Panel1.Controls.Add(this.ScoreLabel);
            this.ScoreBoardSplitContainer.Panel1.Controls.Add(this.Team1Label);
            this.ScoreBoardSplitContainer.Panel1.Controls.Add(this.Team2Split);
            this.ScoreBoardSplitContainer.Panel1.Controls.Add(this.ScoreSplit);
            this.ScoreBoardSplitContainer.Panel1.Controls.Add(this.Team1Split);
            // 
            // ScoreBoardSplitContainer.Panel2
            // 
            this.ScoreBoardSplitContainer.Panel2.Controls.Add(this.TimeOutLabel);
            this.ScoreBoardSplitContainer.Panel2.Controls.Add(this.CronoLabel);
            this.ScoreBoardSplitContainer.Panel2.Controls.Add(this.HalfLabel);
            this.ScoreBoardSplitContainer.Panel2.Controls.Add(this.splitter3);
            this.ScoreBoardSplitContainer.Panel2.Controls.Add(this.splitter2);
            this.ScoreBoardSplitContainer.Panel2.Controls.Add(this.splitter1);
            this.ScoreBoardSplitContainer.Size = new System.Drawing.Size(279, 78);
            this.ScoreBoardSplitContainer.SplitterDistance = 46;
            this.ScoreBoardSplitContainer.TabIndex = 0;
            // 
            // Team2Label
            // 
            this.Team2Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.Team2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Label.Location = new System.Drawing.Point(192, 9);
            this.Team2Label.Name = "Team2Label";
            this.Team2Label.Size = new System.Drawing.Size(84, 29);
            this.Team2Label.TabIndex = 5;
            this.Team2Label.Text = "TEAM2";
            this.Team2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.Color.Black;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(102, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(78, 29);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "0 - 0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Team1Label
            // 
            this.Team1Label.BackColor = System.Drawing.Color.White;
            this.Team1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1Label.Location = new System.Drawing.Point(3, 9);
            this.Team1Label.Name = "Team1Label";
            this.Team1Label.Size = new System.Drawing.Size(87, 29);
            this.Team1Label.TabIndex = 3;
            this.Team1Label.Text = "TEAM1";
            this.Team1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Team2Split
            // 
            this.Team2Split.BackColor = System.Drawing.Color.RoyalBlue;
            this.Team2Split.Location = new System.Drawing.Point(186, 0);
            this.Team2Split.Name = "Team2Split";
            this.Team2Split.Size = new System.Drawing.Size(98, 46);
            this.Team2Split.TabIndex = 2;
            this.Team2Split.TabStop = false;
            // 
            // ScoreSplit
            // 
            this.ScoreSplit.BackColor = System.Drawing.Color.Black;
            this.ScoreSplit.Location = new System.Drawing.Point(96, 0);
            this.ScoreSplit.Name = "ScoreSplit";
            this.ScoreSplit.Size = new System.Drawing.Size(90, 46);
            this.ScoreSplit.TabIndex = 1;
            this.ScoreSplit.TabStop = false;
            // 
            // Team1Split
            // 
            this.Team1Split.BackColor = System.Drawing.Color.White;
            this.Team1Split.Location = new System.Drawing.Point(0, 0);
            this.Team1Split.Name = "Team1Split";
            this.Team1Split.Size = new System.Drawing.Size(96, 46);
            this.Team1Split.TabIndex = 0;
            this.Team1Split.TabStop = false;
            // 
            // TimeOutLabel
            // 
            this.TimeOutLabel.BackColor = System.Drawing.Color.LightGray;
            this.TimeOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutLabel.Location = new System.Drawing.Point(193, 4);
            this.TimeOutLabel.Name = "TimeOutLabel";
            this.TimeOutLabel.Size = new System.Drawing.Size(83, 22);
            this.TimeOutLabel.TabIndex = 5;
            this.TimeOutLabel.Text = "0:00";
            this.TimeOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeOutLabel.Visible = false;
            // 
            // CronoLabel
            // 
            this.CronoLabel.BackColor = System.Drawing.Color.Black;
            this.CronoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CronoLabel.ForeColor = System.Drawing.Color.White;
            this.CronoLabel.Location = new System.Drawing.Point(102, 5);
            this.CronoLabel.Name = "CronoLabel";
            this.CronoLabel.Size = new System.Drawing.Size(78, 21);
            this.CronoLabel.TabIndex = 4;
            this.CronoLabel.Text = "00:00";
            this.CronoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HalfLabel
            // 
            this.HalfLabel.BackColor = System.Drawing.Color.LightGray;
            this.HalfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalfLabel.Location = new System.Drawing.Point(7, 4);
            this.HalfLabel.Name = "HalfLabel";
            this.HalfLabel.Size = new System.Drawing.Size(83, 22);
            this.HalfLabel.TabIndex = 3;
            this.HalfLabel.Text = "1st";
            this.HalfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(186, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(90, 28);
            this.splitter3.TabIndex = 2;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(96, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(90, 28);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(96, 28);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // ExpulsionDataView
            // 
            this.ExpulsionDataView.AllowUserToAddRows = false;
            this.ExpulsionDataView.AllowUserToDeleteRows = false;
            this.ExpulsionDataView.AllowUserToResizeColumns = false;
            this.ExpulsionDataView.AllowUserToResizeRows = false;
            this.ExpulsionDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpulsionDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ExpulsionDataView.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.ExpulsionDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpulsionDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ExpulsionDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ExpulsionDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpulsionDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Time,
            this.TotalT,
            this.PlayerName,
            this.Team});
            this.ExpulsionDataView.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExpulsionDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ExpulsionDataView.Enabled = false;
            this.ExpulsionDataView.EnableHeadersVisualStyles = false;
            this.ExpulsionDataView.Location = new System.Drawing.Point(706, 0);
            this.ExpulsionDataView.MultiSelect = false;
            this.ExpulsionDataView.Name = "ExpulsionDataView";
            this.ExpulsionDataView.ReadOnly = true;
            this.ExpulsionDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ExpulsionDataView.RowHeadersVisible = false;
            this.ExpulsionDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpulsionDataView.ShowEditingIcon = false;
            this.ExpulsionDataView.Size = new System.Drawing.Size(288, 362);
            this.ExpulsionDataView.TabIndex = 1;
            this.ExpulsionDataView.Visible = false;
            this.ExpulsionDataView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ExpulsionDataView_RowsAdded);
            this.ExpulsionDataView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ExpulsionDataView_RowsRemoved);
            this.ExpulsionDataView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.ExpulsionDataView_RowStateChanged);
            // 
            // Number
            // 
            this.Number.FillWeight = 39.2524F;
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.FillWeight = 79.24935F;
            this.Time.HeaderText = "Eleapsed";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // TotalT
            // 
            this.TotalT.FillWeight = 81.21828F;
            this.TotalT.HeaderText = "TotalT";
            this.TotalT.Name = "TotalT";
            this.TotalT.ReadOnly = true;
            // 
            // PlayerName
            // 
            this.PlayerName.FillWeight = 200.28F;
            this.PlayerName.HeaderText = "Name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            this.Team.Visible = false;
            // 
            // Marcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(994, 362);
            this.ControlBox = false;
            this.Controls.Add(this.ExpulsionDataView);
            this.Controls.Add(this.ScoreBoardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Marcador";
            this.Text = "ScoreBoard";
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ScoreBoardPanel.ResumeLayout(false);
            this.ScoreBoardSplitContainer.Panel1.ResumeLayout(false);
            this.ScoreBoardSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoardSplitContainer)).EndInit();
            this.ScoreBoardSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpulsionDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ScoreBoardPanel;
        private System.Windows.Forms.SplitContainer ScoreBoardSplitContainer;
        public System.Windows.Forms.Label Team2Label;
        public System.Windows.Forms.Label ScoreLabel;
        public System.Windows.Forms.Label Team1Label;
        private System.Windows.Forms.Splitter Team2Split;
        private System.Windows.Forms.Splitter ScoreSplit;
        private System.Windows.Forms.Splitter Team1Split;
        public System.Windows.Forms.Label TimeOutLabel;
        public System.Windows.Forms.Label CronoLabel;
        public System.Windows.Forms.Label HalfLabel;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.DataGridView ExpulsionDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
    }
}

