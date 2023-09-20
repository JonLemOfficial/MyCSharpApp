using System;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net.Http;

using Newtonsoft.Json;

using MyCSharpApp.Desktop.Windows;
using MyCSharpApp.Desktop.Models;

namespace MyCSharpApp.Desktop.Controllers
{
    public class MainController
    {
        private HttpClient WebClient;

        //private DataSet usersData, productsData;

        // Data
        public DataSet UsersData;
        //{
        //    get => this.usersData;
        //    set => this.usersData = value;
        //}

        public DataSet ProductsData;
        //{
        //    get => this.productsData;
        //    set => this.productsData = value;
        //}

        public MainController()
        {
            this.UsersData = new DataSet();
            this.ProductsData = new DataSet();
            this.WebClient = WebAPI.CreateHttpClient("http://localhost:5000", "application/json");
        }

        public void SetTableToDataSet(string TableName, ref DataSet TargetDataSet, object TargetClass)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(TargetClass.GetType());
            TargetDataSet.Tables.Add(TableName);

            foreach (PropertyDescriptor p in props)
            {
                TargetDataSet.Tables[TableName].Columns.Add(p.Name, p.PropertyType);
            }
        }

        private void AddUsersUsersDataExampleData()
        {
            for (int i = 0; i < 1; i++)
            {
                DataRow ExampleRow = this.UsersData.Tables["users"].NewRow();

                ExampleRow["_id"] = i + 1;
                ExampleRow["username"] = "JonLem";
                //ExampleRow["password"] = "JonLem161198__@";
                ExampleRow["email"] = "jonlemofficial@hotmail.com";
                ExampleRow["firstname"] = "Jonathan";
                ExampleRow["lastname"] = "Lemos";
                //ExampleRow["genre"] = "M";
                //ExampleRow["age"] = 24;
                //ExampleRow["hasPet"] = true;

                //DataGridViewComboBoxCell CboActive = new DataGridViewComboBoxCell();
                //CboActive.Items.Add("Yes");
                //CboActive.Items.Add("No");
                //CboActive.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                //CboActive.FlatStyle = FlatStyle.Flat;

                //DataGridViewComboBoxCell CboPet = new DataGridViewComboBoxCell();
                //CboPet.Items.Add("Cat");
                //CboPet.Items.Add("Dog");
                //CboPet.Items.Add("Lion");
                //CboPet.Items.Add("Bear");
                //CboPet.Items.Add("Tiger");
                //CboPet.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;

                this.UsersData.Tables["users"].Rows.Add(ExampleRow);

                //this.UsersDataGrid.Rows[i].Cells["active"] = CboActive;
                //this.UsersDataGrid.Rows[i].Cells["pet"] = CboPet;

                // Don't call this method, otherwise the ComboBox Cells 
                // will convert back to normal cells
                // this.UsersData.AcceptChanges();
            }
        }

        public void SortUsers()
        {
            for (int i = 0; i < this.UsersData.Tables["users"].Rows.Count; i++)
            {
                this.UsersData.Tables["users"].Rows[i]["_id"] = i + 1;
            }

            this.UsersData.AcceptChanges();
        }

