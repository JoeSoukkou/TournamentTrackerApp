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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> AvailableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> SelectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }
        /*private void CreateSampleData()
        {
            AvailableTeamMembers.Add(new PersonModel { FirstName = "Youcef", LastName = "Soukkou", EmailAddress="joe@gmail.com", CellphoneNumber="0541732095" });
            AvailableTeamMembers.Add(new PersonModel { FirstName = "Cris", LastName = "Gustavo", EmailAddress = "joe@gmail.com", CellphoneNumber = "0541732095" });

            SelectedTeamMembers.Add(new PersonModel { FirstName = "Jamie", LastName = "Smith", EmailAddress = "joe@gmail.com", CellphoneNumber = "0541732095" });

        }*/
        
        private void WireUpLists()
        {
            SelectTeamMemberDropdown.DataSource = null;
            SelectTeamMemberDropdown.DataSource = AvailableTeamMembers;
            SelectTeamMemberDropdown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;
            TeamMembersListBox.DataSource = SelectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
        }
        private void CreateNewMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel();
                person.FirstName = FirstNameValue.Text;
                person.LastName = LastNameValue.Text;
                person.EmailAddress = EmailValue.Text;
                person.CellphoneNumber = CellphoneValue.Text;

                person = GlobalConfig.Connection.CreatePerson(person);

                AvailableTeamMembers.Add(person);
                WireUpLists();
                /*Reset Fields Values After SAVING Data into the Database/TextFile */
                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                CellphoneValue.Text = "";
                
            }
            else
            {
                MessageBox.Show("Please Fill in All The Details !");
            }

        }
        private bool ValidateForm()
        {
            bool output = true;
            if (FirstNameValue.Text.Length == 0)
            {
                output = false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                output = false;
            }
            if (EmailValue.Text.Length == 0)
            {
                output = false;
            }
            if (CellphoneValue.Text.Length == 0)
            {
                output = false;
            }

            return output;


        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)SelectTeamMemberDropdown.SelectedItem;
            if (person != null)
            {
                AvailableTeamMembers.Remove(person);
                SelectedTeamMembers.Add(person);
                WireUpLists();
            }
            
        }

        private void RemoveSelectedMemberLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonModel person = (PersonModel)TeamMembersListBox.SelectedItem;
            if (person != null)
            {
                SelectedTeamMembers.Remove(person);
                AvailableTeamMembers.Add(person);
                WireUpLists();
            }
        }
    }
}
