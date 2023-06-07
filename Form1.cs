using System.Collections.Generic;
using version_two.clases;

namespace version_two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simular_Click(object sender, EventArgs e)
        {
            // Lee valores del formulario
            int val_cantidad_clientes = Int32.Parse(cantidad_clientes.Text);
            int val_camiones_disponibles = Int32.Parse(camiones_disponibles.Text);
            int val_demanda_minima = Int32.Parse(demanda_minima.Text);
            int val_demanda_maxima = Int32.Parse(demanda_maxima.Text);
            int val_capacidad_camion = Int32.Parse(capacidad_camion.Text);
            int val_km_dia = 800; //Int32.Parse(km_dia.Text);
            int val_lambda = Int32.Parse(lambda.Text);

            Asignador resultados = new Asignador();
            Simular simulacion = new Simular();

            resultados = simulacion.comenzarSimulacion(
                val_cantidad_clientes,
                val_camiones_disponibles,
                val_demanda_minima,
                val_demanda_maxima,
                val_capacidad_camion,
                val_km_dia,
                val_lambda
                );

            // Crea grid para ver valores
            dgv.Refresh();
            dgv.Columns.Clear();
            dgv.Columns.Add("Camion", "Camion");
            dgv.Columns.Add("Distancia", "Distancia");
            dgv.Columns.Add("Cliente", "Cliente");
            dgv.Columns.Add("Demanda Por entregar", "Demanda Por entregar");
            dgv.Columns.Add("Demanda Entregada", "Demanda Entregada");
            dgv.Columns.Add("Fecha solicitada", "Fecha solicitada");
            dgv.Columns.Add("Fecha entregada", "Fecha entregada");
            dgv.Rows.Clear();

            foreach (Entrega en in resultados.lista_entregas)
            {
                dgv.Rows.Add(en.numero_camion, en.distancia, en.cliente, en.producto, en.demanda_entregada, en.fecha, en.fecha_entregada);
            }

            // de resultados se toman los KPI's
            entregas_ok.Text = resultados.entregas_tiempo.ToString();
            entregas_porcentaje.Text = resultados.entregas_totales.ToString();
            capacidad_total.Text = resultados.cantidad_total.ToString();
            capacidad_en_tiempo.Text = resultados.cantidad_tiempo.ToString();

        }

        private void entregas_ok_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrar_valores_Click(object sender, EventArgs e)
        {
            cantidad_clientes.Text = "";
            camiones_disponibles.Text = "";
            demanda_minima.Text = "";
            demanda_maxima.Text = "";
            capacidad_camion.Text = "";
            //km_dia.Text = "";
            lambda.Text = "";
            entregas_ok.Text = "";
            entregas_porcentaje.Text = "";
            capacidad_total.Text = "";
            capacidad_en_tiempo.Text = "";
            dgv.Rows.Clear();
            dgv.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void entregas_porcentaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void demanda_minima_TextChanged(object sender, EventArgs e)
        {
            {
                int demandaMinima;
                if (!int.TryParse(demanda_minima.Text, out demandaMinima))
                {
                    MessageBox.Show("Prueba con otro numero");
                    demanda_minima.Text = ""; 
                }
                else if (demandaMinima <= 0)
                {
                    MessageBox.Show("No se puede ingresar un valor negativo o cero para la demanda mínima.");
                    demanda_minima.Text = ""; // Prueba con otro numero
                }
            }
        }

        private void demanda_maxima_TextChanged(object sender, EventArgs e)
        {
            {
                int demandaMaxima;
                if (!int.TryParse(demanda_maxima.Text, out demandaMaxima))
                {
                    MessageBox.Show("Pruebe con otro numero.");
                    demanda_maxima.Text = ""; 
                }
                else if (demandaMaxima <= 0)
                {
                    MessageBox.Show("No se puede ingresar un valor negativo o cero para la demanda máxima.");
                    demanda_maxima.Text = ""; // Prueba con otro numero
                }
                
            }
        }

        private void camiones_disponibles_TextChanged(object sender, EventArgs e)
        {
            {
                int camionesDisponibles;
                if (!int.TryParse(camiones_disponibles.Text, out camionesDisponibles))
                {
                    MessageBox.Show("Pruebe con otro numero.");
                    camiones_disponibles.Text = "";
                }
                else if (camionesDisponibles > 3 )
                {
                    MessageBox.Show("No se puede ingresar mas de 3 camiones.");
                    camiones_disponibles.Text = ""; // Prueba con otro numero
                }
            }
        }

        private void cantidad_clientes_TextChanged(object sender, EventArgs e)
        {
            {
                int cantidadClientes;
                if (!int.TryParse(cantidad_clientes.Text, out cantidadClientes))
                {
                    MessageBox.Show("Pruebe con otro numero.");
                    cantidad_clientes.Text = "";
                }
                else if (cantidadClientes <= 0)
                {
                    MessageBox.Show("Tiene que haber uno o mas clientes.");
                    cantidad_clientes.Text = ""; // Prueba con otro numero
                }
            }
        }

        private void lambda_TextChanged(object sender, EventArgs e)
        {
            {
                int lambdatxt;
                if (!int.TryParse(lambda.Text, out lambdatxt))
                {
                    MessageBox.Show("Pruebe con otro numero.");
                    lambda.Text = "";
                }
                else if (lambdatxt <= 0)
                {
                    MessageBox.Show("Lambda no puede ser cero o negativa .");
                    lambda.Text = ""; // Prueba con otro numero
                }
            }
        }

        private void capacidad_camion_TextChanged(object sender, EventArgs e)
        {
            {
                int capacidadCamion;
                if (!int.TryParse(capacidad_camion.Text, out capacidadCamion))
                {
                    MessageBox.Show("Pruebe con otro numero.");
                    capacidad_camion.Text = "";
                }
                else if (capacidadCamion <= 0)
                {
                    MessageBox.Show("La capacidad debe ser mayor a cero");
                    capacidad_camion.Text = ""; // Prueba con otro numero
                }
            }
        }
    }
}



