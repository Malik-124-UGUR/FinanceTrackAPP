# FinanceTrackAPP
This project is a simple financial tracking application. Thanks to this application, you can manage your financial situation and see and track how you use your money.

## UI/UX Design

![Ekran görüntüsü 2025-01-11 225914](https://github.com/user-attachments/assets/351e1f9a-0d29-4871-9dec-7689da7c8e7a) ![Ekran görüntüsü 2025-01-11 225933](https://github.com/user-attachments/assets/3a49d129-7059-4759-97ae-f2f53cb66eb4)
![Ekran görüntüsü 2025-01-11 230011](https://github.com/user-attachments/assets/8a122511-0614-4f17-b2c8-a0a725563826)
![Ekran görüntüsü 2025-01-11 230029](https://github.com/user-attachments/assets/2437e81a-c4b2-4ee9-b883-41cef762a8f7)
![Ekran görüntüsü 2025-01-11 234740](https://github.com/user-attachments/assets/200075ae-8c88-46c0-a8bd-f37d4025fc43)

## Getting Started

### Build It Yourself

Requirements:
- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  
- [Visual Studio](https://visualstudio.microsoft.com/)

Steps:
1. Clone this repository:
   ```bash
   git clone https://github.com/Malik-124-UGUR/FinanceTrackAPP.git
3. Open the project solution file: `WinForms-Expense-Manager.sln`.
4. Set the build configuration to `Release`.
5. Build and run: `ctrl + F5`.

## Features
### Main Panel

This dashboard provides the user with the necessary components to summarize and manage their financial situation. User:

- Labels to see total money and total money spent
- Direction button to add or remove money
- A redirect button to add new spends
- A redirect button to view, edit, filter or delete all spends.

### Add / Remove Panel

This panel provides an interface for the user to update their total funds. User:

- A **numericUPDown** input tool for entering the amount of money
- An **Add** button to increase the amount entered
- A **Remove** button to reduce the amount entered

### Spending Panel
This pane allows the user to save information about new spends in their system. User:
- A **numericUPDown** input tool to enter the amount of expenditure
- A **dateTimePicker** to enter time data about when the expenditure was made
- A **comboBox** to select the category of the spend
- A **Select File** button to upload the documents, if any, related to the expenditure
- A **dataGridView** to see the information of the added files and perform operations on them
- A **Remove Button** to delete the selected files in the dataGridView
- An **Add** button to save the expenditure in the system and make changes
