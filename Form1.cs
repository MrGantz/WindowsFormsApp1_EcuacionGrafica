using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1_EcuacionGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalcula_Click(object sender, EventArgs e)
        {
            string cadena = textBoxFormula.Text;
            string[] tokens = cadena.Split(' ');
            double rinix = -10.0;
            double y = 0.0;
            
            if(tokens.Length == 3)
            {
                double potencia = Convert.ToDouble(tokens[2]);
                int i;
                InicializaGrafico();
                textBoxFormula.Text = "";
                for (i = 0; i <= 20; i++)
                {
                    y = Math.Pow(rinix, potencia);
                    textBoxDatos.Text = textBoxDatos.Text + "           " + rinix.ToString() +
                        "         " + y.ToString() + Environment.NewLine;
                    rinix++;
                    this.chartGraficoA.Series["ValorY"].Points.AddXY(rinix, y);
                }
                labelError.Text = "";
            }
            else
            {
                labelError.Text = "Error de sintaxis";
            }
           
        }

        private void chartGraficoA_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializaGrafico();

            
        }

        void InicializaGrafico()
        {
            this.chartGraficoA.Series.Clear();

            var seriesAY = chartGraficoA.Series.Add("ValorY");
            seriesAY.ChartType = SeriesChartType.Spline;
            seriesAY.XValueType = ChartValueType.Single;
            chartGraficoA.Series["ValorY"].Color = Color.Red;
            seriesAY.YValueType = ChartValueType.Double;
        }
    }
}
