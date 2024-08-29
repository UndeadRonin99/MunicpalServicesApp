using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicpalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        private List<Issue> issuesList = new List<Issue>();
        public string selectedFilePath;
        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            // Open a file dialog to attach media files
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Handle the file path, e.g., store it in a variable or display it in a label
                    selectedFilePath = openFileDialog.FileName;
                    progressBarMedia.Value = 100; // Simulating progress completion
                    MessageBox.Show("File attached: " + selectedFilePath);
                    // Enable the "View Uploaded Image" button
                    btnViewMedia.Visible = true;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please fill in all fields before submitting.");
                return;
            }

            // Create a new issue object
            Issue newIssue = new Issue(
                txtLocation.Text,
                cmbCategory.Text,
                rtbDescription.Text,
                selectedFilePath // Can be null if no file is attached
            );

            // Add the new issue to the list
            issuesList.Add(newIssue);

            // Confirm to the user that the issue has been submitted
            MessageBox.Show("Issue reported successfully!");

            // Clear the form for new input
            ClearForm();
        }
        private void ClearForm()
        {
            txtLocation.Text = string.Empty;
            cmbCategory.SelectedIndex = -1; // Reset dropdown selection
            rtbDescription.Clear();
            selectedFilePath = null; // Clear the attached file path
            pictureBoxUploadedImage.Image = null; // Clear the image from PictureBox
            pictureBoxUploadedImage.Visible = false; // Hide the PictureBox again
            btnViewMedia.Visible = false; // Disable the "View Uploaded Image" button
            progressBarMedia.Value = 0; // Reset progress bar if used
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to the main menu
            Form1 mainForm = new Form1(); // Make sure to replace with your main form name
            mainForm.Show();
            this.Close(); // Close the current form
        }

        private void btnViewMedia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                // Display the selected image in the PictureBox
                pictureBoxUploadedImage.Image = new System.Drawing.Bitmap(selectedFilePath);
                pictureBoxUploadedImage.Visible = true; // Make PictureBox visible
            }
            else
            {
                MessageBox.Show("No image selected to display.");
            }
        }
    }
}
