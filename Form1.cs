namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //creating an instance of the dialogue class form
            DialogAddContact dialog = new DialogAddContact();
            //Showing the dialog
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                //Adding the contact to the DataGridView
                //dataGridView1.Rows.Add(dialog.ContactIdInput, dialog.NameInput, dialog.PhoneInput, dialog.EmailInput);
            }
        }
    }

    public class DialogAddContact : Form
    {
        //Initializing all the controls
        public TextBox txtName = new TextBox();
        public TextBox txtPhone = new TextBox();
        public TextBox txtEmail = new TextBox();
        public TextBox txtContactId = new TextBox();
        public Button btnOk = new Button();
        public Button btnCancel = new Button();

        //Getter and Setter for the  attritbutes:
        public string NameInput { get;set; }
        public string PhoneInput { get; set; }
        public string EmailInput { get; set; }
        public string ContactIdInput { get; set; }

        public DialogAddContact()
        {
            //Setting the properties of the controls
            this.Text = "Add Contact";
            this.Size = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterParent;

            //creating the label controls to the form
            Label lblUserID = new Label() { Text = "ID", Location = new Point(10, 10) };
            txtContactId.Location = new Point(100, 10);
            Label lblName = new Label() { Text = "Name", Location = new Point(10, 40) };
            txtName.Location = new Point(100, 40);
            Label lblPhone = new Label() { Text = "Phone", Location = new Point(10, 70) };
            txtPhone.Location = new Point(100, 70);
            Label lblEmail = new Label() { Text = "Email", Location = new Point(10, 100) };
            txtEmail.Location = new Point(100, 100);
  

            //Buttons
            btnOk.Text = "OK";
            btnOk.Size = new Size(75, 75);
            btnOk.Location = new Point(50, 150);
            btnOk.Click += ( sender,  e ) => {
                NameInput = txtName.Text;
                PhoneInput = txtPhone.Text;
                EmailInput = txtEmail.Text;
                ContactIdInput = Guid.NewGuid().ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            ;
            btnCancel.Text = "Cancel";
            btnCancel.Size = new Size(75, 75);
            btnCancel.Location = new Point(150, 150);
            btnCancel.Click += (sender, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            ;
            //Adding the controls to the form
            this.Controls.Add(lblUserID);
            this.Controls.Add(txtContactId);
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblPhone);
            this.Controls.Add(txtPhone);
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);
        }

    }
}
