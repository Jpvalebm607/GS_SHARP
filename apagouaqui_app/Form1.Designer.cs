namespace apagouaqui_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonRegistrarFalha = new Button();
            label1 = new Label();
            dateTimePickerDataFalha = new DateTimePicker();
            label2 = new Label();
            textBoxDescricaoFalha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxItemPrejuizo = new TextBox();
            textBoxValorPrejuizo = new TextBox();
            buttonRegistrarPrejuizo = new Button();
            buttonGerarRelatorio = new Button();
            buttonExportarPDF = new Button();
            label5 = new Label();
            dataGridViewHistorico = new DataGridView();
            ColunaResumo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorico).BeginInit();
            SuspendLayout();
            // 
            // buttonRegistrarFalha
            // 
            buttonRegistrarFalha.Location = new Point(113, 206);
            buttonRegistrarFalha.Name = "buttonRegistrarFalha";
            buttonRegistrarFalha.Size = new Size(119, 29);
            buttonRegistrarFalha.TabIndex = 0;
            buttonRegistrarFalha.Text = "Registrar Falha";
            buttonRegistrarFalha.UseVisualStyleBackColor = true;
            buttonRegistrarFalha.Click += buttonRegistrarFalha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 47);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Data da Falha";
            // 
            // dateTimePickerDataFalha
            // 
            dateTimePickerDataFalha.Location = new Point(207, 42);
            dateTimePickerDataFalha.Name = "dateTimePickerDataFalha";
            dateTimePickerDataFalha.Size = new Size(300, 27);
            dateTimePickerDataFalha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 103);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 3;
            label2.Text = "Descrição da Falha";
            // 
            // textBoxDescricaoFalha
            // 
            textBoxDescricaoFalha.Location = new Point(113, 144);
            textBoxDescricaoFalha.Multiline = true;
            textBoxDescricaoFalha.Name = "textBoxDescricaoFalha";
            textBoxDescricaoFalha.Size = new Size(123, 41);
            textBoxDescricaoFalha.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 314);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 5;
            label3.Text = "Ítem com Prejuízo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 380);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 6;
            label4.Text = "Valor do Prejuízo (R$):";
            // 
            // textBoxItemPrejuizo
            // 
            textBoxItemPrejuizo.Location = new Point(231, 311);
            textBoxItemPrejuizo.Name = "textBoxItemPrejuizo";
            textBoxItemPrejuizo.Size = new Size(125, 27);
            textBoxItemPrejuizo.TabIndex = 7;
            // 
            // textBoxValorPrejuizo
            // 
            textBoxValorPrejuizo.Location = new Point(231, 373);
            textBoxValorPrejuizo.Name = "textBoxValorPrejuizo";
            textBoxValorPrejuizo.Size = new Size(125, 27);
            textBoxValorPrejuizo.TabIndex = 8;
            // 
            // buttonRegistrarPrejuizo
            // 
            buttonRegistrarPrejuizo.Location = new Point(129, 429);
            buttonRegistrarPrejuizo.Name = "buttonRegistrarPrejuizo";
            buttonRegistrarPrejuizo.Size = new Size(137, 29);
            buttonRegistrarPrejuizo.TabIndex = 9;
            buttonRegistrarPrejuizo.Text = "Registrar Prejuízo";
            buttonRegistrarPrejuizo.UseVisualStyleBackColor = true;
            buttonRegistrarPrejuizo.Click += buttonRegistrarPrejuizo_Click;
            // 
            // buttonGerarRelatorio
            // 
            buttonGerarRelatorio.Location = new Point(657, 42);
            buttonGerarRelatorio.Name = "buttonGerarRelatorio";
            buttonGerarRelatorio.Size = new Size(129, 29);
            buttonGerarRelatorio.TabIndex = 10;
            buttonGerarRelatorio.Text = "Gerar Relatório";
            buttonGerarRelatorio.UseVisualStyleBackColor = true;
            buttonGerarRelatorio.Click += buttonGerarRelatorio_Click;
            // 
            // buttonExportarPDF
            // 
            buttonExportarPDF.Location = new Point(829, 42);
            buttonExportarPDF.Name = "buttonExportarPDF";
            buttonExportarPDF.Size = new Size(110, 29);
            buttonExportarPDF.TabIndex = 11;
            buttonExportarPDF.Text = "Exportar PDF";
            buttonExportarPDF.UseVisualStyleBackColor = true;
            buttonExportarPDF.Click += buttonExportarPDF_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(731, 132);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 12;
            label5.Text = "Histórico de Eventos:";
            // 
            // dataGridViewHistorico
            // 
            dataGridViewHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorico.Columns.AddRange(new DataGridViewColumn[] { ColunaResumo });
            dataGridViewHistorico.GridColor = SystemColors.Info;
            dataGridViewHistorico.Location = new Point(657, 222);
            dataGridViewHistorico.Name = "dataGridViewHistorico";
            dataGridViewHistorico.RowHeadersWidth = 51;
            dataGridViewHistorico.Size = new Size(300, 188);
            dataGridViewHistorico.TabIndex = 13;
            dataGridViewHistorico.CellContentClick += dataGridViewHistorico_CellContentClick;
            // 
            // ColunaResumo
            // 
            ColunaResumo.HeaderText = "Registro";
            ColunaResumo.MinimumWidth = 6;
            ColunaResumo.Name = "ColunaResumo";
            ColunaResumo.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 516);
            Controls.Add(dataGridViewHistorico);
            Controls.Add(label5);
            Controls.Add(buttonExportarPDF);
            Controls.Add(buttonGerarRelatorio);
            Controls.Add(buttonRegistrarPrejuizo);
            Controls.Add(textBoxValorPrejuizo);
            Controls.Add(textBoxItemPrejuizo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxDescricaoFalha);
            Controls.Add(label2);
            Controls.Add(dateTimePickerDataFalha);
            Controls.Add(label1);
            Controls.Add(buttonRegistrarFalha);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegistrarFalha;
        private Label label1;
        private DateTimePicker dateTimePickerDataFalha;
        private Label label2;
        private TextBox textBoxDescricaoFalha;
        private Label label3;
        private Label label4;
        private TextBox textBoxItemPrejuizo;
        private TextBox textBoxValorPrejuizo;
        private Button buttonRegistrarPrejuizo;
        private Button buttonGerarRelatorio;
        private Button buttonExportarPDF;
        private Label label5;
        private DataGridView dataGridViewHistorico;
        private DataGridViewTextBoxColumn ColunaResumo;
    }
}
