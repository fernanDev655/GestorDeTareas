using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorTareasWinForm
{
	/// Formulario principal del gestor de tareas.
	public partial class Form1 : Form
	{
		/// Lista donde se guardan las tareas.
		private List<Tarea> tareas = new List<Tarea>();

		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		/// Añade una nueva tarea.
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNombre.Text))
			{
				MessageBox.Show("El nombre de la tarea es obligatorio.");
				return;
			}

			Tarea tarea = new Tarea
			{
				Nombre = txtNombre.Text,
				Descripcion = txtDescripcion.Text,
				FechaVencimiento = dtpFechaVencimiento.Value,
				Completada = false
			};

			tareas.Add(tarea);
			ActualizarLista();
			LimpiarCampos();
		}

		/// Elimina la tarea seleccionada.
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (lstTareas.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione una tarea para eliminar.");
				return;
			}

			tareas.RemoveAt(lstTareas.SelectedIndex);
			ActualizarLista();
		}

		/// Marca como completada la tarea seleccionada.
		private void btnCompletar_Click(object sender, EventArgs e)
		{
			if (lstTareas.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione una tarea para completar.");
				return;
			}

			tareas[lstTareas.SelectedIndex].Completada = true;
			ActualizarLista();
		}

		private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void dtpFechaVencimiento_ValueChanged(object sender, EventArgs e)
		{
		}

		private void txtDescripcion_TextChanged(object sender, EventArgs e)
		{
		}

		private void txtNombre_TextChanged(object sender, EventArgs e)
		{
		}

		/// Actualiza el ListBox con las tareas.
		private void ActualizarLista()
		{
			lstTareas.Items.Clear();

			foreach (Tarea t in tareas)
			{
				lstTareas.Items.Add(t);
			}
		}

       

        /// Limpia los campos del formulario.
        private void LimpiarCampos()
		{
			txtNombre.Clear();
			txtDescripcion.Clear();
			dtpFechaVencimiento.Value = DateTime.Now;
		}
	

	


	}
}
