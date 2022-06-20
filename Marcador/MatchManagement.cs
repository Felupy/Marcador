using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcador
{


    public partial class MatchManagement : Form
    {
        #region Variables

        private Marcador marcador;
        private bool marcadorShowed = false;
        private Stopwatch swTimeout = new Stopwatch();
        private System.Windows.Forms.Timer tTimeout = new System.Windows.Forms.Timer();
        private Stopwatch swClock = new Stopwatch();
        private System.Windows.Forms.Timer tClock = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer tExpulsion;
        private int Timeout = -1;
        private int LocalScore = 0;
        private int VisitorScore = 0;
        private bool isTimeoutRunning = false;
        private bool gameRunning = false;
        private int gameIdentifier = 0;
        private DataSet dbMatch = new DataSet("MatchDB");
        private System.Data.DataTable dtMatchs;
        private System.Data.DataTable dtTeams;
        private System.Data.DataTable dtPlayers;
        private DataView view;
        private string ExportsDir = ".\\Exports\\";
        private bool dataExported = true;
        private Dictionary<string, int> playerLocalGoalList = new Dictionary<string, int>();

        #endregion

        public MatchManagement()
        {
            InitializeComponent();

            marcador = new Marcador();

            this.HalfComboBox.SelectedIndex = 0;
            this.LocalExpulsionComboBox.SelectedIndex = 0;
            this.VisitorExpulsionComboBox.SelectedIndex = 0;
            this.TeamGenreComboBox.SelectedIndex = 0;

            //Create Directories
            Directory.CreateDirectory(ExportsDir);

            //Timers setup
            tExpulsion = new System.Windows.Forms.Timer();
            tExpulsion.Tick += t_TickExpulsion;
            tExpulsion.Interval = 1000; //1s
            tExpulsion.Start();
            tClock.Interval = 1000; //1s
            tClock.Tick += tClock_Tick;


            //Setup DB

            //PARTIDOS
            dtMatchs = new System.Data.DataTable("Matches");
            DataColumn[] keys = new DataColumn[1];

            //dt.Columns.Add("ID", typeof(int));
            DataColumn dc = new DataColumn("ID");
            dc.DataType = typeof(int);
            dc.AutoIncrement = true;
            keys[0] = dc;
            dtMatchs.Columns.Add(dc);
            dtMatchs.Columns.Add("Date", typeof(DateTime));
            dtMatchs.Columns.Add("Local", typeof(string));
            dtMatchs.Columns.Add("Score", typeof(string));
            dtMatchs.Columns.Add("Visitor", typeof(string));
            dtMatchs.Columns.Add("MainRef", typeof(string));
            dtMatchs.Columns.Add("Aq1Ref", typeof(string));
            dtMatchs.Columns.Add("Aq2Ref", typeof(string));
            dtMatchs.PrimaryKey = keys;
            dbMatch.Tables.Add(dtMatchs);

            // Create a DataView using the DataTable.
            view = new DataView(dtMatchs);
            // Set a DataGrid control's DataSource to the DataView.
            this.HistoryDataView.DataSource = view;

            //EQUIPOS
            dtTeams = new System.Data.DataTable("Teams");
            DataColumn[] keysT = new DataColumn[2];

            //dt.Columns.Add("ID", typeof(int));
            DataColumn dcT1 = new DataColumn("ID"); //Teams ID column
            dcT1.DataType = typeof(int);
            dcT1.AutoIncrement = true;
            keysT[0] = dcT1;
            dtTeams.Columns.Add(dcT1);
            DataColumn dcT2 = new DataColumn("Name"); //Teams Name column
            dcT2.DataType = typeof(string);
            keysT[1] = dcT2;
            dtTeams.Columns.Add(dcT2);
            dtTeams.Columns.Add("Country", typeof(string));
            dtTeams.Columns.Add("Players", typeof(int));
            dtTeams.Columns.Add("Genre", typeof(string));
            dtTeams.PrimaryKey = keysT;
            dbMatch.Tables.Add(dtTeams);
            dtTeams.RowChanged += DtTeams_RowChanged;
            dtTeams.RowDeleted += DtTeams_RowDeleted;
            // Create a DataView using the DataTable.
            view = new DataView(dtTeams);
            // Set a DataGrid control's DataSource to the DataView.
            this.TeamsDataView.DataSource = view;

            this.TeamListComboBox.DataSource = dtTeams;
            this.TeamListComboBox.ValueMember = "Name";
            this.TeamListComboBox.DisplayMember = "Name";

            //JUGADORES
            dtPlayers = new System.Data.DataTable("Players");
            DataColumn[] keysP = new DataColumn[2];

            //dt.Columns.Add("ID", typeof(int));
            DataColumn dcP1 = new DataColumn("ID"); //Teams ID column
            dcP1.DataType = typeof(int);
            dcP1.AutoIncrement = true;
            keysP[0] = dcP1;
            dtPlayers.Columns.Add(dcP1);
            DataColumn dcP2 = new DataColumn("Name"); //Teams Name column
            dcP2.DataType = typeof(string);
            keysP[1] = dcP2;
            dtPlayers.Columns.Add(dcP2);
            dtPlayers.Columns.Add("Number", typeof(int));
            dtPlayers.Columns.Add("Team", typeof(string));
            dtPlayers.Columns.Add("Goals", typeof(int));

            dtPlayers.PrimaryKey = keysP;
            dbMatch.Tables.Add(dtPlayers);

            //Drawing initial
            this.LocalNameComboBox.Visible = false;
            this.VisitorNameComboBox.Visible = false;


        }

        #region Timeout

        private void StartTimeoutButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (isTimeoutRunning)//One timeout already running
                    return;
                tTimeout.Interval = 1000; //1s
                tTimeout.Tick += t_Tick;
                marcador.TimeOutLabel.Visible = true;
                this.TimeoutLabel.Visible = true;
                Timeout = (int)this.TimeoutNum.Value;

                swClock.Stop();
                tTimeout.Start();
                swTimeout.Start();
                isTimeoutRunning = true;


            }
            catch (Exception ex)
            {
                if (marcador == null)
                    MessageBox.Show("Scoreboard not showing. Please show the scoreboard.", "Scoreboard error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void t_Tick(object sender, EventArgs e)
        {
            string timeout_str = swTimeout.Elapsed.ToString("mm\\:ss");
            marcador.TimeOutLabel.Text = timeout_str;
            this.TimeoutLabel.Text = timeout_str;

            if (swTimeout.Elapsed.Minutes >= Timeout)
            {
                swTimeout.Reset();
                tTimeout.Stop();
                Thread.Sleep(2000); //Hold for 2 seconds
                marcador.TimeOutLabel.Visible = false;
                marcador.TimeOutLabel.Text = "0";
                this.TimeoutLabel.Visible = false;
                this.TimeoutLabel.Text = "0";
                swClock.Start();
                isTimeoutRunning = false;
            }

        }

        #endregion Timeout

        #region Clock

        private void PlayButton_Click(object sender, EventArgs e)
        {
            gameRunning = true;
            swClock.Start();
            tClock.Start();
        }

        void tClock_Tick(object sender, EventArgs e)
        {
            string time_str = swClock.Elapsed.ToString("mm\\:ss");

            if (gameRunning)
            {
                marcador.CronoLabel.Text = time_str;
                this.CronoLabel.Text = time_str;
            }

        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            swClock.Stop();
            tClock.Stop();
            gameRunning = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            swClock.Reset();
            tClock.Stop();
            gameRunning = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            swClock.Restart();
            //This does not affect the current state of the game.
        }

        #endregion

        #region Scores

        private void LocalPlusButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //DataRow dr = dtTeams.Select("Name = " + this.LocalNameTextBox.Text)[0];
            //    //AddGoal ag = new AddGoal(teamPlayers);
            //    //if (ag.ShowDialog() != DialogResult.OK)
            //    //    return;
            //}
            //catch (Exception ex)
            //{
            //    string msg_format = string.Format("Failed when assigning the goal to the team({0}).\nDetails: {1}", this.LocalNameTextBox.Text, ex.Message);
            //    MessageBox.Show(msg_format, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}



            LocalScore++;
            this.LocalScoreLabel.Text = LocalScore.ToString();
            marcador.ScoreLabel.Text = LocalScore.ToString() + " - " + VisitorScore.ToString();
        }

        private void LocalLessButton_Click(object sender, EventArgs e)
        {
            if (LocalScore > 0)
            {
                LocalScore--;
                this.LocalScoreLabel.Text = LocalScore.ToString();
                marcador.ScoreLabel.Text = LocalScore.ToString() + " - " + VisitorScore.ToString();
            }

        }

        private void VisitorPlusButton_Click(object sender, EventArgs e)
        {
            VisitorScore++;
            this.VisitorScoreLabel.Text = VisitorScore.ToString();
            marcador.ScoreLabel.Text = LocalScore.ToString() + " - " + VisitorScore.ToString();
        }

        private void VisitorLessButton_Click(object sender, EventArgs e)
        {
            if (VisitorScore > 0)
            {
                VisitorScore--;
                this.VisitorScoreLabel.Text = VisitorScore.ToString();
                marcador.ScoreLabel.Text = LocalScore.ToString() + " - " + VisitorScore.ToString();
            }
        }

        #endregion

        #region KickOuts

        void t_TickExpulsion(object sender, EventArgs e)
        {
            int indx = 0;
            if (marcador.ExpulsionDataView.Rows.Count <= 0)
                return;
            try
            {
                foreach (Stopwatch elemSw in marcador.expulsionTimers)
                {
                    int minutes = elemSw.Elapsed.Minutes;
                    string time = elemSw.Elapsed.ToString("mm\\:ss");

                    //Update display on streaming window
                    DataGridViewRow row = marcador.ExpulsionDataView.Rows[indx];
                    row.Cells[1].Value = time; //update time left

                    //Update management window
                    int minTotal = Convert.ToInt32(row.Cells[2].Value.ToString().Split(':')[0]);
                    DataGridViewRow rowMangement = this.ExpulsionDataGridView.Rows[indx];
                    if (minutes >= minTotal) //remove row
                    {
                        //marcador.ExpulsionDataView.Rows.Remove(row);
                        this.ExpulsionDataGridView.Rows.Remove(rowMangement);
                        break;//row number goes down 1, so we have to skip the indx++
                    }

                    indx++;
                }
            }
            catch
            {
                return;
            }

        }

        private void AddLocalExpButton_Click(object sender, EventArgs e)
        {

            this.ExpulsionDataGridView.Rows.Add(this.LocalExpulsionComboBox.SelectedItem.ToString(), this.LocalExpTimeNum.Value.ToString(), "PLAYER" + this.LocalExpulsionComboBox.SelectedItem.ToString(), "LOCAL");

        }

        private void AddVisitorExpButton_Click(object sender, EventArgs e)
        {
            this.ExpulsionDataGridView.Rows.Add(this.VisitorExpulsionComboBox.SelectedItem.ToString(), this.VisitorExpTimeNum.Value.ToString(), "PLAYER" + this.VisitorExpulsionComboBox.SelectedItem.ToString(), "VISITOR");
        }

        private void ExpulsionDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            DataGridViewRow row = this.ExpulsionDataGridView.Rows[(int)(e.RowIndex)];
            string time = (Convert.ToUInt32(row.Cells[1].Value)).ToString("00") + ":00";
            marcador.ExpulsionDataView.Rows.Add(row.Cells[0].Value, 0, time, row.Cells[2].Value, (string)(row.Cells[3].Value));

        }

        private void ExpulsionDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            marcador.ExpulsionDataView.Rows.RemoveAt((int)(e.RowIndex));
        }

        #endregion

        #region SaveAndClose

        private void SaveGameButton_Click(object sender, EventArgs e)
        {
            if (gameRunning)
            {
                MessageBox.Show("Game is currently running. Stop it before saving.", "Game running!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gameIdentifier++;
            AddMatchToDataTable(dtMatchs);
            dataExported = false;

        }

        private void RestartGameButton_Click(object sender, EventArgs e)
        {
            if (gameRunning)
            {
                MessageBox.Show("Game is currently running. Stop it before restarting.", "Game running!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LocalScore = 0;
            VisitorScore = 0;
            this.VisitorScoreLabel.Text = "0";
            this.LocalScoreLabel.Text = "0";
            this.CronoLabel.Text = "00:00";
            this.LocalNameTextBox.Text = "";
            this.VisitorNameTextBox.Text = "";
            this.ExpulsionDataGridView.Rows.Clear();

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.InitialDirectory = Directory.GetCurrentDirectory() + ExportsDir;
            sf.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            sf.OverwritePrompt = false;

            string filepath;
            if (sf.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            filepath = sf.FileName;

            var excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Add(true);

            //if (File.Exists(filepath))
            //    File.Delete(filepath);

            AddExcelSheet(dtMatchs, workbook);


            workbook.SaveAs(filepath);
            CloseExcel(excel, workbook);


            MessageBox.Show("Games exported succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataExported = true;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filename = of.FileName;
            var excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Open(filename);
            try
            {
                ReadExcelSheet("Matches", workbook, dtMatchs);
                CloseExcel(excel, workbook);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing the data. Make sure the data has the correct format.\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseExcel(excel, workbook);
                return;
            }

            MessageBox.Show("Games succesfully imported.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataExported = false;

        }

        #endregion

        #region OtherButtonClicks

        #endregion

        #region UIEvents

        private void HalfComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.HalfComboBox.SelectedIndex == 0)
                marcador.HalfLabel.Text = "1st";
            else
                marcador.HalfLabel.Text = "2nd";
        }

        private void SHScoreButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!marcadorShowed)
            {
                marcador.Show();
                marcadorShowed = true;
            }
            else
            {
                marcador.Hide();
                marcadorShowed = false;
            }


        }

        private void HistoryDataView_RowsRemoved(object sender, DataGridViewRowCancelEventArgs e)
        {

            e.Cancel = MessageBox.Show("Do you really want to delete the selected row (ID = " + e.Row.Index + ")", "Confirm", MessageBoxButtons.OKCancel) != DialogResult.OK; ;

        }

        private void MatchManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataExported)
                e.Cancel = (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes);
            else
                e.Cancel = (MessageBox.Show("You didn't export the games.\nAre you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes);


        }

        private void LocalNameTextBox_TextChanged(object sender, EventArgs e)
        {
            marcador.Team1Label.Text = this.LocalNameTextBox.Text.ToUpper();
        }

        private void VisitorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            marcador.Team2Label.Text = this.VisitorNameTextBox.Text.ToUpper();
        }

        private void LocalNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string selectedName = cb.Text;
            this.LocalNameTextBox.Text = selectedName;
        }

        private void VisitorNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string selectedName = cb.Text;
            this.VisitorNameTextBox.Text = selectedName;
        }


        #endregion

        #region Teams

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            AddTeamToDataTable(dtTeams);
        }

        private void TeamsDataView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.TeamsDataView.Rows.Count <= 0)
                return;

            DataGridViewRow row = this.TeamsDataView.SelectedRows[0];

            DataView dv = dtPlayers.DefaultView;

            dv.RowFilter = string.Format("Team = '{0}({1})'", row.Cells[1].Value.ToString(), row.Cells[4].Value.ToString());
            // Set a DataGrid control's DataSource to the DataView.
            this.PlayerDataView.DataSource = dv;
            this.PlayerDataView.Update();

        }

        private void TeamListComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (((DataRowView)e.ListItem) != null)
            {
                string team = ((DataRowView)e.ListItem)["Name"].ToString();
                string genre = ((DataRowView)e.ListItem)["Genre"].ToString();
                e.Value = team + "(" + genre + ")";
            }
        }

        private void ExportTeamsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.InitialDirectory = Directory.GetCurrentDirectory() + ExportsDir;
            sf.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            sf.OverwritePrompt = false;
            string filepath;
            if (sf.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            filepath = sf.FileName;

            var excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Open(filepath);

            //if (File.Exists(filepath))
            //    File.Delete(filepath);

            AddExcelSheet(dtTeams, workbook);


            workbook.Save();
            CloseExcel(excel, workbook);


            MessageBox.Show("Teams exported succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataExported = true;
        }

        private void ImportTeamsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filename = of.FileName;
            var excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excel.Workbooks.Open(filename);
            try
            {
                ReadExcelSheet(dtTeams.TableName, workbook, dtTeams);
                CloseExcel(excel, workbook);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing the data. Make sure the data has the correct format.\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseExcel(excel, workbook);
                return;
            }

            MessageBox.Show("Teams succesfully imported.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataExported = false;
        }

        #endregion

        #region Players

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayerToDataTable(dtPlayers);
        }

        private void PlayerDataView_UserRowsRemoved(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow row = this.TeamsDataView.SelectedRows[0];
            row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) - 1;
        }

        #endregion

        #region DataEventChanged

        private void DtTeams_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            if (this.dtTeams.Rows.Count <= 0)
            {
                this.LocalNameComboBox.Visible = false;
                this.VisitorNameComboBox.Visible = false;
                this.LocalNameComboBox.Items.Clear();
                this.VisitorNameComboBox.Items.Clear();
            }
        }

        private void DtTeams_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (this.dtTeams.Rows.Count > 0)
            {
                this.LocalNameComboBox.Items.Clear();
                this.VisitorNameComboBox.Items.Clear();
                this.LocalNameComboBox.Items.AddRange(this.getTeamList().ToArray());
                this.VisitorNameComboBox.Items.AddRange(this.getTeamList().ToArray());
                this.LocalNameComboBox.Visible = true;
                this.VisitorNameComboBox.Visible = true;

            }

        }

        #endregion

        #region DataHandleMethods


        private List<string> getTeamList()
        {
            DataRowCollection drs = this.dtTeams.Rows;
            List<string> teams = new List<string>();
            foreach (DataRow row in drs)
            {
                teams.Add(row.ItemArray[1].ToString());
            }

            return teams;
        }

        #endregion

        #region OtherMethods

        private static void AddExcelSheet(System.Data.DataTable dt, Workbook wb)
        {
            Sheets sheets = wb.Sheets;
            Worksheet newSheet = sheets.Add();
            newSheet.Name = dt.TableName;

            int iCol = 0;
            foreach (DataColumn c in dt.Columns)
            {
                iCol++;
                newSheet.Cells[1, iCol] = c.ColumnName;
            }

            int iRow = 0;
            foreach (DataRow r in dt.Rows)
            {
                iRow++;
                // add each row's cell data...
                iCol = 0;
                foreach (DataColumn c in dt.Columns)
                {
                    iCol++;
                    newSheet.Cells[iRow + 1, iCol] = r[c.ColumnName];
                }
            }
            newSheet.Columns.AutoFit();
        }

        private static void ReadExcelSheet(string sheetName, Workbook wb, System.Data.DataTable dt)
        {

            dt.Clear();
            Sheets sheets = wb.Sheets;
            Worksheet sheet = sheets[sheetName];
            dt.TableName = sheetName;



            for (int iRow = 1; iRow < sheet.UsedRange.Rows.Count; iRow++)
            {
                // add each row's cell data...
                DataRow r = dt.NewRow();
                int iCol = 0;
                foreach (DataColumn c in dt.Columns)
                {
                    iCol++;
                    r[c.ColumnName] = sheet.Cells[iRow + 1, iCol].Text;
                }
                dt.Rows.Add(r);
            }



        }

        private static void CloseExcel(Microsoft.Office.Interop.Excel.Application excel, Workbook wb)
        {
            wb.Close();
            excel.Quit();
            //find excel process and close
            Process[] localByName = Process.GetProcessesByName("EXCEL");
            foreach (Process p in localByName)
                p.Kill();
        }

        private void AddMatchToDataTable(System.Data.DataTable dt)
        {
            //add to DB
            DataRow dr = dt.NewRow();
            //dr["ID"] = gameIdentifier; //AutoIncrement!
            dr["Date"] = DateTime.Now;
            dr["Local"] = marcador.Team1Label.Text;
            dr["Score"] = marcador.ScoreLabel.Text;
            dr["Visitor"] = marcador.Team2Label.Text;
            dr["MainRef"] = this.MainRefTextBox.Text;
            dr["Aq1Ref"] = this.Aq1RefTextBox.Text;
            dr["Aq2Ref"] = this.Aq2RefTextBox.Text;

            dt.Rows.Add(dr);
        }

        private void AddTeamToDataTable(System.Data.DataTable dt)
        {
            try
            {
                //Check isn't already added

                foreach (DataRow r in dt.Rows)
                {
                    if ((r["Name"].ToString() == this.TeamNameTextBox.Text) && (r["Genre"].ToString() == this.TeamGenreComboBox.SelectedItem.ToString()))
                        throw new TeamException("Name(" + this.TeamGenreComboBox.SelectedItem.ToString() + ")");
                    if ((r["Country"].ToString() == this.CountryTextBox.Text) && (r["Genre"].ToString() == this.TeamGenreComboBox.SelectedItem.ToString()))
                        throw new TeamException("Country(" + this.TeamGenreComboBox.SelectedItem.ToString() + ")");
                }


                //add to DB
                DataRow dr = dt.NewRow();
                //dr["ID"] = gameIdentifier; //AutoIncrement!
                dr["Name"] = this.TeamNameTextBox.Text;
                dr["Country"] = this.CountryTextBox.Text;
                dr["Players"] = 0;
                dr["Genre"] = this.TeamGenreComboBox.SelectedItem.ToString();
                dt.Rows.Add(dr);
            }
            catch (TeamException ex)
            {
                MessageBox.Show("That Team " + ex.Message + " already exist. Check the Team fields.", "Duplicate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding the team.\nDeatils: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddPlayerToDataTable(System.Data.DataTable dt)
        {
            try
            {
                string teamItem = this.TeamListComboBox.Text;
                string teamName = teamItem.Split('(')[0];
                string teamGen = teamItem.Split('(')[1].Replace(")", "");
                //Check isn't already added
                DataRow[] resultTeam = dtTeams.Select("Name = '" + teamName + "' AND Genre = '" + teamGen + "'");
                DataRow[] result = dt.Select("Team = '" + teamItem + "'");

                if (result.Length != 0)
                {
                    foreach (DataRow r in result)
                    {
                        if (r["Name"].ToString() == this.PlayerNameTexBox.Text)
                            throw new PlayerException("Name");
                        if (Convert.ToInt32(r["Number"]) == this.PlayerNumNumBox.Value)
                            throw new PlayerException("Number");
                    }


                }

                //add to DB
                DataRow dr = dt.NewRow();
                //dr["ID"] = gameIdentifier; //AutoIncrement!
                dr["Name"] = this.PlayerNameTexBox.Text;
                dr["Number"] = this.PlayerNumNumBox.Value;
                dr["Team"] = teamItem;
                dr["Goals"] = 0;

                dt.Rows.Add(dr);

                //Update number of player in team
                if (resultTeam.Length > 0)
                {
                    resultTeam[0]["Players"] = Convert.ToInt32(resultTeam[0]["Players"]) + 1;
                }

            }
            catch (PlayerException ex)
            {
                MessageBox.Show("That Player " + ex.Message + " already exist. Check the Player fields.", "Duplicate!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding the player.\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        #endregion

    }

}
