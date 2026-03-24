using System;
using System.Collections.Generic;
using System.Text;

/// Representa una tarea con nombre, descripción, fecha de vencimiento y estado.
public class Tarea
{
	/// Nombre de la tarea.
	public string Nombre { get; set; }

	/// Descripción de la tarea.
	public string Descripcion { get; set; }

	/// Fecha límite de la tarea.
	public DateTime FechaVencimiento { get; set; }

	/// Indica si la tarea está completada.
	public bool Completada { get; set; }

	/// Devuelve el texto que se mostrará en el ListBox.
	public override string ToString()
	{
		return $"{Nombre} - {(Completada ? "Completada" : "Pendiente")} - Vence: {FechaVencimiento:d}";
	}



}



