namespace WindowsFormsApp1_EcuacionGrafica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_Salir = new System.Windows.Forms.Button();
            this.buttonCalcula = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxDatos = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartGraficoA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxFormula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficoA)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(675, 368);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 0;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // buttonCalcula
            // 
            this.buttonCalcula.Location = new System.Drawing.Point(170, 12);
            this.buttonCalcula.Name = "buttonCalcula";
            this.buttonCalcula.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcula.TabIndex = 1;
            this.buttonCalcula.Text = "Calcula";
            this.buttonCalcula.UseVisualStyleBackColor = true;
            this.buttonCalcula.Click += new System.EventHandler(this.buttonCalcula_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 348);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxDatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxDatos
            // 
            this.textBoxDatos.Location = new System.Drawing.Point(6, 6);
            this.textBoxDatos.Multiline = true;
            this.textBoxDatos.Name = "textBoxDatos";
            this.textBoxDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDatos.Size = new System.Drawing.Size(329, 296);
            this.textBoxDatos.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartGraficoA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gráfica";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartGraficoA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGraficoA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGraficoA.Legends.Add(legend3);
            this.chartGraficoA.Location = new System.Drawing.Point(0, 0);
            this.chartGraficoA.Name = "chartGraficoA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartGraficoA.Series.Add(series3);
            this.chartGraficoA.Size = new System.Drawing.Size(661, 322);
            this.chartGraficoA.TabIndex = 0;
            this.chartGraficoA.Text = "chartGraficoA";
            this.chartGraficoA.Click += new System.EventHandler(this.chartGraficoA_Click);
            // 
            // textBoxFormula
            // 
            this.textBoxFormula.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFormula.Location = new System.Drawing.Point(85, 9);
            this.textBoxFormula.Name = "textBoxFormula";
            this.textBoxFormula.Size = new System.Drawing.Size(67, 29);
            this.textBoxFormula.TabIndex = 3;
            this.textBoxFormula.Text = "x ^ 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Formula y =";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(330, 14);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFormula);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCalcula);
            this.Controls.Add(this.button_Salir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficoA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button buttonCalcula;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxDatos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraficoA;
        private System.Windows.Forms.TextBox textBoxFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;
    }
}

