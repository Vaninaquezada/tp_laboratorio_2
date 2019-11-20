namespace MainCorreo
{
    partial class FrmPpal
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
            this.components = new System.ComponentModel.Container();
            this.grpBxEstadoPaquetes = new System.Windows.Forms.GroupBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.grpBxPaquete = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.grpBxEstadoPaquetes.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.grpBxPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxEstadoPaquetes
            // 
            this.grpBxEstadoPaquetes.ContextMenuStrip = this.cmsListas;
            this.grpBxEstadoPaquetes.Controls.Add(this.lblEstadoEntregado);
            this.grpBxEstadoPaquetes.Controls.Add(this.lblEstadoEnViaje);
            this.grpBxEstadoPaquetes.Controls.Add(this.lblEstadoIngresado);
            this.grpBxEstadoPaquetes.Controls.Add(this.lstEstadoEntregado);
            this.grpBxEstadoPaquetes.Controls.Add(this.lstEstadoEnViaje);
            this.grpBxEstadoPaquetes.Controls.Add(this.lstEstadoIngresado);
            this.grpBxEstadoPaquetes.Location = new System.Drawing.Point(10, 11);
            this.grpBxEstadoPaquetes.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxEstadoPaquetes.Name = "grpBxEstadoPaquetes";
            this.grpBxEstadoPaquetes.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxEstadoPaquetes.Size = new System.Drawing.Size(686, 305);
            this.grpBxEstadoPaquetes.TabIndex = 0;
            this.grpBxEstadoPaquetes.TabStop = false;
            this.grpBxEstadoPaquetes.Text = "Estados Paquetes";
            // 
            // cmsListas
            // 
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(116, 26);
            this.cmsListas.Text = "Mostrar";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.ToolStripMenuItem.Text = "Mostrar";
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(472, 34);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEstadoEntregado.TabIndex = 5;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(243, 35);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoEnViaje.TabIndex = 4;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(18, 34);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblEstadoIngresado.TabIndex = 3;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(466, 52);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(210, 238);
            this.lstEstadoEntregado.TabIndex = 2;
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(239, 52);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(210, 238);
            this.lstEstadoEnViaje.TabIndex = 1;
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(12, 52);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(210, 238);
            this.lstEstadoIngresado.TabIndex = 0;
            // 
            // grpBxPaquete
            // 
            this.grpBxPaquete.Controls.Add(this.lblDireccion);
            this.grpBxPaquete.Controls.Add(this.lblTrackingID);
            this.grpBxPaquete.Controls.Add(this.txtDireccion);
            this.grpBxPaquete.Controls.Add(this.mtxtTrackingID);
            this.grpBxPaquete.Controls.Add(this.btnMostrarTodos);
            this.grpBxPaquete.Controls.Add(this.btnAgregar);
            this.grpBxPaquete.Location = new System.Drawing.Point(406, 319);
            this.grpBxPaquete.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxPaquete.Name = "grpBxPaquete";
            this.grpBxPaquete.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxPaquete.Size = new System.Drawing.Size(290, 145);
            this.grpBxPaquete.TabIndex = 1;
            this.grpBxPaquete.TabStop = false;
            this.grpBxPaquete.Text = "Paquete";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 77);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(9, 22);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(63, 13);
            this.lblTrackingID.TabIndex = 4;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(12, 94);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(149, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(12, 38);
            this.mtxtTrackingID.Mask = "000-000-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(153, 20);
            this.mtxtTrackingID.TabIndex = 2;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMostrarTodos.Location = new System.Drawing.Point(177, 74);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(108, 40);
            this.btnMostrarTodos.TabIndex = 1;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.Location = new System.Drawing.Point(177, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Enabled = false;
            this.rtbMostrar.Location = new System.Drawing.Point(12, 320);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(389, 143);
            this.rtbMostrar.TabIndex = 2;
            this.rtbMostrar.Text = "";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 475);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.grpBxPaquete);
            this.Controls.Add(this.grpBxEstadoPaquetes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Vanina.Quezada.2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.grpBxEstadoPaquetes.ResumeLayout(false);
            this.grpBxEstadoPaquetes.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.grpBxPaquete.ResumeLayout(false);
            this.grpBxPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxEstadoPaquetes;
        private System.Windows.Forms.GroupBox grpBxPaquete;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
    }
}

