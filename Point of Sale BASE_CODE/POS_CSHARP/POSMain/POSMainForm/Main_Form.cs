using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace POSMainForm
{
    public partial class Main_Form : Form
    {
        string Username;
        int StaffID;
        public Main_Form(string username, int staffID)
        {
            InitializeComponent();

            Username = username;
            StaffID = staffID;

            dataGrid_pacientes.Columns.Add("id", "Id");
            dataGrid_pacientes.Columns.Add("name", "Nombre");
            dataGrid_pacientes.Columns.Add("lastname", "Apellido");
            dataGrid_pacientes.Columns.Add("phone1", "Telefono");
            dataGrid_pacientes.Columns.Add("age", "Edad");
            dataGrid_pacientes.Columns[0].Width = 50;
            dataGrid_pacientes.Columns[1].Width = 200;
            dataGrid_pacientes.Columns[2].Width = 200;
            dataGrid_pacientes.Columns[3].Width = 100;
            dataGrid_pacientes.Columns[4].Width = 100;

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            SQLConn.getData();
            this.user_logged_name.Text = "Usuario Activo : " + Username.ToUpper();
            
        }


        private void timer_main_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = "Date-Time : " + DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt");
        }

       
    }
}
