# FinanceTrackAPP

FinanceTrackAPP is a simple financial tracking application that helps you manage your finances and track how you use your money. With this application, you can easily monitor your spending and manage your overall financial situation.

## UI/UX Design

![Screenshot 2025-01-11 225914](https://github.com/user-attachments/assets/351e1f9a-0d29-4871-9dec-7689da7c8e7a) ![Screenshot 2025-01-11 225933](https://github.com/user-attachments/assets/3a49d129-7059-4759-97ae-f2f53cb66eb4)  
![Screenshot 2025-01-11 230011](https://github.com/user-attachments/assets/8a122511-0614-4f17-b2c8-a0a725563826)  
![Screenshot 2025-01-11 230029](https://github.com/user-attachments/assets/2437e81a-c4b2-4ee9-b883-41cef762a8f7)  
![Screenshot 2025-01-11 234740](https://github.com/user-attachments/assets/200075ae-8c88-46c0-a8bd-f37d4025fc43)

## Getting Started

### Build It Yourself

Requirements:
- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  
- [Visual Studio](https://visualstudio.microsoft.com/)

Steps:
1. Clone this repository:
   ```bash
   git clone https://github.com/Malik-124-UGUR/FinanceTrackAPP.git
   ```
2. Open the project solution file: `WinForms-Expense-Manager.sln`.
3. Set the build configuration to `Release`.
4. Build and run the application: `ctrl + F5`.

## Features

### Main Panel

This dashboard provides users with the necessary components to summarize and manage their financial situation. Users can:
- View labels showing their total money and total amount spent.
- Access a button to add or remove money.
- Redirect to a panel to add new expenses.
- Redirect to a panel to view, edit, filter, or delete all recorded expenses.

### Add / Remove Panel

This panel allows users to update their total funds. Users can:
- Use a **numericUpDown** input to enter the amount of money.
- Click an **Add** button to increase the entered amount, or a **Remove** button to decrease it.

### Spending Panel

This panel allows users to save information about their new expenditures in the system. Users can:
- Use a **numericUpDown** to enter the expenditure amount.
- Use a **dateTimePicker** to enter the time and date of the expenditure.
- Select a category for the expenditure using a **comboBox**.
- Click a **Select File** button to upload any related documents for the expenditure.
- View and manage uploaded files in a **dataGridView**.
- Use a **Remove** button to delete selected files from the dataGridView.
- Use an **Add** button to save the expenditure and apply the changes.

### All Spend Panel

In this panel, users can view the details of all added expenses and filter by year, month, or category. Users can:
- Filter by year using a **comboBox**.
- Filter by month using a **comboBox**.
- Filter by category using a **comboBox**.
- Click a **Filter** button to apply the filters, or a **Clear Filter** button to remove them.
- View detailed spending data with a set of labels.
- See a sequential view of the spending details in a **flowLayoutPanel**.

### File Panel

This panel provides users with easy access to all the expenditure documents they have added.

## Development Plans

1) **WPF Migration and XAML Based Design**   :warning: `not done` 
   - For a more advanced user interface and flexibility instead of WinForms, we plan to migrate to WPF (Windows Presentation Foundation) in the future. WPF uses a XAML-based design language and offers more advanced graphics, animations and styling features. This transition can significantly improve the user experience by providing a richer and more modern interface.

2) **Graphical Financial Visualization**   :warning: `not done` 
   - **Income-Expense Graphs**: Users should be able to see their income and expenses graphically.
   For example, visually tracking the balance of income and expenses with a bar chart or pie chart can help users quickly understand their financial situation.
   - **Time Based Tracking**: Adding a timeline that graphically visualizes users' monthly or annual spending can provide a clearer picture of spending habits.

3) **Automatic Categorization and Spend Analysis**   :warning: `not done` 
   - **Smart Categorization**: The app can automatically categorize new spending based on the user's previous spending.
   For example, if the user has made many expenses in the “restaurant” category, a new expense can be automatically assigned to this category.
   - **Spending Reports and Suggestions**: It can analyze users' spending habits and make suggestions to save money. For example, “Your restaurant
expenses have increased by 20% in the last 3 months, do you plan to reduce this expenditure?”

4) **Budget and Targets**   :warning: `not done` 
   - **Budget Management**: Users can create budgets for certain categories. For example, they can say “I have set a budget of 500 TL for food this month” and the app can alert the user as they get closer to          their spending limits.
   - **Creating Goals**: Users can set savings goals. For example, goals such as “I want to save 2000 TL for a vacation” can be added and the app can show how close the goal is.

5) **Data Synchronization and Backup**   :warning: `not done`  
   - **Cloud Synchronization**: It may be possible for users to store all their data on the cloud and access it on different devices or computers.
      In this way, users can use the application from different devices without losing their data.
   - **Data Backup**: Regular backups of expenditure information and attached files ensure that users can access historical data in case of data loss.

