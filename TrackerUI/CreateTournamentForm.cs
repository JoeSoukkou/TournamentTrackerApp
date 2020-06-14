using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form,IPrizeRequester, ITeamRequester
    {
        List<TeamModel> AvailableTeams = GlobalConfig.Connection.GetTeam_ALL();
        List<TeamModel> SelectedTeams = new List<TeamModel>();
        List<PrizeModel> SelectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        private void TeamOneScoreLabel_Click(object sender, EventArgs e)
        {

        }
        private void WireUpLists()
        {
            SelectTeamDropdown.DataSource = null;
            SelectTeamDropdown.DataSource = AvailableTeams;
            SelectTeamDropdown.DisplayMember = "TeamName";

            TournamentTeamsListbox.DataSource = null;
            TournamentTeamsListbox.DataSource = SelectedTeams;
            TournamentTeamsListbox.DisplayMember = "TeamName";

            PrizesListbox.DataSource = null;
            PrizesListbox.DataSource = SelectedPrizes;
            PrizesListbox.DisplayMember = "PlaceName";
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            
            TeamModel t = (TeamModel)SelectTeamDropdown.SelectedItem;
            if (t != null)
            {
                AvailableTeams.Remove(t);
                SelectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            //Call the Create Prize Form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
           
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get Back from the form a PrizeModel
            //Add the PrizeModel and put it to our list of selected Prizes
            SelectedPrizes.Add(model);
            WireUpLists();
        }

        private void CreateNewTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }
        public void TeamComplete(TeamModel model)
        {
            SelectedTeams.Add(model);
            WireUpLists();
        }

        private void RemoveSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            
            TeamModel Team = (TeamModel)TournamentTeamsListbox.SelectedItem;
            if (Team != null)
            {
                SelectedTeams.Remove(Team);
                AvailableTeams.Add(Team);
                WireUpLists();
            }
        }

        private void RemoveSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListbox.SelectedItem;
            if (p != null)
            {
                SelectedPrizes.Remove(p);
                
                WireUpLists();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            //Validate Data
            decimal fee = 0;
            bool FeeAcceptable = decimal.TryParse(EntryFeeValue.Text, out fee);
            
            if (!FeeAcceptable)
            {
                MessageBox.Show("Please Enter a Valid Fee !",
                    "Invalid Fee Value !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            // Create The Tournament Model 
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = TournamentNameValue.Text;
            tm.EntryFee = fee;
            tm.Prizes = SelectedPrizes;
            tm.EnteredTeams = SelectedTeams;

            // TODO - Wire The Matchups


            // Create Tournament Entry 
            // Create All of The Prizes Entries
            // Create All of The Teams Entries
            GlobalConfig.Connection.CreateTournament(tm);

                    }
    }
}
