using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
using System.IO;

namespace processQueue {
    public partial class Form1 : Form {
        protected List<Processo> listaProcesso = new List<Processo>();
        protected List<Thread> listaThread = new List<Thread>();
        protected List<Parada> listaParada = new List<Parada>();

        public Form1() {
            InitializeComponent();

            lB_Processo.Items.Add("|| ID    || Process\t     || Start       || Interval    ||");
            lb_Thread.Items.Add("|| Process    || Quantity        || Size\t        ||");
            lB_Parada.Items.Add("|| ID\t|| Start\t\t|| End\t       ||");

            cBThreadProcesso.Items.Insert(0, "| Select                                       |");
            cBThreadProcesso.SelectedIndex = 0;
        }

        private void txtQuantGrupo_KeyUp(object sender, KeyEventArgs e) {
            if (!validarNumero(txtQuantProcesso.Text)) {
                txtQuantProcesso.Text = string.Empty;
            }
        }
        private void txtThreadTamanho_KeyUp(object sender, KeyEventArgs e) {
            if (!validarNumero(txtThreadTamanho.Text)) {
                txtThreadTamanho.Text = string.Empty;
            }
        }
        private void txtInicio_KeyUp(object sender, KeyEventArgs e) {
            if (!validarNumero(txtInicio.Text)) {
                txtInicio.Text = string.Empty;
            }
        }
        private void txtInicioParada_KeyUp(object sender, KeyEventArgs e) {
            if (!validarNumero(txtInicioParada.Text)) {
                txtInicioParada.Text = string.Empty;
            }
        }
        private void txtFimParada_KeyUp(object sender, KeyEventArgs e) {
            if (!validarNumero(txtFimParada.Text)) {
                txtFimParada.Text = string.Empty;
            }
        }
        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e) {
            if (!validarNumero(txtQuantidade.Text)) {
                txtQuantidade.Text = string.Empty;
            }
        }
        private void txtIntervalo_KeyUp(object sender, KeyEventArgs e) {
            if (!validarNumero(txtIntervalo.Text)) {
                txtIntervalo.Text = string.Empty;
            }
        }

        protected bool validarNumero(string value) {
            int Value = 0;
            return int.TryParse(value, out Value);
        }

