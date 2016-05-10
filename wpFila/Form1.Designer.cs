namespace wpFila
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Processos = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.btn_Processo = new System.Windows.Forms.Button();
            this.lB_Processo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantProcesso = new System.Windows.Forms.TextBox();
            this.txtNomeProcesso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Thread = new System.Windows.Forms.Button();
            this.txtThreadTamanho = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Thread = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBThreadProcesso = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnParada = new System.Windows.Forms.Button();
            this.txtFimParada = new System.Windows.Forms.TextBox();
            this.txtInicioParada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lB_Parada = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Processos.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Processos
            // 
            this.Processos.Controls.Add(this.tabPage4);
            this.Processos.Controls.Add(this.tabPage1);
            this.Processos.Controls.Add(this.tabPage2);
            this.Processos.Controls.Add(this.tabPage3);
            this.Processos.Location = new System.Drawing.Point(11, 9);
            this.Processos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Processos.Name = "Processos";
            this.Processos.SelectedIndex = 0;
            this.Processos.Size = new System.Drawing.Size(241, 264);
            this.Processos.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_Calcular);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtInicio);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(233, 238);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Início";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(88, 95);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(56, 19);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Gerar";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Início do CPU:";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(88, 29);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInicio.MaxLength = 4;
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(66, 20);
            this.txtInicio.TabIndex = 0;
            this.txtInicio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInicio_KeyUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtIntervalo);
            this.tabPage1.Controls.Add(this.btn_Processo);
            this.tabPage1.Controls.Add(this.lB_Processo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtQuantProcesso);
            this.tabPage1.Controls.Add(this.txtNomeProcesso);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(233, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Processos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Intervalo:";
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(182, 35);
            this.txtIntervalo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIntervalo.MaxLength = 3;
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(50, 20);
            this.txtIntervalo.TabIndex = 6;
            this.txtIntervalo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIntervalo_KeyUp);
            // 
            // btn_Processo
            // 
            this.btn_Processo.Location = new System.Drawing.Point(170, 58);
            this.btn_Processo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Processo.Name = "btn_Processo";
            this.btn_Processo.Size = new System.Drawing.Size(60, 21);
            this.btn_Processo.TabIndex = 5;
            this.btn_Processo.Text = "Adicionar";
            this.btn_Processo.UseVisualStyleBackColor = true;
            this.btn_Processo.Click += new System.EventHandler(this.btn_ProcessoClick);
            // 
            // lB_Processo
            // 
            this.lB_Processo.FormattingEnabled = true;
            this.lB_Processo.Location = new System.Drawing.Point(4, 89);
            this.lB_Processo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lB_Processo.Name = "lB_Processo";
            this.lB_Processo.Size = new System.Drawing.Size(227, 147);
            this.lB_Processo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Início:";
            // 
            // txtQuantProcesso
            // 
            this.txtQuantProcesso.Location = new System.Drawing.Point(51, 34);
            this.txtQuantProcesso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantProcesso.MaxLength = 5;
            this.txtQuantProcesso.Name = "txtQuantProcesso";
            this.txtQuantProcesso.Size = new System.Drawing.Size(50, 20);
            this.txtQuantProcesso.TabIndex = 2;
            this.txtQuantProcesso.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantGrupo_KeyUp);
            // 
            // txtNomeProcesso
            // 
            this.txtNomeProcesso.Location = new System.Drawing.Point(51, 11);
            this.txtNomeProcesso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeProcesso.MaxLength = 10;
            this.txtNomeProcesso.Name = "txtNomeProcesso";
            this.txtNomeProcesso.Size = new System.Drawing.Size(180, 20);
            this.txtNomeProcesso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtQuantidade);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_Thread);
            this.tabPage2.Controls.Add(this.txtThreadTamanho);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lb_Thread);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cBThreadProcesso);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(233, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Threads";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(58, 36);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantidade.MaxLength = 6;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(50, 20);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Qnt:";
            // 
            // btn_Thread
            // 
            this.btn_Thread.Location = new System.Drawing.Point(174, 57);
            this.btn_Thread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Thread.Name = "btn_Thread";
            this.btn_Thread.Size = new System.Drawing.Size(59, 21);
            this.btn_Thread.TabIndex = 7;
            this.btn_Thread.Text = "Adicionar";
            this.btn_Thread.UseVisualStyleBackColor = true;
            this.btn_Thread.Click += new System.EventHandler(this.btn_ThreadClick);
            // 
            // txtThreadTamanho
            // 
            this.txtThreadTamanho.Location = new System.Drawing.Point(181, 36);
            this.txtThreadTamanho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtThreadTamanho.MaxLength = 5;
            this.txtThreadTamanho.Name = "txtThreadTamanho";
            this.txtThreadTamanho.Size = new System.Drawing.Size(50, 20);
            this.txtThreadTamanho.TabIndex = 2;
            this.txtThreadTamanho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtThreadTamanho_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tamanho:";
            // 
            // lb_Thread
            // 
            this.lb_Thread.FormattingEnabled = true;
            this.lb_Thread.Location = new System.Drawing.Point(4, 89);
            this.lb_Thread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_Thread.Name = "lb_Thread";
            this.lb_Thread.Size = new System.Drawing.Size(227, 147);
            this.lb_Thread.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Processo:";
            // 
            // cBThreadProcesso
            // 
            this.cBThreadProcesso.FormattingEnabled = true;
            this.cBThreadProcesso.Location = new System.Drawing.Point(58, 11);
            this.cBThreadProcesso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBThreadProcesso.Name = "cBThreadProcesso";
            this.cBThreadProcesso.Size = new System.Drawing.Size(173, 21);
            this.cBThreadProcesso.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnParada);
            this.tabPage3.Controls.Add(this.txtFimParada);
            this.tabPage3.Controls.Add(this.txtInicioParada);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.lB_Parada);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(233, 238);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Paradas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnParada
            // 
            this.btnParada.Location = new System.Drawing.Point(163, 32);
            this.btnParada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParada.Name = "btnParada";
            this.btnParada.Size = new System.Drawing.Size(56, 19);
            this.btnParada.TabIndex = 6;
            this.btnParada.Text = "Adicionar";
            this.btnParada.UseVisualStyleBackColor = true;
            this.btnParada.Click += new System.EventHandler(this.btnParada_Click);
            // 
            // txtFimParada
            // 
            this.txtFimParada.Location = new System.Drawing.Point(154, 9);
            this.txtFimParada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFimParada.MaxLength = 4;
            this.txtFimParada.Name = "txtFimParada";
            this.txtFimParada.Size = new System.Drawing.Size(66, 20);
            this.txtFimParada.TabIndex = 5;
            this.txtFimParada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFimParada_KeyUp);
            // 
            // txtInicioParada
            // 
            this.txtInicioParada.Location = new System.Drawing.Point(46, 9);
            this.txtInicioParada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInicioParada.MaxLength = 4;
            this.txtInicioParada.Name = "txtInicioParada";
            this.txtInicioParada.Size = new System.Drawing.Size(66, 20);
            this.txtInicioParada.TabIndex = 4;
            this.txtInicioParada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInicioParada_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Inicio";
            // 
            // lB_Parada
            // 
            this.lB_Parada.FormattingEnabled = true;
            this.lB_Parada.Location = new System.Drawing.Point(4, 73);
            this.lB_Parada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lB_Parada.Name = "lB_Parada";
            this.lB_Parada.Size = new System.Drawing.Size(227, 160);
            this.lB_Parada.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-33, -76);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(91, 69);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(256, 284);
            this.Controls.Add(this.Processos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Processos.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Processos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNomeProcesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantProcesso;
        private System.Windows.Forms.ListBox lB_Processo;
        private System.Windows.Forms.ComboBox cBThreadProcesso;
        private System.Windows.Forms.Button btn_Processo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_Thread;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThreadTamanho;
        private System.Windows.Forms.Button btn_Thread;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.ListBox lB_Parada;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInicioParada;
        private System.Windows.Forms.TextBox txtFimParada;
        private System.Windows.Forms.Button btnParada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIntervalo;

    }
}

