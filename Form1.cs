using SD20309.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form curentForm;
        void ChangeForm(Form form)
        {
            if (curentForm != null)
            {
                curentForm.Close();
            }

            curentForm = form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(curentForm);
            form.BringToFront();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeForm(new Form2()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeForm(new Form3());
        }
    }
}
