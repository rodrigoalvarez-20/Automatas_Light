using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Teoria_Computacional {
    public partial class AFD : Form {
        frmInicio frmInicio;
        Automata automate = new Automata();
        public AFD (frmInicio main) {
            InitializeComponent();
            frmInicio = main;
        }

        private void btnOpenFile_Click (object sender, EventArgs e) {
            if(OFAFD.ShowDialog()==DialogResult.OK) {
                JObject afd_obj = JObject.Parse(File.ReadAllText(@OFAFD.FileName));
                this.automate.Estado_Inicial = afd_obj.GetValue("Estado_Inicial").ToString();
                this.automate.Estados_Aceptacion = afd_obj.GetValue("Estados_Aceptacion").ToObject<string[]>();
                this.automate.Trans = afd_obj.GetValue("Trans").ToObject<Transicion[]>();
                txtCadena.Enabled=true;
            }
        }

        private void btnBack_Click (object sender, EventArgs e) {
            this.Close();
            frmInicio.Show();
        }

        private void btnValidate_Click (object sender, EventArgs e) {
            string cadena = txtCadena.Text;

            string estado_actual = this.automate.Estado_Inicial;

            foreach(char caracter in cadena) {
                List<Transicion> transiciones = new List<Transicion>();
                foreach(Transicion transicion in this.automate.Trans) {
                    if(transicion.Inicio==estado_actual) {
                        transiciones.Add(transicion);
                    }
                }
                foreach (Transicion transt in transiciones) {
                    if (transt.Valor.Equals(caracter.ToString())) {
                        estado_actual=transt.Siguiente[0];
                    }
                }

            }

            lblResult.Text=this.automate.Estados_Aceptacion.Contains(estado_actual) ? "La cadena es valida" : "La cadena es invalida";
        }
    }

}
