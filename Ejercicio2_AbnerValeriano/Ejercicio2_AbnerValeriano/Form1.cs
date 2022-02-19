using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_AbnerValeriano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
            string[] nombres;
            string[] Edad = new string[10];
            

            private void Agregarbutton_Click(object sender, EventArgs e)
            {
                nombres = new string[1];
                nombres[0] = NombreTexBox.Text;
                Edad = new string[1];
                Edad[0] = Edad1TextBox.Text;

                EstudianteslistBox.Items.Add("Nombre: " + nombres[0] + " Edad: "+ Edad[0]);
                NombreTexBox.Clear();
                Edad1TextBox.Clear();
            }
        
    }
}