6) **User Friendly Design Enhancements**   :warning: `not done`
   - **Dark Mode**: Nowadays, many users prefer dark mode. Adding dark mode support to the app can improve the user experience.
   - **More Personalization Options**: Options can be added where users can change the theme of the app or personalize its appearance.

7) **Integrated Payment System**   :warning: `not done`
   - **Payment History Tracking**: In addition to their expenses, users can also track payment dates and payment methods (credit card, debit card, etc.). This enables better management of payment processes.
   - **Automatic Bank Integration**: The app can integrate with the user's bank account and expenses can be automatically transferred to the app. This saves the user time by reducing manual entries.

8) **Notifications and Reminders**   :warning: `not done` 
   - **Budget and Goal Alerts**: Users can receive app alerts when they are approaching a certain budget or are close to reaching their goals.
   - **Regular Spending Reminders**: Adding notifications for users to remind them of regular expenses (subscriptions, rents, etc.) ensures that users are not late with payment deadlines.

9) **Bulk Spending Arrangements and Analytics**   :warning: `not done`
   - **Bulk Expense Editing**: Users can edit multiple expenses at the same time. For example, operations such as changing the category or collectively updating expenses belonging to the same date range can be          done faster.
   - **Effect of Expenditures**: Users can see the impact of their expenses on their budgets or goals. For example, information such as “This expenditure moved you 5% closer to your goal” can be provided.

10) **Advanced Data Analytics**   :warning: `not done`
      - **Income and Expense Ratio**: Users can visually track how much they spend compared to their income. This ratio can help the user understand their financial health.
      - **Comparison Between Dates**: Users can compare their spending within a certain date range with other dates. For example, a comparison such as “Your spending increased by 10% in the last three months” can be provided.

11) **Cross-Platform Support**   :warning: `not done`
      - Currently, FinanceTrackAPP is built for Windows using **WinForms**. However, in the future, we plan to expand the platform compatibility to ensure that users can access their financial data seamlessly   across various devices. This will include:
      - **Web Application**: A responsive web version of FinanceTrackAPP that users can access through their browsers, providing the same functionality and user experience on any device with an internet connection.
      - **Mobile Applications (iOS and Android)**: To allow users to track their finances on-the-go, we aim to develop mobile applications for both iOS and Android. This will enable users to easily manage their finances from their smartphones, ensuring the app is available anytime, anywhere.
      - **MacOS Support**: In addition to Windows, a MacOS version of the app will be developed to cater to users who prefer Apple's ecosystem, providing seamless cross-platform integration.

11) **Cloud Integration and Data Sync**   :warning: `not done`
      - **Cloud Syncing**: To provide users with access to their financial data from any device, we plan to implement cloud syncing capabilities. Users will be able to access their updated data across different platforms (web, mobile, desktop) without the fear of data loss or discrepancies.
      - **Backup and Restore**: Cloud integration will also include automatic backups, ensuring that all data is safely stored and easily recoverable in case of accidental deletion or device failure.

12) **Multi-Language Support**   :warning: `not done`
      - As we expand the platform, we also plan to incorporate multi-language support, allowing users from different regions to use the app in their preferred language. This will make FinanceTrackAPP more accessible to a global audience.