        public void RemoveUser(int RowIndex)
        {
            if (RowIndex > -1)
            {
                try
                {
                    int PreviousTotalRows, CurrentTotalRows;
                    PreviousTotalRows = this.UsersData.Tables[0].Rows.Count;
                    var UserName = this.UsersData.Tables[0].Rows[RowIndex]["Username"];

                    this.UsersData.Tables[0].Rows.RemoveAt(RowIndex);
                    this.UsersData.AcceptChanges();

                    //CurrentTotalRows = this.UsersData.Tables[0].Rows.Count;

                    //if (PreviousTotalRows - CurrentTotalRows == 1)
                    //{
                    //    MessageBox.Show($"User: {UserName} was deleted successfully.", "System information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show($"You should select a row to remove an user.", "System information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool UserAlreadyExists(string Username, string Email)
        {
            DataRow[] Users = this.UsersData.Tables["users"].Select(
                $@"Username = '{Username}'
                    OR Email = '{Email}'
                "
            );

            if (Users.Length > 0)
            {
                foreach (DataRow Row in Users)
                {
                    if (Row["username"].ToString() == Username)
                    {
                        MessageBox.Show($"User: {Row["username"]} already exists.", "System information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    if (Row["email"].ToString() == Email)
                    {
                        MessageBox.Show($"Email: {Row["email"]} already exists.", "System information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                }
                return true;
            }

            return false;
        }

        public void AddNewUser(string Username, string Fisrtname, string LastName, string Email, bool Verified, DateTime BirthDate, int Age, string Genre)
        {
            DataRow UserRow = this.UsersData.Tables["users"].NewRow();

            UserRow["_id"] = this.UsersData.Tables["users"].Rows.Count + 1;
            UserRow["username"] = Username;
            UserRow["firstname"] = Fisrtname;
            UserRow["lastname"] = LastName;
            UserRow["email"] = Email;
            UserRow["verified"] = Verified;
            UserRow["birthdate"] = BirthDate;
            UserRow["time"] = DateTime.Now;
            UserRow["age"] = Age;
            UserRow["genre"] = Genre;

            this.UsersData.Tables["users"].Rows.Add(UserRow);
            this.UsersData.AcceptChanges();

            MessageBox.Show($"User: {UserRow["username"]} added successfully.", "System information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AddNewUser(UserModel NewUser)
        {
            DataRow UserRow = this.UsersData.Tables["users"].NewRow();

            UserRow["_id"] = this.UsersData.Tables["users"].Rows.Count + 1;
            UserRow["username"] = NewUser.Username;
            UserRow["firstname"] = NewUser.FirstName;
            UserRow["lastname"] = NewUser.LastName;
            UserRow["email"] = NewUser.Email;
            UserRow["verified"] = NewUser.Verified;
            UserRow["birthdate"] = NewUser.BirthDate;
            UserRow["time"] = DateTime.Now;
            UserRow["age"] = NewUser.Age;
            UserRow["genre"] = NewUser.Genre;

            this.UsersData.Tables["users"].Rows.Add(UserRow);
            this.UsersData.AcceptChanges();

            MessageBox.Show($"User: {UserRow["username"]} added successfully.", "System information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public async Task GetUsersDataAsync(string NumRows)
        {
            //string xml = this.UsersData.GetXmlSchema();
            HttpResponseMessage Response;

            MainWindow frm = (MainWindow)Application.OpenForms["MainWindow"];

            try
            {
                frm.StatusBarInfoLabel.Text = "Getting users...";
                Response = await this.WebClient.GetAsync($"/api/users/getUsers?numrows={NumRows}");

                if (Response.IsSuccessStatusCode)
                {
                    if (this.UsersData.Tables["users"].Rows.Count > 0 )
                    {
                        this.UsersData.Tables["users"].Clear();
                    }

                    UserModel[] Users = JsonConvert.DeserializeObject<UserModel[]>(
                        await Response.Content.ReadAsStringAsync()
                    );

                    if (Users.Length > 0)
                    {
                        foreach (UserModel User in Users)
                        {
                            DataRow UserRow = this.UsersData.Tables["users"].NewRow();

                            UserRow["_id"] = User._id;
                            UserRow["firstname"] = User.FirstName;
                            UserRow["username"] = User.Username;
                            UserRow["email"] = User.Email;
                            UserRow["password"] = User.Password;
                            UserRow["lastname"] = User.LastName;
                            UserRow["genre"] = User.Genre;
                            UserRow["age"] = User.Age;
                            UserRow["birthdate"] = User.BirthDate;
                            UserRow["time"] = User.BirthDate;
                            UserRow["verified"] = User.Verified;

                            this.UsersData.Tables["users"].Rows.Add(UserRow);
                        }

                        this.UsersData.AcceptChanges();
                        this.SortUsers();
                        frm.MainPanelDock.RestoreCustomCells();
                        frm.StatusBarInfoLabel.Text = "Users fetched Succesfully";
                    } 
                    else
                    {
                        MessageBox.Show(
                            "No se encontraron registros",
                            "System information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }
                }

                return;
            }
            catch (JsonSerializationException ex)
            {

            }
            catch (TaskCanceledException ex)
            {
                frm.StatusBarInfoLabel.Text = "";
                MessageBox.Show(
                    "Ocurrió un error al consultar los datos de usuario",
                    "System information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
            catch (HttpRequestException ex)
            {
                frm.StatusBarInfoLabel.Text = "";
                MessageBox.Show(
                    $"Error de conexión con el servidor ('Users'), info: {ex.HResult}",
                    "System information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
        }

        public async void GetProductsDataAsync()
        {
            //string xml = this.ProductsData.GetXmlSchema();
            HttpResponseMessage Response;
            string ResponseText;

            try
            {
                Response = await WebClient.GetAsync("/products");

                if (Response.IsSuccessStatusCode)
                {
                    ResponseText = await Response.Content.ReadAsStringAsync();
                    ProductsModel products = JsonConvert.DeserializeObject<ProductsModel>(ResponseText);
                    //DataSet userDT = JsonConvert.DeserializeObject<DataSet>(ResponseText);
                    //string xml3 = userDT.GetXmlSchema();

                    foreach (ProductDetail Product in products.Line)
                    {
                        DataRow row = this.ProductsData.Tables["LINE"].NewRow();

                        row["Id_Transaccion"] = Product.Id_Transaccion;
                        row["CodArticulo"] = Product.CodArticulo;
                        row["Cantidad"] = Product.Cantidad;
                        row["Marca"] = Product.Marca;
                        row["Disponible"] = Product.Disponible;
                        row["Precio"] = Product.Precio;

                        this.ProductsData.Tables["LINE"].Rows.Add(row);
                    }

                    foreach (ProductTransaction ProductsDocument in products.HDR)
                    {
                        DataRow row = this.ProductsData.Tables["HDR"].NewRow();

                        row["Id_Transaccion"] = ProductsDocument.Id_Transaccion;
                        row["FechaCreacion"] = ProductsDocument.FechaCreacion;
                        row["CodSucursalOrigen"] = ProductsDocument.CodSucursalOrigen;
                        row["CodAlmacenOrigen"] = ProductsDocument.CodAlmacenOrigen;
                        row["CodSucursalDestino"] = ProductsDocument.CodSucursalDestino;
                        row["CodAlmacenDestino"] = ProductsDocument.CodAlmacenDestino;

                        this.ProductsData.Tables["HDR"].Rows.Add(row);
                    }

                    this.ProductsData.AcceptChanges();
                }
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al consultar los datos de usuario",
                    "System information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(
                    $"Error de conexión con el servidor ('Products'), info: {ex.HResult}",
                    "System information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

        }
    }
}
