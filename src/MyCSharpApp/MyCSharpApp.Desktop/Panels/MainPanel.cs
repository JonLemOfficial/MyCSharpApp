using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

using MyCSharpApp.Desktop.Lib;
using MyCSharpApp.Desktop.Components;
using MyCSharpApp.Desktop.Windows;
using MyCSharpApp.Desktop.Controllers;
using MyCSharpApp.Desktop.Models;

namespace MyCSharpApp.Desktop.Panels
{
    public partial class MainPanel : DockContent
    {
        // Controller
        private MainController Controller;

        public MainPanel()
        {
            this.Controller = new MainController();
            this.InitializeComponent();
        }

        #region Methods and functions associated to window events and others

        private void CallDllFunction(Action<double> Callback)
        {
            double a = 3, b = 7, result = LibExt.addition(a, b);
            Callback(result);
        }

        private void StylizeDataGrids()
        {
            this.SetDataSetsStructs();
            this.GetDataGridsSources();
            this.FormatUsersDataGrid();
            this.FormatProductsDataGrid();
            // this.AddUsersUsersDataExampleData();
        }

        private void FormatUsersDataGrid()
        {
            for (int i = 0; i < this.UsersDataGrid.Columns.Count; i++)
            {
                this.UsersDataGrid.Columns[i].Visible = false;
                this.UsersDataGrid.Columns[i].ReadOnly = true;
                this.UsersDataGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //DataGridViewCalendarColumn UsersDataGridCalendarCol = new DataGridViewCalendarColumn(DateTime.Now, DateTime.Today.AddYears(-120), DateTime.Today);
            //UsersDataGridCalendarCol.Name = "birthdate";
            //UsersDataGridCalendarCol.HeaderText = "Birthdate";
            ////Cbo.Items.Add("Activate");
            ////Cbo.Items.Add("Deactivate");
            //UsersDataGridCalendarCol.DefaultCellStyle.BackColor = Color.White;
            //UsersDataGridCalendarCol.DefaultCellStyle.ForeColor = Color.Black;
            //this.UsersDataGrid.Columns.Add(UsersDataGridCalendarCol);

            //DataGridViewTimeColumn UsersDataGridTimeCol = new DataGridViewTimeColumn();
            //UsersDataGridTimeCol.Name = "time";
            //UsersDataGridTimeCol.HeaderText = "Time";
            ////Cbo.Items.Add("Activate");
            ////Cbo.Items.Add("Deactivate");
            //UsersDataGridTimeCol.DefaultCellStyle.BackColor = Color.White;
            //UsersDataGridTimeCol.DefaultCellStyle.ForeColor = Color.Black;
            //this.UsersDataGrid.Columns.Add(UsersDataGridTimeCol);

            //DataGridViewNumericColumn UsersDataGridNumericCol = new DataGridViewNumericColumn();
            //UsersDataGridNumericCol.Name = "age";
            //UsersDataGridNumericCol.HeaderText = "Age";
            ////Cbo.Items.Add("Activate");
            ////Cbo.Items.Add("Deactivate");
            //UsersDataGridNumericCol.DefaultCellStyle.BackColor = Color.White;
            //UsersDataGridNumericCol.DefaultCellStyle.ForeColor = Color.Black;
            //this.UsersDataGrid.Columns.Add(UsersDataGridNumericCol);

            //DataGridViewButtonColumn UsersDataGridCellBtn = new DataGridViewButtonColumn();
            //UsersDataGridCellBtn.HeaderText = "Button cell";
            //UsersDataGridCellBtn.Text = "Click me!!!";
            //this.UsersDataGrid.Columns.Add(UsersDataGridCellBtn);

            this.UsersDataGrid.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            this.UsersDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249);

            this.UsersDataGrid.Columns["_id"].Visible = true;
            this.UsersDataGrid.Columns["firstname"].Visible = true;
            this.UsersDataGrid.Columns["lastname"].Visible = true;
            this.UsersDataGrid.Columns["username"].Visible = true;
            this.UsersDataGrid.Columns["email"].Visible = true;
            this.UsersDataGrid.Columns["verified"].Visible = true;
            this.UsersDataGrid.Columns["genre"].Visible = true;
            this.UsersDataGrid.Columns["birthdate"].Visible = true;
            this.UsersDataGrid.Columns["time"].Visible = true;
            this.UsersDataGrid.Columns["age"].Visible = true;
            //// this.UsersDataGrid.Columns["createdAt"].Visible = true;
            //this.UsersDataGrid.Columns["hasPet"].Visible = true;
            //this.UsersDataGrid.Columns["pet"].Visible = true;
            //this.UsersDataGrid.Columns["active"].Visible = true;

            this.UsersDataGrid.Columns["_id"].HeaderText = "ID";
            this.UsersDataGrid.Columns["firstname"].HeaderText = "First name";
            this.UsersDataGrid.Columns["lastname"].HeaderText = "Last name";
            this.UsersDataGrid.Columns["username"].HeaderText = "Username";
            this.UsersDataGrid.Columns["email"].HeaderText = "Email";
            this.UsersDataGrid.Columns["verified"].HeaderText = "Verified";
            this.UsersDataGrid.Columns["genre"].HeaderText = "Genre";
            this.UsersDataGrid.Columns["birthdate"].HeaderText = "Birthdate";
            this.UsersDataGrid.Columns["time"].HeaderText = "Time";
            this.UsersDataGrid.Columns["age"].HeaderText = "Age";
            //// this.UsersDataGrid.Columns["createdAt"].HeaderText = "Created At";
            //this.UsersDataGrid.Columns["hasPet"].HeaderText = "Has Pet";
            //this.UsersDataGrid.Columns["pet"].HeaderText = "Pet type";
            //this.UsersDataGrid.Columns["active"].HeaderText = "is Active";

            this.UsersDataGrid.Columns["_id"].Width = 25;
            // this.UsersDataGrid.Columns["firstname"].Width = 100;
            // this.UsersDataGrid.Columns["lastname"].Width = 100;
            // this.UsersDataGrid.Columns["username"].Width = 100;
            // this.UsersDataGrid.Columns["email"].Width = 100;
            //this.UsersDataGrid.Columns["age"].Width = 40;
            this.UsersDataGrid.Columns["genre"].Width = 70;
            //this.UsersDataGrid.Columns["active"].Width = 110;

            this.UsersDataGrid.Columns["_id"].DisplayIndex = 0;
            this.UsersDataGrid.Columns["firstname"].DisplayIndex = 1;
            this.UsersDataGrid.Columns["lastname"].DisplayIndex = 2;
            this.UsersDataGrid.Columns["username"].DisplayIndex = 3;
            this.UsersDataGrid.Columns["email"].DisplayIndex = 4;
            this.UsersDataGrid.Columns["verified"].DisplayIndex = 5;
            this.UsersDataGrid.Columns["genre"].DisplayIndex = 6;
            this.UsersDataGrid.Columns["birthdate"].DisplayIndex = 7;
            this.UsersDataGrid.Columns["time"].DisplayIndex = 8;
            this.UsersDataGrid.Columns["age"].DisplayIndex = 9;
            //// this.UsersDataGrid.Columns["createdAt"].DisplayIndex = 7;
            //this.UsersDataGrid.Columns["hasPet"].DisplayIndex = 7;
            //this.UsersDataGrid.Columns["pet"].DisplayIndex = 8;
            //this.UsersDataGrid.Columns["active"].DisplayIndex = 9;

            this.UsersDataGrid.Columns["birthdate"].ReadOnly = false;
            this.UsersDataGrid.Columns["time"].ReadOnly = false;
            this.UsersDataGrid.Columns["age"].ReadOnly = false;
            this.UsersDataGrid.Columns["genre"].ReadOnly = false;

            this.UsersDataGrid.Columns["_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.UsersDataGrid.Columns["firstname"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.UsersDataGrid.Columns["lastname"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.UsersDataGrid.Columns["username"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.UsersDataGrid.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.UsersDataGrid.Columns["genre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.UsersDataGrid.Columns["birthdate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.UsersDataGrid.Columns["time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.UsersDataGrid.Columns["age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.UsersDataGrid.Columns["birthdate"].DefaultCellStyle.Format = "d";
            //this.UsersDataGrid.Columns["time"].DefaultCellStyle.Format = "H";
            this.UsersDataGrid.Columns["age"].DefaultCellStyle.Format = "N";

            this.UsersDataGrid.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.UsersDataGrid.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.UsersDataGrid.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.UsersDataGrid.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void FormatProductsDataGrid()
        {
            for (int i = 0; i < this.ProductsDataGrid.Columns.Count; i++)
            {
                this.ProductsDataGrid.Columns[i].Visible = false;
            }

            this.ProductsDataGrid.Columns["Id_Transaccion"].Visible = true;
            this.ProductsDataGrid.Columns["CodArticulo"].Visible = true;
            this.ProductsDataGrid.Columns["Cantidad"].Visible = true;
            this.ProductsDataGrid.Columns["Marca"].Visible = true;
            this.ProductsDataGrid.Columns["Disponible"].Visible = true;
            this.ProductsDataGrid.Columns["Precio"].Visible = true;

            this.ProductsDataGrid.Columns["Id_Transaccion"].HeaderText = "Trans_Id";
            this.ProductsDataGrid.Columns["CodArticulo"].HeaderText = "ItemCode";
            this.ProductsDataGrid.Columns["Cantidad"].HeaderText = "Ammount";
            this.ProductsDataGrid.Columns["Marca"].HeaderText = "Brand";
            this.ProductsDataGrid.Columns["Disponible"].HeaderText = "Available";
            this.ProductsDataGrid.Columns["Precio"].HeaderText = "Price";

            this.ProductsDataGrid.Columns["Id_Transaccion"].Width = 120;
            this.ProductsDataGrid.Columns["CodArticulo"].Width = 180;
            this.ProductsDataGrid.Columns["Cantidad"].Width = 60;
            this.ProductsDataGrid.Columns["Precio"].Width = 80;

            this.ProductsDataGrid.Columns["CodArticulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.ProductsDataGrid.Columns["Marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.ProductsDataGrid.Columns["Id_Transaccion"].DisplayIndex = 0;
            this.ProductsDataGrid.Columns["CodArticulo"].DisplayIndex = 1;
            this.ProductsDataGrid.Columns["Cantidad"].DisplayIndex = 2;
            this.ProductsDataGrid.Columns["Marca"].DisplayIndex = 3;
            this.ProductsDataGrid.Columns["Disponible"].DisplayIndex = 4;
            this.ProductsDataGrid.Columns["Precio"].DisplayIndex = 4;

            this.ProductsDataGrid.Columns["Id_Transaccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.ProductsDataGrid.Columns["CodArticulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.ProductsDataGrid.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.ProductsDataGrid.Columns["Marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // this.ProductsDataGrid.Columns["Disponible"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.ProductsDataGrid.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void SetDataSetsStructs()
        {
            // Users
            //this.UsersData.Tables.Add("users");
            //this.UsersData.Tables["users"].Columns.Add("_id", typeof(int));
            //this.UsersData.Tables["users"].Columns.Add("firstname", typeof(string));
            //this.UsersData.Tables["users"].Columns.Add("lastname", typeof(string));
            //this.UsersData.Tables["users"].Columns.Add("username", typeof(string));
            //this.UsersData.Tables["users"].Columns.Add("email", typeof(string));
            //this.UsersData.Tables["users"].Columns.Add("genre", typeof(string));
            //this.UsersData.Tables["users"].Columns.Add("password", typeof(string));
            //this.UsersData.Tables["users"].Columns.Add("age", typeof(int));
            //this.UsersData.Tables["users"].Columns.Add("createdAt", typeof(DateTime));
            //this.UsersData.Tables["users"].Columns.Add("hasPet", typeof(bool));
            //this.UsersData.Tables["users"].Columns.Add("pet", typeof(string));
            //this.UsersData.Tables["users"].Columns.Add("active", typeof(string));
            this.Controller.SetTableToDataSet("users", ref this.Controller.UsersData, new UserModel());

            // Products
            //this.ProductsData.Tables.Add("products");
            //this.ProductsData.Tables["products"].Columns.Add("_id", typeof(int));
            //this.ProductsData.Tables["products"].Columns.Add("firstname", typeof(string));
            //this.ProductsData.Tables["products"].Columns.Add("lastname", typeof(string));
            //this.ProductsData.Tables["products"].Columns.Add("username", typeof(string));
            //this.ProductsData.Tables["products"].Columns.Add("email", typeof(string));
            //this.ProductsData.Tables["products"].Columns.Add("password", typeof(string));
            this.Controller.SetTableToDataSet("HDR", ref Controller.ProductsData, new ProductTransaction());
            this.Controller.SetTableToDataSet("LINE", ref Controller.ProductsData, new ProductDetail());
        }

        private void GetDataGridsSources()
        {
            this.UsersDataGrid.DataSource = this.Controller.UsersData.Tables["users"];
            this.ProductsDataGrid.DataSource = this.Controller.ProductsData.Tables["LINE"];
        } 

        private void ClearControls()
        {
            // Text Fields
            this.UsernameTxt.Text = "";
            this.FirstnameTxt.Text = "";
            this.LastnameTxt.Text = "";
            this.EmailTxt.Text = "";

            // Radios and Check Buttons
            this.VerifiedChk.Checked = false;
            this.MaleRadioBtn.Checked = false;
            this.FemaleRadioBtn.Checked = false;

            // Age and Birthdate
            this.AgeTxt.Value = 0;
            this.BirthDateTxt.Value = DateTime.Today;
            this.BirthDateTxt.MaxDate = DateTime.Today;
            this.BirthDateTxt.MinDate = DateTime.Today.AddYears(-150);
        }

        public void RestoreCustomCells()
        {
            for (int i = 0; i < this.UsersDataGrid.Rows.Count; i++)
            {
                DataGridViewComboBoxCell UsersDataGridGenreCboCell = new DataGridViewComboBoxCell();

                UsersDataGridGenreCboCell.Items.Add("M");
                UsersDataGridGenreCboCell.Items.Add("F");
                UsersDataGridGenreCboCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                UsersDataGridGenreCboCell.FlatStyle = FlatStyle.Flat;

                DataGridViewCalendarCell UsersDataGridCalendarCell = new DataGridViewCalendarCell(DateTime.Now, DateTime.Today.AddYears(-120), DateTime.Today);
                DataGridViewTimeCell UsersDataGridTimeCell = new DataGridViewTimeCell();
                DataGridViewNumericCell UsersDataGridNumericCell = new DataGridViewNumericCell();

                UsersDataGridCalendarCell.Value = this.UsersDataGrid["birthdate", i].Value;
                UsersDataGridTimeCell.Value = this.UsersDataGrid["time", i].Value;
                UsersDataGridNumericCell.Value = this.UsersDataGrid["age", i].Value;
                UsersDataGridGenreCboCell.Value = this.UsersDataGrid["genre", i].Value;

                this.UsersDataGrid["birthdate", i] = UsersDataGridCalendarCell;
                this.UsersDataGrid["time", i] = UsersDataGridTimeCell;
                this.UsersDataGrid["age", i] = UsersDataGridNumericCell;
                this.UsersDataGrid["genre", i] = UsersDataGridGenreCboCell;
            }
        }

        private void AddNewUser()
        {
            if (this.ValidateFields() && !this.Controller.UserAlreadyExists(this.UsernameTxt.Text, this.EmailTxt.Text))
            {
                var NewUser = new UserModel
                {
                    _id = this.Controller.UsersData.Tables["users"].Rows.Count + 1,
                    Username = this.UsernameTxt.Text,
                    Email = this.EmailTxt.Text,
                    Password = "",
                    FirstName = this.FirstnameTxt.Text,
                    LastName = this.LastnameTxt.Text,
                    BirthDate = this.BirthDateTxt.Value,
                    Time = DateTime.Now,
                    Genre = this.MaleRadioBtn.Checked && !this.FemaleRadioBtn.Checked ? "M" : !this.MaleRadioBtn.Checked && this.FemaleRadioBtn.Checked ? "F" : null,
                    Age = (int)this.AgeTxt.Value,
                    Verified = this.VerifiedChk.Checked
                };

                this.Controller.AddNewUser(NewUser);
                this.RestoreCustomCells();
                this.EnableEditingButtons();
                this.ClearControls();
            }
        }

        private bool ValidateFields()
        {
            // Text Fields
            if (!(this.UsernameTxt.Text != ""))
            {
                MessageBox.Show("El campo 'Username' no puede estar vacio", "System information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(this.FirstnameTxt.Text != ""))
            {
                MessageBox.Show("El campo 'Firstname' no puede estar vacio", "System information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(this.LastnameTxt.Text != ""))
            {
                MessageBox.Show("El campo 'Lastname' no puede estar vacio", "System information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(this.EmailTxt.Text != ""))
            {
                MessageBox.Show("El campo 'Email' no puede estar vacio", "System information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!this.MaleRadioBtn.Checked && !this.FemaleRadioBtn.Checked)
            {
                MessageBox.Show("Debe seleccionar un género.", "System information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void FilterUsersDataResults()
        {
            if (this.UsersTabSearchTxt.Text != "")
            {
                try
                {
                    string Str = this.UsersTabSearchTxt.Text;
                    string Filter = $"username LIKE '%{Str}%' OR firstname LIKE '%{Str}%' OR lastname LIKE '%{Str}%' OR email LIKE '%{Str}%' OR genre LIKE '%{Str}%'";

                    DataView Results = new DataView();
                    Results.Table = this.Controller.UsersData.Tables["users"];
                    Results.RowFilter = Filter;
                    this.UsersDataGrid.DataSource = Results;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.UsersDataGrid.DataSource = this.Controller.UsersData.Tables["users"];
            }

            this.UsersDataGrid.Update();
            this.FormatUsersDataGrid();
            this.RestoreCustomCells();
        }

        private void EnableEditingButtons()
        {
            this.ClearEntriesBtn.Enabled = true;
            this.EditUserBtn.Enabled = true;
            this.RemoveUserBtn.Enabled = true;
            this.ViewPDFBtn.Enabled = true;
            this.ExportAsBtn.Enabled = true;
        }

        private void DisableEditingButtons()
        {
            this.ClearEntriesBtn.Enabled = false;
            this.EditUserBtn.Enabled = false;
            this.RemoveUserBtn.Enabled = false;
            this.ViewPDFBtn.Enabled = false;
            this.ExportAsBtn.Enabled = false;
        }

        #endregion

        #region Events

        private void HandlePeopleProp(object sender, PeoplePropChangedEventArgs e)
        {
            MessageBox.Show(e.Name);
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            this.StylizeDataGrids();
            this.ClearControls();
        }

        private void BirthDateTxt_ValueChanged(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Today;
            TimeSpan difference = Today.Subtract(this.BirthDateTxt.Value);

            var firstDay = new DateTime(1, 1, 1);
            int totalYears = (firstDay + difference).Year - 1;
            AgeTxt.Value = totalYears;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.ClearControls();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            this.AddNewUser();
        }

        private async void GetUsersBtn_Click(object sender, EventArgs e)
        {
            if (this.NumRowsCb.Text == "")
            {
                MessageBox.Show("Please select a number of rows to search.", "System information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumRowsCb.Focus();
                return;
            }

            this.GetUsersBtn.Enabled = false;
            await this.Controller.GetUsersDataAsync(this.NumRowsCb.Text);

            if (this.Controller.UsersData.Tables["users"].Rows.Count > 0)
            {
                this.EnableEditingButtons();
            }

            this.GetUsersBtn.Enabled = true;
        }

        private void GetProductsBtn_Click(object sender, EventArgs e)
        {
            this.Controller.GetProductsDataAsync();
        }

        private void DllMessageBtn_Click(object sender, EventArgs e)
        {
            this.CallDllFunction((double Result) =>
            {
                MessageBox.Show($"The result is: {Result}", "System information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            People Jon = new People("Jonathan", 24, new DateTime(1998, 11, 16));
            Jon.PropChanged += null; // this.HandlePeopleProp;

            Jon.Age = 24;
            Jon.Name = "Jonathan Jose";
        }

        private void UsersDataGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersDataGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void UsersDataGrid_Sorted(object sender, EventArgs e)
        {
            this.RestoreCustomCells();
        }

        private void UsersTabSearchTxt_TextChanged(object sender, EventArgs e)
        {
            this.FilterUsersDataResults();
        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            this.Controller.RemoveUser(this.UsersDataGrid.CurrentRow.Index);
            this.Controller.SortUsers();
            this.RestoreCustomCells();
            
            if (this.Controller.UsersData.Tables["users"].Rows.Count == 0)
            {
                this.DisableEditingButtons();
            }
        }

        #endregion

        private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainWindow frm = (MainWindow)Application.OpenForms["MainWindow"];
            frm.ToggleSideBarPanelCheckState("MAIN_PANEL");
        }

        private void ClearEntriesBtn_Click(object sender, EventArgs e)
        {
            this.Controller.UsersData.Tables["users"].Clear();
            this.RestoreCustomCells();
            this.DisableEditingButtons();
        }

        private void ViewPDFBtn_Click(object sender, EventArgs e)
        {

        }

        private void UsersDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
