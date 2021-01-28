using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSim
{
    public partial class RapiPago : Form

    {
        private DataTable dt;
        DataTable dtRango;

        private static Random RND = new Random();
        DataRow dr;

        //Control
        //Rango r;
        int paso = 0;
        int numIteraciones = 0;
        int prueba = 0;
        int desde = 0;
        int hasta = 0;


        //Reloj
        double Reloj = 0;

        //Servicios
        string eventoFinaliza = "";
        double finAtencionServicio = 0;
        int idFinAtencion = 0;
        int cantSimulaciones = 0;

        // Generar RND Llegada
        private static Random RNDLlegada = new Random();

        //Clientes
        Cliente cliente;
        double cantClientes = 0;
        double clientesAtendidos = 0;
        private double A;
        private double B;

        // Cantidad de clientes que se van a crear
        int idClientes = 0;

        //Gas
        double tiempoLlegadaGas = 0;
        double proxLlegadaGas = 0;

        //Telefono
        double tiempoLlegadaTel = 0;
        double proxLlegadaTel = 0;

        //Caja
        Caja caja = new Caja();
        Cliente clienteAtencionCaja = new Cliente();
        Cliente clienteEsperaCaja = new Cliente();

        // Estadistica

        double promEsperaTel = 0;
        double promEsperaGas = 0;
        double contadorClientesTel = 0;
        double contadorClientesGas = 0;
        double acumuladorTelefono = 0;
        double acumuladorGas = 0;

        // Mayor para las estadisticas
        double mayor = 0;


        public RapiPago()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_desde.Text = "0";
            txt_hasta.Text = "10";
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            // Limpio todos los campos          
            dgv_simulacion.DataSource = null;
            dgv_simulacion.Refresh();

            // Seteo de objetos
            paso = 0;

            //Reloj
            Reloj = 0;

            idClientes = 0; // Porque todavia nose cuantos voy a crear

            // Estadistica

            promEsperaTel = 0;
            promEsperaGas = 0;
            contadorClientesTel = 0;
            contadorClientesGas = 0;
            acumuladorTelefono = 0;
            acumuladorGas = 0;

            //Cola max
            mayor = 0;

            //Caja
            caja = new Caja();
            clienteAtencionCaja = new Cliente();
            clienteEsperaCaja = new Cliente();

            //Clientes
            cantClientes = 0;
            clientesAtendidos = 0;

            //Servicios
            cantSimulaciones = 0;
            idFinAtencion = 0;

            

            // Resultados a mostrar primero ocultos 
            txt_Cola.Visible = false;
            txt_promGas.Visible = false;
            txt_promTelef.Visible = false;
            lbl_cola.Visible = false;
            lbl_promGas.Visible = false;
            lbl_promTele.Visible = false;
      
            this.generar_tabla();
        }

        private void generar_tabla()
        {
            dt = new DataTable();

            //Crear todos las columnas menos la de cliente
            inicializarColumnas();

            // Obtengo la cantidad de clientes
            if (txt_clientes.Text != "")
            {
                cantClientes = Convert.ToDouble(txt_clientes.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar la cantidad de clientes a simular");
                return;
            }

            // Obtener Rango
            if (txt_desde.Text != "" && txt_hasta.Text != "")
            {
                desde = Convert.ToInt32(txt_desde.Text);
                hasta = Convert.ToInt32(txt_hasta.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar desde/hasta para simular");
                return;
            }

            if (desde > hasta)
            {
                MessageBox.Show("El valor de desde debe ser menor que el valor de hasta");
                return;
            }


            // Con esto hago que parta del rango mostrado
            numIteraciones = desde;

            // iniciarPrimeraFila, simulacion 0
            iniciarPrimeraFila();


            //Simulacion de 1 en adelante
            dtRango = dt.Clone();

            while (clientesAtendidos <= cantClientes) /////// aca me muestra hasta que atiende al numero que ponga en la cantidad
            {
                dr = dt.NewRow();

                // Hora del reloj Determino aca y el evento correspondiente--------------------
                switch (eventoFinaliza)
                {
                    case ("LlegadaTelefono"):
                        Reloj = finAtencionServicio;
                        //Creacion del cliente
                        idClientes = idClientes + 1;
                        cliente = new Cliente();
                        cliente.Id = idClientes;
                        cliente.tipoServicio = 1; // 1: Telefono
                        cliente.horaLlegada = Reloj;     //// finAtencionServicio - hora llegada - tiempoAtencion 

                        dr["Evento"] = "Llegada cliente tel" + idClientes;

                        // Proximo CLIENTE Telefono
                        double RND2 = RND.NextDouble();
                        tiempoLlegadaTel = tiempoAtencion(RND2, 1);
                        proxLlegadaTel = tiempoLlegadaTel + Reloj;
                        dr["RNDTel"] = Math.Round(RND2, 4);
                        dr["TiempoLlegTel"] = tiempoLlegadaTel;
                        dr["ProxLlegTel"] = proxLlegadaTel;

                        break;

                    case ("LlegadaGas"):
                        Reloj = finAtencionServicio;
                        //Creacion del cliente
                        idClientes = idClientes + 1;
                        cliente = new Cliente();
                        cliente.Id = idClientes;
                        cliente.tipoServicio = 0; // tipo Gas
                        cliente.horaLlegada = Reloj;

                        dr["Evento"] = "Llegada cliente gas" + idClientes;

                        // Proximo CLIENTE Gas
                        double RND3 = RND.NextDouble();
                        tiempoLlegadaGas = tiempoAtencion(RND3, 0);
                        proxLlegadaGas = tiempoLlegadaGas + Reloj;
                        dr["RNDGas"] = Math.Round(RND3, 4);
                        dr["TiempoLlegGas"] = tiempoLlegadaGas;
                        dr["ProxLlegGas"] = proxLlegadaGas;

                        break;

                    case ("Caja"):
                        Reloj = finAtencionServicio;
                        dr["Evento"] = "Fin Atencion Cliente " + idFinAtencion;
                        if (clienteAtencionCaja != null) servCaja();
                        break;
                }

                // MUESTRO LAS COLUMNAS COMPLETAS

                // Gas...................................................................
                if (proxLlegadaGas < 1000000000)
                {
                    dr["ProxLlegGas"] = Convert.ToString(Math.Round(proxLlegadaGas,2)); ///////////////
                }
                else
                {
                    dr["ProxLlegGas"] = "";
                }

                //Telefono.............................................................................
                if (proxLlegadaTel < 10000000000)
                {
                    dr["ProxLlegTel"] = Convert.ToString(Math.Round(proxLlegadaTel, 2));
                }
                else
                {
                    dr["ProxLlegTel"] = "";
                }

                // Caja...................................................................
                if (caja.finAtencion < 1000000)
                {
                    dr["FinTiempo AtencionCaja"] = Convert.ToString(Math.Round(caja.finAtencion, 2));
                }
                else
                {
                    dr["FinTiempo AtencionCaja"] = "";
                }

                dr["\nColaCaja"] = caja.cola.Count();
                dr["EstadoCaja"] = caja.Estado;

                // Estadisticas.............................................................
                dr["contClienTelef"] = contadorClientesTel;
                dr["acumTelefono"] = Math.Round(acumuladorTelefono, 2);
                dr["contClienGas"] = contadorClientesGas;
                dr["acumGas"] = Math.Round(acumuladorGas, 2);

                // Reloj.....................................................................
                dr["Reloj"] = Math.Round(Reloj, 2);

                // Ultima fila para guardar en la grilla para ver los datos que me pide el enunciado----me muestra cuando se va el ultimo cliente que puse en la cantidad----------- 
                if (clientesAtendidos == cantClientes)
                {
                    paso++;
                    dt.Rows.Add(dr);
                }

                //Termino cuando cumple la cantidad de clientes atendidos
                if (clientesAtendidos == cantClientes)
                {
                    break;
                    //cantVueltas = 1; 
                }


                // Atencion Caja, aca entran los clientes para ser atendidos
                if (cliente != null)
                {
                    //Cliente en atencion 
                    if (caja.Estado == "L")
                    {
                        clienteAtencionCaja = cliente;
                        cliente = null;
                        servCaja();

                    }
                    //Cliente en espera
                    else
                    {
                        clienteEsperaCaja = cliente;
                        cliente = null;
                        servCaja();
                    }
                }

                if (cantSimulaciones >= desde && cantSimulaciones <= hasta)
                {
                    // Mostrar los clientes 
                    if (clienteAtencionCaja != null)
                    {
                        mostrarClientesCaja2();
                    }
                }

                // metodo mayor cola
                ObtenerColaMaxima();

                // Determinar que evento Finaliza
                DeterminarEventoFinaliza();
                switch (eventoFinaliza)
                {
                    case ("LlegadaTelefono"):
                        finAtencionServicio = proxLlegadaTel;
                        break;

                    case ("LlegadaGas"):
                        finAtencionServicio = proxLlegadaGas;
                        break;

                    case ("Caja"):
                        finAtencionServicio = caja.finAtencion;
                        idFinAtencion = clienteAtencionCaja.Id;
                        // Calculo el tiempo espera cliente
                        clienteAtencionCaja.calcularTiempoDemora();

                        //Telefono
                        if (clienteAtencionCaja.tipoServicio == 1)
                        {
                            contadorClientesTel++;
                            acumuladorTelefono += clienteAtencionCaja.tiempoEspera;
                            acumuladorTelefono = Math.Round(acumuladorTelefono, 2);
                        }

                        //Gas
                        else
                        {
                            contadorClientesGas++;
                            acumuladorGas += clienteAtencionCaja.tiempoEspera;
                            acumuladorGas = Math.Round(acumuladorGas, 2);
                        }

                        clientesAtendidos = contadorClientesTel + contadorClientesGas;
                        FinAtencionCaja();

                        break;
                }

                cantSimulaciones++;
                prueba++;

                dr["NroSimulacion"] = cantSimulaciones;
                //dr["NroSimulacion"] = numIteraciones;

                if (cantSimulaciones >= desde && cantSimulaciones <= hasta)
                {
                    dt.Rows.Add(dr);
                    numIteraciones++;
                }
            }

            this.dgv_simulacion.DataSource = dt; // para que se visualicen los datos en la grilla

            colorColumnas();
            obtenerResultados();
        }


        private void inicializarColumnas()
        {
            dt.Rows.Clear();

            dt.Columns.Add("NroSimulacion", typeof(int));
            dt.Columns.Add("Evento", typeof(string));
            dt.Columns.Add("Reloj", typeof(double));

            // LLEGADA CLIENTE Telefono
            dt.Columns.Add("RNDTel", typeof(double));
            dt.Columns.Add("TiempoLlegTel", typeof(double));
            dt.Columns.Add("ProxLlegTel", typeof(double)); ;

            // LLEGADA CLIENTE Gas
            dt.Columns.Add("RNDGas", typeof(double));
            dt.Columns.Add("TiempoLlegGas", typeof(double));
            dt.Columns.Add("ProxLlegGas", typeof(double)); ;

            //Caja
            dt.Columns.Add("RNDCaja", typeof(double));
            dt.Columns.Add("Tiempo AtencionCaja", typeof(double));
            dt.Columns.Add("FinTiempo AtencionCaja", typeof(string));
            dt.Columns.Add("EstadoCaja", typeof(string));
            dt.Columns.Add("\nColaCaja", typeof(Int32));

            // Estadisticas
            dt.Columns.Add("contClienTelef", typeof(double));
            dt.Columns.Add("acumTelefono", typeof(double));
            dt.Columns.Add("contClienGas", typeof(double));
            dt.Columns.Add("acumGas", typeof(double));
            dt.Columns.Add("Clientes", typeof(string));
            dt.Columns.Add(" ", typeof(string));
        }

        private void iniciarPrimeraFila()
        {
            DataRow dr = dt.NewRow();

            dr["Evento"] = "Inicio";
            dr["Reloj"] = 0.0;
            dr["NroSimulacion"] = 0;

            // LLEGADA CLIENTE Telefono
            double RND2 = RND.NextDouble();
            tiempoLlegadaTel = tiempoAtencion(RND2, 1);
            proxLlegadaTel = tiempoLlegadaTel + Reloj;
            dr["RNDTel"] = Math.Round(RND2, 4);
            dr["TiempoLlegTel"] = tiempoLlegadaTel;
            dr["ProxLlegTel"] = proxLlegadaTel;

            // LLEGADA CLIENTE Gas
            double RND3 = RND.NextDouble();
            tiempoLlegadaGas = tiempoAtencion(RND3, 0);
            proxLlegadaGas = tiempoLlegadaGas + Reloj;
            dr["RNDGas"] = Math.Round(RND3, 4);
            dr["TiempoLlegGas"] = tiempoLlegadaGas;
            dr["ProxLlegGas"] = proxLlegadaGas;

            // OBJETO Caja
            dr["EstadoCaja"] = "L";
            dr["\nColaCaja"] = 0;

            // Estadisticas
            dr["contClienTelef"] = 0;
            dr["acumTelefono"] = 0;
            dr["contClienGas"] = 0;
            dr["acumGas"] = 0;

            if (proxLlegadaTel <= proxLlegadaGas)
            {
                eventoFinaliza = "LlegadaTelefono";
                finAtencionServicio = proxLlegadaTel;
            }
            else
            {
                eventoFinaliza = "LlegadaGas";
                finAtencionServicio = proxLlegadaGas;
            }
            if (desde == 0)
            {
                dt.Rows.Add(dr);
            }
        }

        // Pintar columnas
        private void colorColumnas()
        {
            // LlegadaCliente Telefono
            Color llegClienteTelefono = Color.LightPink;
            lbl_telefono.BackColor = llegClienteTelefono;
            lbl_telefono.Visible = true;
            dgv_simulacion.Columns[3].DefaultCellStyle.BackColor = llegClienteTelefono;
            dgv_simulacion.Columns[4].DefaultCellStyle.BackColor = llegClienteTelefono;
            dgv_simulacion.Columns[5].DefaultCellStyle.BackColor = llegClienteTelefono;
            
            // LlegadaCliente Gas
            Color llegClienteGas = Color.LightGoldenrodYellow;
            lbl_gas.BackColor = llegClienteGas;
            lbl_gas.Visible = true;
            dgv_simulacion.Columns[6].DefaultCellStyle.BackColor = llegClienteGas;
            dgv_simulacion.Columns[7].DefaultCellStyle.BackColor = llegClienteGas;
            dgv_simulacion.Columns[8].DefaultCellStyle.BackColor = llegClienteGas;
            
            // Caja
            Color caja = Color.LightSteelBlue;
            lbl_caja.BackColor = caja;
            lbl_caja.Visible = true;
            dgv_simulacion.Columns[9].DefaultCellStyle.BackColor = caja;
            dgv_simulacion.Columns[10].DefaultCellStyle.BackColor = caja;
            dgv_simulacion.Columns[11].DefaultCellStyle.BackColor = caja;
            dgv_simulacion.Columns[12].DefaultCellStyle.BackColor = caja;
        }

        public void obtenerResultados()
        {
            txt_Cola.Visible = true;
            txt_promGas.Visible = true;
            txt_promTelef.Visible = true;
            lbl_cola.Visible = true;
            lbl_promGas.Visible = true;
            lbl_promTele.Visible = true;

            // ColaMaxima
            txt_Cola.Text = Convert.ToString(mayor);

            // Promedio Telefono
            if (contadorClientesTel > 0)
            {
                promEsperaTel = acumuladorTelefono / contadorClientesTel;

                promEsperaTel = Math.Round(promEsperaTel, 4);

                txt_promTelef.Text = Convert.ToString(promEsperaTel);
            }

            // Promedio Gas
            if (contadorClientesGas > 0)
            {
                promEsperaGas = acumuladorGas / contadorClientesGas;

                promEsperaGas = Math.Round(promEsperaGas, 4);

                txt_promGas.Text = Convert.ToString(promEsperaGas);
            }
        }


        public void ObtenerColaMaxima() 
        {
            if (caja.cola.Count() > mayor)
            {
                mayor = caja.cola.Count();
            }
        }

        public double tiempoAtencion(double RND, int tipoServicio)
        {
            // Telefono
            if (tipoServicio == 1)
            {
                A = 30.0 / 60.0; B = 170.0 / 60.0;
                return Math.Round(RND * (B - A) + A, 2);
            }
            //Gas
            else
            {
                A = 50.0 / 60.0; B = 110.0 / 60.0;
                return Math.Round(RND * (B - A) + A, 2);
            }
        }

        public void DeterminarEventoFinaliza()
        {
            // uso return asi el if que es true lo corta no sigue preguntando 
            double minimo = menor(proxLlegadaTel, proxLlegadaGas, caja.finAtencion);


            if (proxLlegadaTel == minimo)
            {
                eventoFinaliza = "LlegadaTelefono";
                return;
            }

            if (proxLlegadaGas == minimo)
            {
                eventoFinaliza = "LlegadaGas";
                return;
            }
            if (caja.finAtencion == minimo)
            {
                eventoFinaliza = "Caja";
                return;
            }
        }

        public double menor(double t1, double g1, double caja)
        {
            double[] vec;
            vec = new double[3];
            vec[0] = t1;
            vec[1] = g1;
            vec[2] = caja;
            double min = vec[0];
            for (int i = 1; i < vec.Length; i++)
            {
                if (min >= vec[i])
                {
                    min = vec[i];
                }
            }
            return min;
        }

        // Caja---------------------------------------------------------
        public void servCaja()
        {
            if (caja.Estado == "L")
            {
                clienteAtencionCaja.Estado = "SA";
                caja.Estado = "Oc";

                double RND2 = RND.NextDouble();
                caja.tiempoAtender = caja.tiempoAtencion(RND2);
                caja.finAtencion = caja.tiempoAtender + Reloj;
                RND2 = Math.Round(RND2, 4);

                dr["RNDCaja"] = RND2;
                dr["Tiempo AtencionCaja"] = caja.tiempoAtender;
                dr["FinTiempo AtencionCaja"] = Convert.ToString(Math.Round(caja.finAtencion, 2));
                dr["Estadocaja"] = caja.Estado;
                dr["\nColaCaja"] = caja.cola.Count();

                clienteAtencionCaja.horaInicioAtencion = caja.finAtencion - caja.tiempoAtender; /////// RESTO EL TIEMPO QUE LO ATIENDEN PARA QUE ME DE CUANTO ESPERO, SI QUIERO SABER DESDE QUE LLEGA HASTA QUE SE VA SACO LA RESTA
            }
            else
            {
                clienteEsperaCaja.Estado = "EA";
                caja.cola.Add(clienteEsperaCaja);
                clienteEsperaCaja = null;
                dr["FinTiempo AtencionCaja"] = Convert.ToString(Math.Round(caja.finAtencion, 2));
                dr["EstadoCaja"] = caja.Estado;
                dr["\nColaCaja"] = caja.cola.Count();
            }
        }

        public void actualizarColaCaja()
        {

            if (caja.cola.Count() == 0) clienteAtencionCaja = null;
            if (caja.cola.Count() > 0)
            {
                clienteAtencionCaja = (Cliente)caja.cola.First();
                caja.cola.RemoveAt(0);
            }
        }


        public void mostrarClientesCaja2()
        {
            if (caja.cola.Count() == 0)
            {
                if (clienteAtencionCaja.Id > 0)
                {
                    dr["Clientes"] = "Cliente " + clienteAtencionCaja.Id + " " + clienteAtencionCaja.Estado;
                }
            }
            else
            {
                string datos = "";

                // dr["Clientes"] = "CL" + clienteAtencionCaja.Id + " " + clienteAtencionCaja.Estado+", ";
                datos = "Cliente " + clienteAtencionCaja.Id + " " + clienteAtencionCaja.Estado + ", ";

                foreach (Cliente item in caja.cola)
                {

                    if (item.Id > 0)
                    {
                        // dr["Clientes"] = "CL" + item.Id + " " + item.Estado +", ";
                        datos = datos + "Cliente " + item.Id + " " + item.Estado + ", ";
                    }
                }
                dr["Clientes"] = datos;
            }
        }


        public void FinAtencionCaja()
        {
            // queda libre la caja
            caja.Estado = "L";
            caja.finAtencion = 1000000;
            // Se fue el que estaba pagando , llega el proximo
            actualizarColaCaja();
        }

        private void txt_clientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_clientes_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_desde_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            else
            {
                e.Handled = true;
            }
        }

        private void txt_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Lbl_promTele_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
