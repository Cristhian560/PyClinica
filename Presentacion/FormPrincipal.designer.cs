
namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnSalirCerrarSecion = new System.Windows.Forms.Button();
            this.panelMedicos = new System.Windows.Forms.Panel();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.panelListaPacientes = new System.Windows.Forms.Panel();
            this.btnListaEspera = new System.Windows.Forms.Button();
            this.btnListaDePacientes = new System.Windows.Forms.Button();
            this.panelTurnos = new System.Windows.Forms.Panel();
            this.btnRecepcion = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelBotones.SuspendLayout();
            this.panelMedicos.SuspendLayout();
            this.panelListaPacientes.SuspendLayout();
            this.panelTurnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.AllowDrop = true;
            this.panelBotones.AutoScroll = true;
            this.panelBotones.BackColor = System.Drawing.Color.Black;
            this.panelBotones.Controls.Add(this.btnEstadisticas);
            this.panelBotones.Controls.Add(this.btnSalirCerrarSecion);
            this.panelBotones.Controls.Add(this.panelMedicos);
            this.panelBotones.Controls.Add(this.btnMedicos);
            this.panelBotones.Controls.Add(this.panelListaPacientes);
            this.panelBotones.Controls.Add(this.btnListaDePacientes);
            this.panelBotones.Controls.Add(this.panelTurnos);
            this.panelBotones.Controls.Add(this.btnTurnos);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(208, 704);
            this.panelBotones.TabIndex = 0;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 360);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(208, 70);
            this.btnEstadisticas.TabIndex = 11;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnSalirCerrarSecion
            // 
            this.btnSalirCerrarSecion.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalirCerrarSecion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalirCerrarSecion.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSalirCerrarSecion.FlatAppearance.BorderSize = 0;
            this.btnSalirCerrarSecion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalirCerrarSecion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalirCerrarSecion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirCerrarSecion.ForeColor = System.Drawing.Color.White;
            this.btnSalirCerrarSecion.Location = new System.Drawing.Point(0, 634);
            this.btnSalirCerrarSecion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalirCerrarSecion.Name = "btnSalirCerrarSecion";
            this.btnSalirCerrarSecion.Size = new System.Drawing.Size(208, 70);
            this.btnSalirCerrarSecion.TabIndex = 4;
            this.btnSalirCerrarSecion.Text = "SALIR";
            this.btnSalirCerrarSecion.UseVisualStyleBackColor = false;
            this.btnSalirCerrarSecion.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelMedicos
            // 
            this.panelMedicos.Controls.Add(this.btnLista);
            this.panelMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedicos.Location = new System.Drawing.Point(0, 310);
            this.panelMedicos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMedicos.Name = "panelMedicos";
            this.panelMedicos.Size = new System.Drawing.Size(208, 50);
            this.panelMedicos.TabIndex = 9;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.ForeColor = System.Drawing.Color.White;
            this.btnLista.Location = new System.Drawing.Point(0, 0);
            this.btnLista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(208, 50);
            this.btnLista.TabIndex = 12;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedicos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMedicos.Location = new System.Drawing.Point(0, 240);
            this.btnMedicos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(208, 70);
            this.btnMedicos.TabIndex = 8;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // panelListaPacientes
            // 
            this.panelListaPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelListaPacientes.Controls.Add(this.btnListaEspera);
            this.panelListaPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListaPacientes.Location = new System.Drawing.Point(0, 190);
            this.panelListaPacientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelListaPacientes.Name = "panelListaPacientes";
            this.panelListaPacientes.Size = new System.Drawing.Size(208, 50);
            this.panelListaPacientes.TabIndex = 3;
            // 
            // btnListaEspera
            // 
            this.btnListaEspera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaEspera.FlatAppearance.BorderSize = 0;
            this.btnListaEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaEspera.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListaEspera.Location = new System.Drawing.Point(0, 0);
            this.btnListaEspera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaEspera.Name = "btnListaEspera";
            this.btnListaEspera.Size = new System.Drawing.Size(208, 50);
            this.btnListaEspera.TabIndex = 1;
            this.btnListaEspera.Text = "Lista de Espera";
            this.btnListaEspera.UseVisualStyleBackColor = true;
            this.btnListaEspera.Click += new System.EventHandler(this.btnListaEspera_Click);
            // 
            // btnListaDePacientes
            // 
            this.btnListaDePacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaDePacientes.FlatAppearance.BorderSize = 0;
            this.btnListaDePacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnListaDePacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnListaDePacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDePacientes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListaDePacientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListaDePacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaDePacientes.Location = new System.Drawing.Point(0, 120);
            this.btnListaDePacientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaDePacientes.Name = "btnListaDePacientes";
            this.btnListaDePacientes.Size = new System.Drawing.Size(208, 70);
            this.btnListaDePacientes.TabIndex = 2;
            this.btnListaDePacientes.Text = "Lista de Pacientes";
            this.btnListaDePacientes.UseVisualStyleBackColor = true;
            this.btnListaDePacientes.Click += new System.EventHandler(this.btnListaDePacientes_Click);
            // 
            // panelTurnos
            // 
            this.panelTurnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTurnos.Controls.Add(this.btnRecepcion);
            this.panelTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTurnos.Location = new System.Drawing.Point(0, 70);
            this.panelTurnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTurnos.Name = "panelTurnos";
            this.panelTurnos.Size = new System.Drawing.Size(208, 50);
            this.panelTurnos.TabIndex = 1;
            // 
            // btnRecepcion
            // 
            this.btnRecepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecepcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecepcion.FlatAppearance.BorderSize = 0;
            this.btnRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepcion.ForeColor = System.Drawing.Color.White;
            this.btnRecepcion.Location = new System.Drawing.Point(0, 0);
            this.btnRecepcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecepcion.Name = "btnRecepcion";
            this.btnRecepcion.Size = new System.Drawing.Size(208, 50);
            this.btnRecepcion.TabIndex = 13;
            this.btnRecepcion.Text = "Recepcion";
            this.btnRecepcion.UseVisualStyleBackColor = false;
            this.btnRecepcion.Click += new System.EventHandler(this.btnRecepcion_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurnos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTurnos.FlatAppearance.BorderSize = 0;
            this.btnTurnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnTurnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTurnos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTurnos.Location = new System.Drawing.Point(0, 0);
            this.btnTurnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(208, 70);
            this.btnTurnos.TabIndex = 0;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.UseVisualStyleBackColor = true;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.BackColor = System.Drawing.Color.Black;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(208, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(924, 704);
            this.panelPrincipal.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1132, 674);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panelBotones.ResumeLayout(false);
            this.panelMedicos.ResumeLayout(false);
            this.panelListaPacientes.ResumeLayout(false);
            this.panelTurnos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelListaPacientes;
        private System.Windows.Forms.Button btnListaEspera;
        private System.Windows.Forms.Button btnListaDePacientes;
        private System.Windows.Forms.Panel panelTurnos;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnSalirCerrarSecion;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Panel panelMedicos;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnRecepcion;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnMedicos;
    }
}