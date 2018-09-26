using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridListBoxBinding
{
    public partial class Form1 : Form
    {
        public BindingList<Person> People { get; set; } = new BindingList<Person>();

        public Form1()
        {
            InitializeComponent();

            People.Add(new Person(1, "Hans", true));
            People.Add(new Person(2, "Jens", true));
            People.Add(new Person(3, "Jürgen", true));

            personDataGridView.DataSource = People;
            PersonComboBox.DataSource = People;
            PersonComboBox.DisplayMember = "Id";
        }
    }
}
