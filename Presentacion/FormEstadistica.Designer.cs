
namespace Presentacion
{
    partial class FormEstadistica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadistica));
            this.dgvCantidadPacientesAtendidos = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidadPacientesAtendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMedicoMayorCantidadPacientes = new System.Windows.Forms.Label();
            this.lblMenorCantidadPacientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadPacientesAtendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCantidadPacientesAtendidos
            // 
            this.dgvCantidadPacientesAtendidos.AllowUserToAddRows = false;
            this.dgvCantidadPacientesAtendidos.AllowUserToDeleteRows = false;
            this.dgvCantidadPacientesAtendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCantidadPacientesAtendidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCantidadPacientesAtendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCantidadPacientesAtendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantidadPacientesAtendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnEspecialidad,
            this.ColumnCantidadPacientesAtendidos});
            this.dgvCantidadPacientesAtendidos.EnableHeadersVisualStyles = false;
            this.dgvCantidadPacientesAtendidos.Location = new System.Drawing.Point(180, 105);
            this.dgvCantidadPacientesAtendidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCantidadPacientesAtendidos.Name = "dgvCantidadPacientesAtendidos";
            this.dgvCantidadPacientesAtendidos.ReadOnly = true;
            this.dgvCantidadPacientesAtendidos.RowHeadersVisible = false;
            this.dgvCantidadPacientesAtendidos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvCantidadPacientesAtendidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCantidadPacientesAtendidos.RowTemplate.Height = 24;
            this.dgvCantidadPacientesAtendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCantidadPacientesAtendidos.Size = new System.Drawing.Size(520, 232);
            this.dgvCantidadPacientesAtendidos.TabIndex = 35;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 98;
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.HeaderText = "Apellido";
            this.ColumnApellido.MinimumWidth = 6;
            this.ColumnApellido.Name = "ColumnApellido";
            this.ColumnApellido.ReadOnly = true;
            this.ColumnApellido.Width = 98;
            // 
            // ColumnEspecialidad
            // 
            this.ColumnEspecialidad.HeaderText = "Especialidad";
            this.ColumnEspecialidad.MinimumWidth = 6;
            this.ColumnEspecialidad.Name = "ColumnEspecialidad";
            this.ColumnEspecialidad.ReadOnly = true;
            this.ColumnEspecialidad.Width = 134;
            // 
            // ColumnCantidadPacientesAtendidos
            // 
            this.ColumnCantidadPacientesAtendidos.HeaderText = "Pacientes Atendidos";
            this.ColumnCantidadPacientesAtendidos.MinimumWidth = 6;
            this.ColumnCantidadPacientesAtendidos.Name = "ColumnCantidadPacientesAtendidos";
            this.ColumnCantidadPacientesAtendidos.ReadOnly = true;
            this.ColumnCantidadPacientesAtendidos.Width = 178;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 37);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estadisticas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Medico que mas pacientes atendio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Medico que menos pacientes atendio";
            // 
            // lblMedicoMayorCantidadPacientes
            // 
            this.lblMedicoMayorCantidadPacientes.AutoSize = true;
            this.lblMedicoMayorCantidadPacientes.BackColor = System.Drawing.Color.White;
            this.lblMedicoMayorCantidadPacientes.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMedicoMayorCantidadPacientes.Location = new System.Drawing.Point(45, 429);
            this.lblMedicoMayorCantidadPacientes.Name = "lblMedicoMayorCantidadPacientes";
            this.lblMedicoMayorCantidadPacientes.Size = new System.Drawing.Size(0, 23);
            this.lblMedicoMayorCantidadPacientes.TabIndex = 39;
            // 
            // lblMenorCantidadPacientes
            // 
            this.lblMenorCantidadPacientes.AutoSize = true;
            this.lblMenorCantidadPacientes.BackColor = System.Drawing.Color.White;
            this.lblMenorCantidadPacientes.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenorCantidadPacientes.Location = new System.Drawing.Point(45, 544);
            this.lblMenorCantidadPacientes.Name = "lblMenorCantidadPacientes";
            this.lblMenorCantidadPacientes.Size = new System.Drawing.Size(0, 23);
            this.lblMenorCantidadPacientes.TabIndex = 40;
            // 
            // FormEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(924, 674);
            this.Controls.Add(this.lblMenorCantidadPacientes);
            this.Controls.Add(this.lblMedicoMayorCantidadPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCantidadPacientesAtendidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstadistica";
            this.Text = "FormEstadistica";
            this.Load += new System.EventHandler(this.FormEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadPacientesAtendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCantidadPacientesAtendidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidadPacientesAtendidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMedicoMayorCantidadPacientes;
        private System.Windows.Forms.Label lblMenorCantidadPacientes;
    }
}