using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class EpicSpiesAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaintainScrollPositionOnPostBack = true;

            if (!Page.IsPostBack)
            {
                previousEndCalendar.SelectedDate = DateTime.Today;
                newCalendar.SelectedDate = DateTime.Today.AddDays(14);
                newCalendar.VisibleDate = DateTime.Today.AddDays(14);
                newEndCalendar.SelectedDate = DateTime.Today.AddDays(21);
                newEndCalendar.VisibleDate = DateTime.Today.AddDays(21);
            }       
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {

            TimeSpan newAssignmentDuration = newEndCalendar.SelectedDate.Subtract(newCalendar.SelectedDate);
            TimeSpan restBetweenDuration = newCalendar.SelectedDate.Subtract(previousEndCalendar.SelectedDate);

            detailsLabel.Text = String.Format("Assignment of {0} to assignment Project: {1} is authorized. Budget Total: {2:C}",
            codeNameTextBox.Text, assignmentNameTextBox.Text, newAssignmentDuration.Days * 500);

            if (restBetweenDuration.Days < 14)
                detailsLabel.Text = "Error:  Must allow at least two weeks between previous assignment and new assignment.";
                newCalendar.SelectedDate = previousEndCalendar.SelectedDate.AddDays(14);
                newCalendar.VisibleDate = previousEndCalendar.SelectedDate.AddDays(14);

            if (codeNameTextBox.Text.Length < 1 && assignmentNameTextBox.Text.Length < 1
                || codeNameTextBox.Text.Length < 1
                || assignmentNameTextBox.Text.Length < 1)
                detailsLabel.Text = "Please make sure that you have entered a Code Name and Assignment Name.";

            if (newAssignmentDuration.Days > 21)
                detailsLabel.Text = String.Format("Assignment of {0} to assignment Project: {1} is authorized. Budget Total: {2:C}",
                codeNameTextBox.Text, assignmentNameTextBox.Text, (newAssignmentDuration.Days * 500) + 1000);

        }
    }
}