namespace GestorTareasWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dtpFechaVencimiento = new DateTimePicker();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnCompletar = new Button();
            lstTareas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(222, 174);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(298, 27);
            dtpFechaVencimiento.TabIndex = 0;
            dtpFechaVencimiento.ValueChanged += dtpFechaVencimiento_ValueChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(222, 297);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Añadir Tarea";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(381, 297);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Tarea";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCompletar
            // 
            btnCompletar.Location = new Point(256, 332);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(219, 29);
            btnCompletar.TabIndex = 3;
            btnCompletar.Text = "Marcar como Completada";
            btnCompletar.UseVisualStyleBackColor = true;
            btnCompletar.Click += btnCompletar_Click;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.Location = new Point(222, 207);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(298, 84);
            lstTareas.TabIndex = 4;
            lstTareas.SelectedIndexChanged += lstTareas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 75);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre de la tarea";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 111);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 6;
            label2.Text = "Descripción de la tarea";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(222, 108);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(298, 60);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(222, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 27);
            txtNombre.TabIndex = 8;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstTareas);
            Controls.Add(btnCompletar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaVencimiento);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaVencimiento;
		private Button btnAgregar;
		private Button btnEliminar;
		private Button btnCompletar;
		private ListBox lstTareas;
		private Label label1;
		private Label label2;
		private TextBox txtDescripcion;
		private TextBox txtNombre;
	}
}
