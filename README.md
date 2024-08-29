#Municipal Services Application
This application is a C# Windows Forms application designed to facilitate the reporting of issues by citizens to a municipality. Users can report issues, attach media files, and view attached files. The application currently supports basic functionalities, with plans for future enhancements.

##Table of Contents
Features
Requirements
Installation
Compiling the Application
Running the Application
Usage
Future Enhancements
Features

##Main Menu: Allows users to navigate to different functionalities (currently, only "Report Issues" is implemented).
Report Issues: Users can report an issue by providing a location, selecting a category, writing a description, and attaching media files.
View Uploaded Image: Users can view the image they have uploaded.
Save Issues: Reported issues are saved in a list and can be accessed or managed programmatically.
Requirements
Operating System: Windows 7 or higher.
Development Environment: Visual Studio 2019 or higher.
.NET Framework: .NET Framework 4.7.2 or higher.
Installation
Clone or Download the Repository:

Clone the repository using Git:
bash
Copy code
git clone https://github.com/yourusername/municipal-services-app.git
Or download the ZIP file from the repository and extract it to your local machine.
Open the Project in Visual Studio:

Launch Visual Studio.
Go to File > Open > Project/Solution.
Navigate to the project folder and select MunicipalServicesApp.sln.
Compiling the Application
Restore NuGet Packages:

If required, Visual Studio will prompt you to restore NuGet packages. Accept and restore any missing packages.
Build the Solution:

Go to Build > Build Solution or press Ctrl + Shift + B.
Ensure there are no build errors. If errors occur, review the error list and resolve any issues.
Running the Application
Run the Application:

Press F5 or go to Debug > Start Debugging to run the application in debug mode.
Alternatively, press Ctrl + F5 to run without debugging.
Stop the Application:

To stop the application, click the "Stop Debugging" button or close the application window.
Usage
Main Menu
Report Issues: The main functionality currently implemented.
Click "Report Issues" to open the ReportIssuesForm.
Report Issues Form
Enter Issue Details:

Location: Enter the location of the issue in the "Location" textbox.
Category: Select a category from the dropdown list (e.g., Sanitation, Roads, Utilities).
Description: Provide a detailed description of the issue in the "Description" RichTextBox.
Attach Media:

Click the "Attach Media" button to attach an image or document related to the issue. Supported formats include .jpg, .jpeg, and .png.
After attaching the file, a message will confirm the attachment, and the "View Uploaded Image" button will be enabled.
View Uploaded Image:

Click "View Uploaded Image" to preview the attached image in a PictureBox.
Submit Issue:

Click the "Submit" button to save the issue to the list.
The form will clear, and a confirmation message will appear.
Navigation:

Click "Back to Main Menu" to return to the main menu.
Future Enhancements
Local Events and Announcements: Feature to be implemented.
Service Request Status: Feature to be implemented.
Database Integration: To store issues persistently in a database.
User Authentication: To allow users to create accounts and view their reported issues.