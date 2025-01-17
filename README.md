Chat Application with ASP.NET Core 9, MS-SQL, and SignalR

This chat application is built using ASP.NET Core 9, MS-SQL, and SignalR. It supports both one-to-one messaging and group chats based on user roles.
Features

    One-to-One Chat: Send direct messages to another user by specifying their email.
    Group Chat: Send messages to a group based on user roles.

Installation Steps

Clone the Repository:

    Clone this repository to your local machine.

Restore NuGet Packages:

    Open the solution file (SignalRMVC.sln) in Visual Studio.
    Restore the required NuGet packages by right-clicking on the solution in Solution Explorer and selecting "Restore NuGet Packages."

Set Up the Database:

    The database backup file (db.backup) is included in the repository.
    Restore the database in SQL Server using the backup file.
    Update the connection string in appsettings.json to point to your local SQL Server instance.

"ConnectionStrings": {
  "AppDbContextConnection": "Server=YOUR_SERVER_NAME;Database=SignalRMVC;Trusted_Connection=True;MultipleActiveResultSets=True"
}

Apply Migrations (if needed):

    Open the Package Manager Console in Visual Studio and run the following command to apply any pending migrations:

    Update-Database

    Run the Application:
        Set the SignalRMVC project as the startup project.
        Press F5 or click on the "Start Debugging" button to run the application.

Testing the Application

    Login with Test Users:

        Open the application in two different browsers or in incognito/private mode.

        SignUp/Login with the following credentials:
            User 1:
                Email: user1@gmail.com
                Password: Test@123
            Manager:
                Email: manager1@gmail.com
                Password: Test@123

    Sending Messages:
        To send a one-to-one message, type the email address of the other user in the designated field and click "Send Message."
        To send a message to a group, leave the email field empty and click "Send Message to Group."

    Real-Time Messaging:
        Test the real-time chat functionality by sending messages between the two users.
        Observe the messages appearing instantly in both one-to-one and group chats.

Additional Notes

    The password for all test users is Test@123.
    Ensure that SignalR is properly configured and that both users can communicate without issues.
