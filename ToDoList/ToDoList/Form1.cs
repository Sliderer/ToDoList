using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private DataBase dataBase;

        public Form1()
        {
            InitializeComponent();
            dataBase = new DataBase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addNote_Click(object sender, EventArgs e)
        {
            dataBase.AddNote(new Note { title = title.Text, date = date.Text, description = descriotion.Text });
        }
    }
}
