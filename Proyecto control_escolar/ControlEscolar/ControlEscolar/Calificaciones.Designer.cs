namespace ControlEscolar
{
    partial class Calificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calificaciones));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.txtNocontrol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgcalificaciones = new System.Windows.Forms.DataGridView();
            this.txtuno = new System.Windows.Forms.TextBox();
            this.txtdos = new System.Windows.Forms.TextBox();
            this.txttres = new System.Windows.Forms.TextBox();
            this.txtcuatro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gpbCalificaciones = new System.Windows.Forms.GroupBox();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumerocontrol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lbIds = new System.Windows.Forms.Label();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.dtgAlumnoss = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcalificaciones)).BeginInit();
            this.gpbCalificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnoss)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(243, 250);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 43);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(603, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 45);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(72, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 45);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(30, 34);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(283, 21);
            this.cmbGrupo.TabIndex = 20;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // txtNocontrol
            // 
            this.txtNocontrol.Location = new System.Drawing.Point(326, 34);
            this.txtNocontrol.Name = "txtNocontrol";
            this.txtNocontrol.Size = new System.Drawing.Size(283, 20);
            this.txtNocontrol.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Grupo";
            // 
            // dtgcalificaciones
            // 
            this.dtgcalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcalificaciones.Location = new System.Drawing.Point(30, 61);
            this.dtgcalificaciones.Name = "dtgcalificaciones";
            this.dtgcalificaciones.Size = new System.Drawing.Size(793, 150);
            this.dtgcalificaciones.TabIndex = 23;
            this.dtgcalificaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgcalificaciones_CellContentClick);
            this.dtgcalificaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgcalificaciones_CellDoubleClick);
            // 
            // txtuno
            // 
            this.txtuno.Location = new System.Drawing.Point(537, 58);
            this.txtuno.Name = "txtuno";
            this.txtuno.Size = new System.Drawing.Size(61, 26);
            this.txtuno.TabIndex = 25;
            // 
            // txtdos
            // 
            this.txtdos.Location = new System.Drawing.Point(704, 58);
            this.txtdos.Name = "txtdos";
            this.txtdos.Size = new System.Drawing.Size(61, 26);
            this.txtdos.TabIndex = 26;
            // 
            // txttres
            // 
            this.txttres.Location = new System.Drawing.Point(537, 85);
            this.txttres.Name = "txttres";
            this.txttres.Size = new System.Drawing.Size(61, 26);
            this.txttres.TabIndex = 27;
            // 
            // txtcuatro
            // 
            this.txtcuatro.Location = new System.Drawing.Point(704, 85);
            this.txtcuatro.Name = "txtcuatro";
            this.txtcuatro.Size = new System.Drawing.Size(61, 26);
            this.txtcuatro.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Parcial 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(620, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Parcial 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Parcial 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(620, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Parcial 4";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(254, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 20);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "0";
            // 
            // gpbCalificaciones
            // 
            this.gpbCalificaciones.Controls.Add(this.lblMaterno);
            this.gpbCalificaciones.Controls.Add(this.lblPaterno);
            this.gpbCalificaciones.Controls.Add(this.lblNombre);
            this.gpbCalificaciones.Controls.Add(this.lblNumerocontrol);
            this.gpbCalificaciones.Controls.Add(this.label2);
            this.gpbCalificaciones.Controls.Add(this.btnExportar);
            this.gpbCalificaciones.Controls.Add(this.lbIds);
            this.gpbCalificaciones.Controls.Add(this.cmbMaterias);
            this.gpbCalificaciones.Controls.Add(this.dtgAlumnoss);
            this.gpbCalificaciones.Controls.Add(this.label6);
            this.gpbCalificaciones.Controls.Add(this.btnCancelar);
            this.gpbCalificaciones.Controls.Add(this.btnEliminar);
            this.gpbCalificaciones.Controls.Add(this.txtuno);
            this.gpbCalificaciones.Controls.Add(this.txtdos);
            this.gpbCalificaciones.Controls.Add(this.btnGuardar);
            this.gpbCalificaciones.Controls.Add(this.label5);
            this.gpbCalificaciones.Controls.Add(this.txttres);
            this.gpbCalificaciones.Controls.Add(this.label4);
            this.gpbCalificaciones.Controls.Add(this.txtcuatro);
            this.gpbCalificaciones.Controls.Add(this.label3);
            this.gpbCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCalificaciones.Location = new System.Drawing.Point(30, 9);
            this.gpbCalificaciones.Name = "gpbCalificaciones";
            this.gpbCalificaciones.Size = new System.Drawing.Size(793, 305);
            this.gpbCalificaciones.TabIndex = 34;
            this.gpbCalificaciones.TabStop = false;
            this.gpbCalificaciones.Text = "Calificaciones";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterno.Location = new System.Drawing.Point(581, 22);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(97, 20);
            this.lblMaterno.TabIndex = 43;
            this.lblMaterno.Text = "ApMaterno";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaterno.Location = new System.Drawing.Point(410, 22);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(94, 20);
            this.lblPaterno.TabIndex = 42;
            this.lblPaterno.Text = "ApPaterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(266, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumerocontrol
            // 
            this.lblNumerocontrol.AutoSize = true;
            this.lblNumerocontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerocontrol.Location = new System.Drawing.Point(148, 22);
            this.lblNumerocontrol.Name = "lblNumerocontrol";
            this.lblNumerocontrol.Size = new System.Drawing.Size(71, 20);
            this.lblNumerocontrol.TabIndex = 40;
            this.lblNumerocontrol.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Materia";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(427, 250);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(135, 44);
            this.btnExportar.TabIndex = 38;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lbIds
            // 
            this.lbIds.AutoSize = true;
            this.lbIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIds.Location = new System.Drawing.Point(366, 56);
            this.lbIds.Name = "lbIds";
            this.lbIds.Size = new System.Drawing.Size(19, 20);
            this.lbIds.TabIndex = 35;
            this.lbIds.Text = "0";
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(41, 78);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(344, 28);
            this.cmbMaterias.TabIndex = 36;
            // 
            // dtgAlumnoss
            // 
            this.dtgAlumnoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnoss.Location = new System.Drawing.Point(41, 130);
            this.dtgAlumnoss.Name = "dtgAlumnoss";
            this.dtgAlumnoss.Size = new System.Drawing.Size(724, 114);
            this.dtgAlumnoss.TabIndex = 35;
            this.dtgAlumnoss.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlumnoss_CellDoubleClick);
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 332);
            this.Controls.Add(this.gpbCalificaciones);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dtgcalificaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNocontrol);
            this.Controls.Add(this.cmbGrupo);
            this.Name = "Calificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Calificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgcalificaciones)).EndInit();
            this.gpbCalificaciones.ResumeLayout(false);
            this.gpbCalificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.TextBox txtNocontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgcalificaciones;
        private System.Windows.Forms.TextBox txtuno;
        private System.Windows.Forms.TextBox txtdos;
        private System.Windows.Forms.TextBox txttres;
        private System.Windows.Forms.TextBox txtcuatro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gpbCalificaciones;
        private System.Windows.Forms.DataGridView dtgAlumnoss;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Label lbIds;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblNumerocontrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblNombre;
    }
}