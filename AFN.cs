using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teoria_Computacional {
    public partial class AFN : Form {
        frmInicio inicio;
        Automata automate_afn = new Automata();
        Automata automata_afd;
        public AFN (frmInicio main) {
            InitializeComponent();
            this.inicio=main;
        }

        private void materialFlatButton1_Click (object sender, EventArgs e) {
            this.Close();
            inicio.Show();
        }

        private void btnOpenFile_Click ( object sender, EventArgs e ) {
            if (OFAFN.ShowDialog()==DialogResult.OK) {
                JObject afn_obj = JObject.Parse(File.ReadAllText(@OFAFN.FileName));
                this.automate_afn.Nombre = afn_obj.GetValue("Nombre").ToString();
                this.automate_afn.Estado_Inicial = afn_obj.GetValue("Estado_Inicial").ToString();
                this.automate_afn.Estados = afn_obj.GetValue("Estados").ToObject<string[]>();
                this.automate_afn.Estados_Aceptacion = afn_obj.GetValue("Estados_Aceptacion").ToObject<string[]>();
                this.automate_afn.Trans = afn_obj.GetValue("Trans").ToObject<Transicion[]>();
                this.automate_afn.Alfabeto=afn_obj.GetValue("Alfabeto").ToObject<string[]>();
                this.btnConvert.Enabled = true;
            }
        }

        private void btnConvert_Click ( object sender, EventArgs e ) {
            List<Transicion> trans_arr = new List<Transicion>();
            foreach (Transicion trans in this.automate_afn.Trans) {
                if (trans.Inicio.Equals(this.automate_afn.Estado_Inicial)) {
                    trans_arr.Add(trans);
                }
            }

            
            for (int i = 0; i < trans_arr.Count; i++) {
                string[] next_states = trans_arr[i].Siguiente;
                string prev_state = next_states.Equals(null) ? "" : string.Join(",", next_states.Distinct().ToList());
                bool estado_agregado = false;
                foreach (Transicion trans_val in trans_arr) {
                    if (prev_state==trans_val.Inicio) {
                        estado_agregado=true;
                        break;
                    }
                }

                if (estado_agregado == false) {
                    foreach (string letra in this.automate_afn.Alfabeto) {
                        Transicion trans_add = new Transicion();
                        trans_add.Inicio = prev_state;
                        trans_add.Valor = letra;
                        JArray next_st = new JArray();
                        foreach (string next_state in trans_arr[i].Siguiente) {
                            foreach (Transicion state in this.automate_afn.Trans) {
                                if (next_state.Equals(state.Inicio) && state.Valor.Equals( letra )) {
                                    string[] st = next_st.ToObject<string[]>().Distinct().ToArray();
                                    string[] state_add = state.Siguiente.Distinct().ToArray();
                                    next_st=JArray.FromObject(st.Concat(state_add));
                                    break;
                                }
                            }
                        }
                        trans_add.Siguiente=next_st.ToObject<string[]>();
                        if(trans_add.Inicio != "" && trans_add.Siguiente != null) {
                            trans_arr.Add(trans_add);
                        }
                        
                    }
                }

            }

            //Console.WriteLine(JsonConvert.SerializeObject(trans_arr, Formatting.Indented));

            JArray acept_states = new JArray();
            JArray new_states_arr = new JArray();
            Dictionary<string, string> new_states = new Dictionary<string, string>();

            foreach (Transicion state in trans_arr) {
                string estado_previo = state.Inicio;
                string estado_siguiente = string.Join(",", state.Siguiente.Distinct().ToArray());
                //string estado_siguiente = string.Concat(",", state.Siguiente.Distinct<string>().ToArray());
                if (!new_states.ContainsKey(estado_previo)) {
                    string new_state_prev = string.Concat("q", Convert.ToString(new_states.Count()));
                    new_states.Add(estado_previo, new_state_prev);
                    new_states_arr.Add(new_state_prev);
                    foreach (string estado_aceptacion in this.automate_afn.Estados_Aceptacion) {
                        if (estado_previo.Contains(estado_aceptacion)) {
                            if (!acept_states.Contains(new_state_prev)) {
                                acept_states.Add(new_state_prev);
                            }
                        }
                    }
                }
                if (!new_states.ContainsKey(estado_siguiente)){
                    string new_state_next = string.Concat("q", Convert.ToString(new_states.Count()));
                    new_states.Add(estado_siguiente, new_state_next);
                    new_states_arr.Add(new_state_next);
                    foreach (string estado_aceptacion in this.automate_afn.Estados_Aceptacion) {
                        if (estado_siguiente.Contains(estado_aceptacion)) {
                            if (!acept_states.Contains(new_state_next)) {
                                acept_states.Add(new_state_next);
                            }
                        }
                    }
                }
                state.Inicio=new_states[estado_previo];
                state.Siguiente=new string[] { new_states[estado_siguiente] };
            }

            this.automata_afd = new Automata();
            this.automata_afd.Nombre=this.automate_afn.Nombre;
            this.automata_afd.Estados=new JArray(new_states.Values).ToObject<string[]>();
            this.automata_afd.Estado_Inicial=this.automate_afn.Estado_Inicial;
            this.automata_afd.Estados_Aceptacion=acept_states.ToObject<string[]>();
            this.automata_afd.Alfabeto=this.automate_afn.Alfabeto;
            this.automata_afd.Trans=trans_arr.ToArray<Transicion>();

            txtTransiciones.ResetText();
            foreach(Transicion value in trans_arr) {
                string nextStates = string.Join(", ", value.Siguiente);
                string text = string.Concat(value.Inicio, " --> ", value.Valor, " --> {", value.Siguiente[0], "}", Environment.NewLine);
                txtTransiciones.AppendText(text);
            }
        }

        private void btnSaveFile_Click ( object sender, EventArgs e ) {
            if(sfAFD.ShowDialog() == DialogResult.OK) {
                if (sfAFD.FileName!=string.Empty) {
                    TextWriter txtWriter = null;
                    try {
                        var contenido = JsonConvert.SerializeObject(this.automata_afd, Formatting.Indented);
                        txtWriter=new StreamWriter(sfAFD.FileName, true);
                        txtWriter.Write(contenido);
                    } finally {
                        if (txtWriter!=null)
                            txtWriter.Close();
                        MessageBox.Show("Se ha guardado correctamente el archivo", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("Por favor especifique un nombre de archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
