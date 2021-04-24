using System;
using System.Linq;
using System.Windows.Forms;
using CovidAirlines.Enums;

namespace CovidAirlines
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();

        }

        //Initialize random object outside of scope so we only call once
        Random random = new Random();

        private void Login_Load(object sender, EventArgs e)
        {
            ErrorMessage.Hide();

            //Fill Expiry Month Combo box
            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i.ToString());
            }
            //Fill Expiry Year Combo box
            for (int i = 2021; i <= 2099; i++)
            {
                comboBoxYear.Items.Add(i.ToString());
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // check if username and password are empty
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                ErrorMessage.Text = "Username and password must not be empty";
                ErrorMessage.Show();
            }
            else
            {
                int userId;
                if (!int.TryParse(UsernameTextBox.Text, out int i))
                {
                    ErrorMessage.Text = "Invalid UserID. Please enter a 6-digit UserID";
                    ErrorMessage.Show();
                    return;
                }
                else
                {
                    userId = i;
                }

                // check if user exists with that login
                using (var entities = new CovidAirlinesEntities())
                {
                    var user = entities.Users.Where(u => u.UserID == userId).FirstOrDefault();

                    // username doesnt match
                    if (user == null)
                    {
                        ErrorMessage.Text = "User does not exist. Create an account to login.";
                        ErrorMessage.Show();
                        return;
                    }
                    //Generate hash of inputted password and check db for match
                    var hash = Utility.GenerateHash(PasswordTextBox.Text);
                    // password doesnt match
                    if (!user.PasswordHash.SequenceEqual(Utility.GenerateHash(PasswordTextBox.Text)))
                    {
                        ErrorMessage.Text = "Username or password does not match";
                        ErrorMessage.Show();
                        return;
                    }
                    //Redirect to corresponding homescreen
                    switch (user.UserType)
                    {
                        case (byte)UserType.CUSTOMER:
                            FormCustomer fCustomer = new FormCustomer(user);
                            fCustomer.ShowDialog();
                            break;

                        case (byte)UserType.LOAD_ENGINEER:
                            FormLoad fLoad = new FormLoad();
                            fLoad.ShowDialog();
                            break;

                        case (byte)UserType.MARKETING_MANAGER:
                            FormMarketing fMarketing = new FormMarketing();
                            fMarketing.ShowDialog();
                            break;

                        case (byte)UserType.FLIGHT_MANAGER:
                            FormFlightManager fFlight = new FormFlightManager();
                            fFlight.ShowDialog();
                            break;

                        case (byte)UserType.ACCOUNTANT:
                            FormAccountant fAccountant = new FormAccountant();
                            fAccountant.ShowDialog();
                            break;
                    }
                    
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //Grab all inputted information
            string[] newAccount = new string[12];

            newAccount[0] = textBoxName.Text;
            newAccount[1] = textBoxPassword.Text;
            newAccount[2] = textBoxConfirmPassword.Text;
            newAccount[3] = textBoxAddress.Text;
            newAccount[4] = textBoxCity.Text;
            newAccount[5] = textBoxZipcode.Text;
            newAccount[6] = textBoxNumber.Text;
            newAccount[7] = numericAge.Value.ToString();
            newAccount[8] = textBoxCC.Text;
            newAccount[9] = comboBoxMonth.GetItemText(comboBoxMonth.SelectedItem);
            newAccount[10] = comboBoxYear.GetItemText(comboBoxYear.SelectedItem);
            newAccount[11] = textBoxCSV.Text;
            
            //Ensure all fields are filled
            bool allFieldsFilled = true;
            foreach (string s in newAccount)
            {
                allFieldsFilled &= !string.IsNullOrWhiteSpace(s);
            }
            if (!allFieldsFilled)
            {
                labelResult.Text = "All fields are required!";
                labelResult.Visible = true;
                return;
            }

            //Now make sure password and confirmation password match
            if (newAccount[1] != newAccount[2])
            {
                labelResult.Text = "Password and confirmation password do not match!";
                labelResult.Visible = true;
                return;
            }

            
            //All fields valid, create user object using all user inputted data
            string randUserID = "";
            using (var entities = new CovidAirlinesEntities())
            {
                int intID;
                //generate random 6-digit UserID (cannot start with zero)
                do
                {//keep generating User IDs if randID is already taken
                    randUserID += random.Next(1, 9).ToString();//first digit CANT be zero
                    for (int i = 0; i < 5; i++)
                    {
                        randUserID += random.Next(0, 9).ToString();
                    }
                    intID = int.Parse(randUserID);
                } 
                while (entities.Users.Where(u => u.UserID == intID).FirstOrDefault() != null); 

                var user = new User
                {
                    UserID = int.Parse(randUserID),
                    UserType = (byte)UserType.CUSTOMER,
                    FullName = newAccount[0],
                    PasswordHash = Utility.GenerateHash(textBoxPassword.Text),
                    Address = newAccount[3],
                    City = newAccount[4],
                    ZipCode = newAccount[5],
                    PhoneNumber = newAccount[6],
                    Age = short.Parse(newAccount[7]),
                    CardNumber = newAccount[8],
                    CardExpiryDate = new DateTime(int.Parse(newAccount[10]), int.Parse(newAccount[9]), 1),
                    CardCVV = short.Parse(newAccount[11]),
                    PointsAvailable = 0,
                    PointsRedeemed = 0
                };
                entities.Users.Add(user);
                entities.SaveChanges();
            }

            labelResult.Text = "Success! ID: " + randUserID;
            labelResult.Visible = true;
            ClearAllTextBoxes(this.Controls);
            UsernameTextBox.Text = randUserID;
        }

        public void ClearAllTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = string.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.Text = string.Empty;//why no work
                }
                else
                {
                    ClearAllTextBoxes(ctrl.Controls);
                }
            }

            comboBoxMonth.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;
        }
    }

}
