
namespace Presentacion
{
    partial class FormListaDeEspera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaDeEspera));
            this.label5 = new System.Windows.Forms.Label();
            this.dgvListaConsultaSinAtender = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBtnIniciarConsulta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvListaConsultaAtendidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConsultaSinAtender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConsultaAtendidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "Lista de Espera";
            // 
            // dgvListaConsultaSinAtender
            // 
            this.dgvListaConsultaSinAtender.AllowUserToAddRows = false;
            this.dgvListaConsultaSinAtender.AllowUserToDeleteRows = false;
            this.dgvListaConsultaSinAtender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaConsultaSinAtender.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaConsultaSinAtender.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaConsultaSinAtender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaConsultaSinAtender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnDni,
            this.ColumnObraSocial,
            this.ColumnEdad,
            this.ColumnEspecialidad,
            this.ColumnBtnIniciarConsulta});
            this.dgvListaConsultaSinAtender.EnableHeadersVisualStyles = false;
            this.dgvListaConsultaSinAtender.Location = new System.Drawing.Point(86, 82);
            this.dgvListaConsultaSinAtender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaConsultaSinAtender.Name = "dgvListaConsultaSinAtender";
            this.dgvListaConsultaSinAtender.ReadOnly = true;
            this.dgvListaConsultaSinAtender.RowHeadersVisible = false;
            this.dgvListaConsultaSinAtender.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvListaConsultaSinAtender.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaConsultaSinAtender.RowTemplate.Height = 24;
            this.dgvListaConsultaSinAtender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaConsultaSinAtender.Size = new System.Drawing.Size(738, 232);
            this.dgvListaConsultaSinAtender.TabIndex = 34;
            this.dgvListaConsultaSinAtender.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEspera_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 29;
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
            // ColumnDni
            // 
            this.ColumnDni.HeaderText = "Dni";
            this.ColumnDni.MinimumWidth = 6;
            this.ColumnDni.Name = "ColumnDni";
            this.ColumnDni.ReadOnly = true;
            this.ColumnDni.Width = 62;
            // 
            // ColumnObraSocial
            // 
            this.ColumnObraSocial.HeaderText = "Obra Social";
            this.ColumnObraSocial.MinimumWidth = 6;
            this.ColumnObraSocial.Name = "ColumnObraSocial";
            this.ColumnObraSocial.ReadOnly = true;
            this.ColumnObraSocial.Width = 127;
            // 
            // ColumnEdad
            // 
            this.ColumnEdad.HeaderText = "Edad";
            this.ColumnEdad.MinimumWidth = 6;
            this.ColumnEdad.Name = "ColumnEdad";
            this.ColumnEdad.ReadOnly = true;
            this.ColumnEdad.Width = 76;
            // 
            // ColumnEspecialidad
            // 
            this.ColumnEspecialidad.HeaderText = "Especialidad";
            this.ColumnEspecialidad.MinimumWidth = 6;
            this.ColumnEspecialidad.Name = "ColumnEspecialidad";
            this.ColumnEspecialidad.ReadOnly = true;
            this.ColumnEspecialidad.Width = 134;
            // 
            // ColumnBtnIniciarConsulta
            // 
            this.ColumnBtnIniciarConsulta.HeaderText = "Consulta";
            this.ColumnBtnIniciarConsulta.MinimumWidth = 6;
            this.ColumnBtnIniciarConsulta.Name = "ColumnBtnIniciarConsulta";
            this.ColumnBtnIniciarConsulta.ReadOnly = true;
            this.ColumnBtnIniciarConsulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnBtnIniciarConsulta.Text = "Iniciar Consulta";
            this.ColumnBtnIniciarConsulta.UseColumnTextForButtonValue = true;
            this.ColumnBtnIniciarConsulta.Width = 83;
            // 
            // dgvListaConsultaAtendidas
            // 
            this.dgvListaConsultaAtendidas.AllowUserToAddRows = false;
            this.dgvListaConsultaAtendidas.AllowUserToDeleteRows = false;
            this.dgvListaConsultaAtendidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaConsultaAtendidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaConsultaAtendidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaConsultaAtendidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaConsultaAtendidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewButtonColumn1});
            this.dgvListaConsultaAtendidas.EnableHeadersVisualStyles = false;
            this.dgvListaConsultaAtendidas.Location = new System.Drawing.Point(86, 408);
            this.dgvListaConsultaAtendidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaConsultaAtendidas.Name = "dgvListaConsultaAtendidas";
            this.dgvListaConsultaAtendidas.ReadOnly = true;
            this.dgvListaConsultaAtendidas.RowHeadersVisible = false;
            this.dgvListaConsultaAtendidas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvListaConsultaAtendidas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaConsultaAtendidas.RowTemplate.Height = 24;
            this.dgvListaConsultaAtendidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaConsultaAtendidas.Size = new System.Drawing.Size(738, 234);
            this.dgvListaConsultaAtendidas.TabIndex = 35;
            this.dgvListaConsultaAtendidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaConsultaAtendidas_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 29;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 98;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 98;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Dni";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Obra Social";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 127;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 76;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Especialidad";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 134;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Consulta";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Finalizar Consulta";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Atendidos";
            // 
            // FormListaDeEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(924, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaConsultaAtendidas);
            this.Controls.Add(this.dgvListaConsultaSinAtender);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaDeEspera";
            this.Text = "FormListaDeEspera";
            this.Load += new System.EventHandler(this.FormListaDeEspera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConsultaSinAtender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConsultaAtendidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvListaConsultaSinAtender;
        private System.Windows.Forms.DataGridView dgvListaConsultaAtendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEspecialidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBtnIniciarConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Label label1;
    }
}