        private void btn_ProcessoClick(object sender, System.EventArgs e) {
            long chegada = 0, intervalo = 0;

            if (txtNomeProcesso.Text == "") {
                MessageBox.Show("Insert the process name.");
            } else if (!long.TryParse(txtQuantProcesso.Text, out chegada)) {
                MessageBox.Show("Insert the start time of the process");
            } else if (!long.TryParse(txtIntervalo.Text, out intervalo)) {
                MessageBox.Show("Insert the interval between the start of threads.");
            } else {
                Processo processo = new Processo() {
                    Codigo = listaProcesso.Count + 1,
                    Nome = txtNomeProcesso.Text,
                    Intervalo = intervalo,
                    Chegada = chegada
                };

                listaProcesso.Add(processo);

                lB_Processo.Items.Add("|| " + processo.Codigo.ToString("000") + "  || " + processo.Nome + "\t     || " + processo.Chegada.ToString("00000") + "     || " + processo.Intervalo.ToString("000") + "         ||");
                cBThreadProcesso.Items.Insert(processo.Codigo, processo.Nome);
            }
        }
        private void btn_ThreadClick(object sender, EventArgs e) {
            int processo = cBThreadProcesso.SelectedIndex;

            if (processo == 0) {
                MessageBox.Show("Select a Process");
            } else {
                int tamanho = 0, quantidade = 0;

                if (!int.TryParse(txtThreadTamanho.Text, out tamanho)) {
                    MessageBox.Show("Add the size of thread.");
                } else if (!int.TryParse(txtQuantidade.Text, out quantidade)) {
                    MessageBox.Show("Add the quantity of threads.");
                } else {
                    Processo cProcesso = listaProcesso.Find(p => p.Codigo == processo);
                    int valorCodigo = listaThread.Count + 1;

                    for (var i = 0; i < quantidade; i++) {
                        Thread thread = new Thread();
                        thread.Codigo = valorCodigo + i;
                        thread.CodigoProcesso = processo;
                        thread.NomeProcesso = cProcesso.Nome;
                        thread.Instancia = cProcesso.Chegada + (i * cProcesso.Intervalo);
                        thread.Tamanho = tamanho;

                        listaThread.Add(thread);
                    }

                    lb_Thread.Items.Add("|| " + cProcesso.Codigo.ToString("000") + "          || " + quantidade.ToString("000000") + "          || " + tamanho.ToString("00000") + "\t        ||");
                }
            }
        }
        private void btnParada_Click(object sender, EventArgs e) {
            int inicio = 0, fim = 0;
            if (!int.TryParse(txtInicioParada.Text, out inicio)) {
                MessageBox.Show("Inform the start of the idle time.");
            } else if (!int.TryParse(txtFimParada.Text, out fim)) {
                MessageBox.Show("Inform the end of the idle time.");
            } else if (fim < inicio) {
                MessageBox.Show("The end has to be bigger than the start.");
            } else {
                Parada parada = new Parada() {
                    Codigo = listaParada.Count + 1,
                    Inicio = inicio,
                    Fim = fim
                };

                listaParada.Add(parada);
                lB_Parada.Items.Add("|| " + parada.Codigo.ToString("000") + "\t|| " + parada.Inicio.ToString("0000") + "\t\t|| " + parada.Fim.ToString("0000") + "\t       ||");
            }
        }
        private void btn_Calcular_Click(object sender, EventArgs e) {
            List<Processo> listaInternaProcesso = listaProcesso.Where(p => listaThread.Where(o => o.CodigoProcesso == p.Codigo).Count() == 0).ToList();

            long execucao = 0;

            if (!long.TryParse(txtInicio.Text, out execucao)) {
                MessageBox.Show("Inform the start time");
            } else if (listaInternaProcesso.Count > 0) {
                MessageBox.Show("There is/are " + listaInternaProcesso.Count.ToString("000") + " process without thread");
            } else {
                listaInternaProcesso = listaProcesso.OrderBy(p => p.Chegada).ToList();
                //Ordenar Por processo então por chegado da thread
                List<Thread> listaInternaThread = listaThread.OrderBy(p => listaInternaProcesso.FindIndex(o => o.Codigo == p.CodigoProcesso)).ThenBy(p => p.Instancia).ToList();
                //Remover Paradas ao qual o final é antes de começar a execução do processo
                List<Parada> listaInternaParada = listaParada.Where(p => p.Fim > execucao).OrderBy(p => p.Inicio).ThenBy(p => p.Fim).ToList();

                List<string> listaExecucao = new List<string>();
                listaExecucao.Add("PROCESS || THREAD || START || END ");
                listaExecucao.Add("Start of Execution: " + execucao.ToString("00000"));
                long temp;

                string Processo;
                long Thread;

                //Só é necessário por causa das paradas
                while (listaInternaParada.Count > 0) {
                    if (listaInternaParada[0].Fim <= execucao) {
                        listaInternaParada.RemoveAt(0);
                    } else if (listaInternaParada[0].Inicio <= execucao) {
                        listaExecucao.Add("-- STOP || ------ || " + execucao.ToString("0000000") + " || " + listaInternaParada[0].Fim.ToString("0000000"));
                        execucao = listaInternaParada[0].Fim + 1;
                        listaInternaParada.RemoveAt(0);
                    } else if (listaInternaThread.Count > 0 && listaInternaThread[0].Instancia <= execucao) {
                        temp = execucao + listaInternaThread[0].Tamanho;

                        Processo = listaInternaThread[0].NomeProcesso;
                        Thread = listaInternaThread[0].Codigo;

                        if (listaInternaParada[0].Inicio <= temp) {
                            temp = listaInternaParada[0].Inicio - 1;
                            listaInternaThread[0].Tamanho = temp - execucao;
                        } else {
                            listaInternaThread.RemoveAt(0);
                        }

                        listaExecucao.Add(Processo + " || " + Thread.ToString("000000") + " || " + execucao.ToString("0000000") + " || " + temp.ToString("0000000"));
                        execucao = temp + 1;
                    } else {
                        temp = listaInternaParada[0].Inicio - 1;

                        if (listaInternaThread.Count > 0 && listaInternaThread[0].Instancia < temp) {
                            temp = listaInternaThread[0].Instancia - 1;
                        }

                        listaExecucao.Add("-- IDLE || ------ || " + execucao.ToString("0000000") + " || " + temp.ToString("0000000"));
                        execucao = temp + 1;
                    }
                }

                foreach (var item in listaInternaThread) {
                    if (item.Instancia > execucao) {
                        temp = item.Instancia - 1;

                        listaExecucao.Add("-- IDLE || ------ || " + execucao.ToString("0000000") + " || " + temp.ToString("0000000"));
                        execucao = temp + 1;
                    }

                    temp = execucao + item.Tamanho;

                    listaExecucao.Add(item.NomeProcesso + " || " + item.Codigo.ToString("000000") + " || " + execucao.ToString("0000000") + " || " + temp.ToString("0000000"));
                    execucao = temp + 1;
                }

                string nome = "Process " + DateTime.Now.ToString("yyyyMMddhhmm") + ".txt";
                FileStream file = File.Create(nome);
                file.Close();

                File.WriteAllLines(nome, listaExecucao.ToArray());

                MessageBox.Show("The archive has been created.");
            }
        }
        #region Classes
        public class Processo {
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public long Chegada { get; set; }
            public long Intervalo { get; set; }
        }
        public class Thread {
            public int Codigo { get; set; }
            public int CodigoProcesso { get; set; }
            public string NomeProcesso { get; set; }
            public long Instancia { get; set; }
            public long Tamanho { get; set; }
        }
        public class Parada {
            public int Codigo { get; set; }
            public long Inicio { get; set; }
            public long Fim { get; set; }
        }
        #endregion
    }
}