using FontAwesome.Sharp;
using Polleria.presentacion.clientesReservas.clientesFrecuentes;
using Polleria.presentacion.clientesReservas.estadoReservas;
using Polleria.presentacion.clientesReservas.reservasHoy;
using Polleria.presentacion.finanzas.estadoCaja;
using Polleria.presentacion.finanzas.ingresosRecientes;
using Polleria.presentacion.finanzas.pagosProveedores;
using Polleria.presentacion.gestionEmpleados.asistenciasDia;
using Polleria.presentacion.gestionEmpleados.empleadosActivos;
using Polleria.presentacion.gestionEmpleados.evalucionesRecientes;
using Polleria.presentacion.inventarios.ingredientesCriticos;
using Polleria.presentacion.inventarios.inventarioGeneral;
using Polleria.presentacion.inventarios.ultimasCompras;
using Polleria.presentacion.promocionesPlatos.platosMasVendidos;
using Polleria.presentacion.promocionesPlatos.promocionesActivas;
using Polleria.presentacion.resumenGeneral.mesasOcuDis;
using Polleria.presentacion.resumenGeneral.pedidosActivos;
using Polleria.presentacion.resumenGeneral.ventasDia;
using Polleria.presentacion.seguridadAuditoria.inicioSesionReciente;
using Polleria.presentacion.seguridadAuditoria.ultimasActividades;
using Polleria.presentacion.seguridadAuditoria.usuariosActivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polleria.presentacion
{
    public partial class Inicio : Form
    {
        private static IconButton MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio()
        {
            InitializeComponent();
            OcultarSubMenus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ContraerMenu();
        }

        private void ContraerMenu()
        {
            if (this.pnlMenu.Width > 200) //Collapse menu
            {
                pnlMenu.Width = 100;
                imgLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                OcultarSubMenus();
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expande el menu
                pnlMenu.Width = 230;
                imgLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void OcultarSubMenus()
        {
            subMenuResumenGeneral.Visible = false;
            subMenuInventarios.Visible = false;
            subMenuGestionEmpleados.Visible = false ;
            subMenuClientesReservas.Visible = false;
            subMenuPromocionesPlatos.Visible = false;
            subMenuFinanzas.Visible = false;
            subMenuSeguridad.Visible = false;
        }

        private void AlternarSubMenu(Panel subMenu)
        {
            if (pnlMenu.Width <= 100)
            {
                subMenu.Visible = false;
                MessageBox.Show("Expande el menú principal para acceder al submenú.");
            }
            else
            {
                OcultarSubMenus();
                subMenu.Visible = !subMenu.Visible;
            }
        }

        private void btnResumenGeneral_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuResumenGeneral);
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuInventarios);
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuGestionEmpleados);
        }

        private void btnClientesReservas_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuClientesReservas);
        }

        private void btnPromocionesPlatos_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuPromocionesPlatos);
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuFinanzas);
        }

        private void btnSeguridadAutoridad_Click(object sender, EventArgs e)
        {
            AlternarSubMenu(subMenuSeguridad);
        }

        private void AbrirFormulario(IconButton menu, Form formulario)
        {
            lblhora.Visible = false;
            lblFecha.Visible = false;
            pcbLogoImagen.Visible = false;

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.FromArgb(255, 217, 102); // Restaurar el color del botón anterior
                MenuActivo.ForeColor = Color.FromArgb(51, 51, 51); // Restaurar el color de texto del botón anterior
            }
            menu.BackColor = Color.FromArgb(250, 243, 224);
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnVentaDia_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmVentasDia());
        }

        private void btnPedidosActivos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmPedidosActivos());
        }

        private void btnMesasOcuDisp_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmMesasOcuDis());
        }

        private void btnIngredientesCriticos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmIngredientesCriticos());
        }

        private void btnUltimasCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmUltimasCompras());
        }

        private void btnInventarioGeneral_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmInventarioGeneral());
        }

        private void btnEmpleadosActivos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmEmpleadosActivos());
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmAsistenciasDia());
        }

        private void btnEvaluciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmEvalucionesRecientes());
        }

        private void btnClientesFrecuentes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmClientesFrecuentes());
        }

        private void btnReservasHoy_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmReservasHoy());
        }

        private void btnEstadoReserva_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmEstadoReservas());
        }

        private void btnPromocionesActivas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmPromocionesActivas());
        }

        private void btnPlatosMasVendidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmpPlatosMasVendidos());
        }

        private void btnEstadoCaja_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmEstadoCaja());
        }

        private void btnPagosProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmPagosProveedores());
        }

        private void btnIngresosRecientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmIngresosRecientes());
        }

        private void btnActividadesSistema_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmUltimasActividades());
        }

        private void btnSesionReciente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmInicioSesionReciente());
        }

        private void btnUsuarioActivo_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new FrmUsuarioActivos());
        }
    }
}
