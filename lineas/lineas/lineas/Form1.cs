using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Autor: Oscar David Ramos Calzada
/// fecha: 08-03-2022
/// Proyecto: Dibujar lineas 
/// </summary>
namespace wLineas
{
    public partial class Form1 : Form
    {
        Graphics grafico;
        public Form1()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btndibujarLineas_Click(object sender, EventArgs e)
        {
            try
            {
                double xInicio = double.Parse(txtXInicial.Text);
                double yInicio = double.Parse(txtYInicial.Text);
                double xFinal = double.Parse(txtXFinal.Text);
                double yFinal = double.Parse(txtYFinal.Text);

                clsLineas wLineas = new clsLineas(xInicio, yInicio, xFinal, yFinal);

                Pen blackPen = new Pen(Color.Black, 3);

                PointF point1 = new PointF(wLineas.obtenXInicio(), wLineas.obtenYInicio());
                PointF point2 = new PointF(wLineas.obtenXFinal(), wLineas.obtenYFinal());

                grafico.DrawLine(blackPen, point1, point2);

                txtcantidadLineas.Text = Convert.ToString(clsLineas.obtenCuenta());

            }
            catch (Exception)
            {

                MessageBox.Show("Digite caracteres validos");
            }
        }
    }
}
