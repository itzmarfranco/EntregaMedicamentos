namespace medicamentos
{
    partial class mainframe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.dgvreports = new System.Windows.Forms.DataGridView();
            this.gbReportes = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.cbreports = new System.Windows.Forms.ComboBox();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtlot = new System.Windows.Forms.TextBox();
            this.lbllot = new System.Windows.Forms.Label();
            this.dpExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tc1 = new System.Windows.Forms.TabControl();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.tabReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreports)).BeginInit();
            this.gbReportes.SuspendLayout();
            this.tabInventario.SuspendLayout();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.tc1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Usuario: ";
            // 
            // menuOpciones
            // 
            this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(69, 20);
            this.menuOpciones.Text = "Opciones";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(981, 24);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(49, 13);
            this.lblCurrentUser.TabIndex = 2;
            this.lblCurrentUser.Text = "Usuario: ";
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.dgvreports);
            this.tabReportes.Controls.Add(this.gbReportes);
            this.tabReportes.Location = new System.Drawing.Point(4, 22);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportes.Size = new System.Drawing.Size(1061, 376);
            this.tabReportes.TabIndex = 2;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // dgvreports
            // 
            this.dgvreports.AllowUserToAddRows = false;
            this.dgvreports.AllowUserToDeleteRows = false;
            this.dgvreports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvreports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvreports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvreports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreports.Location = new System.Drawing.Point(355, 7);
            this.dgvreports.Name = "dgvreports";
            this.dgvreports.Size = new System.Drawing.Size(703, 363);
            this.dgvreports.TabIndex = 2;
            // 
            // gbReportes
            // 
            this.gbReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbReportes.Controls.Add(this.dtp2);
            this.gbReportes.Controls.Add(this.dtp1);
            this.gbReportes.Controls.Add(this.button2);
            this.gbReportes.Controls.Add(this.btnLoadReport);
            this.gbReportes.Controls.Add(this.cbreports);
            this.gbReportes.Location = new System.Drawing.Point(7, 7);
            this.gbReportes.Name = "gbReportes";
            this.gbReportes.Size = new System.Drawing.Size(342, 369);
            this.gbReportes.TabIndex = 1;
            this.gbReportes.TabStop = false;
            this.gbReportes.Text = "Seleccione un reporte";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exportar .csv";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.Location = new System.Drawing.Point(79, 165);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(75, 23);
            this.btnLoadReport.TabIndex = 1;
            this.btnLoadReport.Text = "Ver reporte";
            this.btnLoadReport.UseVisualStyleBackColor = true;
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // cbreports
            // 
            this.cbreports.AutoCompleteCustomSource.AddRange(new string[] {
            "Inventario actual",
            "Demanda de medicamentos sin existencia",
            "Entregas diarias",
            "Entregas quincenales",
            "Entregas mensuales"});
            this.cbreports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbreports.FormattingEnabled = true;
            this.cbreports.Items.AddRange(new object[] {
            "Inventario actual",
            "Demanda de medicamentos sin existencia",
            "Entregas diarias",
            "Entregas en período"});
            this.cbreports.Location = new System.Drawing.Point(6, 19);
            this.cbreports.Name = "cbreports";
            this.cbreports.Size = new System.Drawing.Size(330, 21);
            this.cbreports.TabIndex = 0;
            this.cbreports.SelectedIndexChanged += new System.EventHandler(this.cbreports_SelectedIndexChanged);
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.gb2);
            this.tabInventario.Controls.Add(this.gb1);
            this.tabInventario.Location = new System.Drawing.Point(4, 22);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventario.Size = new System.Drawing.Size(1061, 376);
            this.tabInventario.TabIndex = 0;
            this.tabInventario.Text = "Inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            // 
            // gb2
            // 
            this.gb2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb2.Controls.Add(this.btnDeliver);
            this.gb2.Controls.Add(this.dgvMedicines);
            this.gb2.Controls.Add(this.btnSearch);
            this.gb2.Controls.Add(this.txtSearch);
            this.gb2.Location = new System.Drawing.Point(358, 7);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(697, 363);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = "Medicamentos";
            // 
            // btnDeliver
            // 
            this.btnDeliver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeliver.Location = new System.Drawing.Point(197, 334);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(341, 23);
            this.btnDeliver.TabIndex = 4;
            this.btnDeliver.Text = "Entregar";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.AllowUserToDeleteRows = false;
            this.dgvMedicines.AllowUserToResizeRows = false;
            this.dgvMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(11, 56);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.ReadOnly = true;
            this.dgvMedicines.Size = new System.Drawing.Size(680, 269);
            this.dgvMedicines.TabIndex = 3;
            this.dgvMedicines.DoubleClick += new System.EventHandler(this.dgvMedicines_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(275, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(95, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb1.Controls.Add(this.txtlot);
            this.gb1.Controls.Add(this.lbllot);
            this.gb1.Controls.Add(this.dpExpDate);
            this.gb1.Controls.Add(this.txtQuantity);
            this.gb1.Controls.Add(this.btnDelete);
            this.gb1.Controls.Add(this.btnSave);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.lblFecha);
            this.gb1.Controls.Add(this.lblNombre);
            this.gb1.Controls.Add(this.txtMedName);
            this.gb1.Controls.Add(this.txtID);
            this.gb1.Location = new System.Drawing.Point(7, 7);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(345, 363);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Ingresar lote";
            // 
            // txtlot
            // 
            this.txtlot.Location = new System.Drawing.Point(124, 153);
            this.txtlot.Name = "txtlot";
            this.txtlot.Size = new System.Drawing.Size(120, 20);
            this.txtlot.TabIndex = 14;
            // 
            // lbllot
            // 
            this.lbllot.AutoSize = true;
            this.lbllot.Location = new System.Drawing.Point(85, 156);
            this.lbllot.Name = "lbllot";
            this.lbllot.Size = new System.Drawing.Size(28, 13);
            this.lbllot.TabIndex = 13;
            this.lbllot.Text = "Lote";
            // 
            // dpExpDate
            // 
            this.dpExpDate.Location = new System.Drawing.Point(124, 122);
            this.dpExpDate.Name = "dpExpDate";
            this.dpExpDate.Size = new System.Drawing.Size(210, 20);
            this.dpExpDate.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(124, 183);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtQuantity.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(88, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Existencias";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 122);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(112, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha de vencimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(74, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtMedName
            // 
            this.txtMedName.Location = new System.Drawing.Point(126, 56);
            this.txtMedName.MaxLength = 1000;
            this.txtMedName.Multiline = true;
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(118, 57);
            this.txtMedName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(126, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Visible = false;
            // 
            // tc1
            // 
            this.tc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc1.Controls.Add(this.tabInventario);
            this.tc1.Controls.Add(this.tabReportes);
            this.tc1.Location = new System.Drawing.Point(12, 40);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(1069, 402);
            this.tc1.TabIndex = 0;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(68, 72);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 3;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(68, 111);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 4;
            // 
            // mainframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 454);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.tc1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainframe";
            this.Text = "Inventario de medicamentos";
            this.Load += new System.EventHandler(this.mainframe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreports)).EndInit();
            this.gbReportes.ResumeLayout(false);
            this.tabInventario.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.tc1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.GroupBox gbReportes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoadReport;
        private System.Windows.Forms.ComboBox cbreports;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtlot;
        private System.Windows.Forms.Label lbllot;
        private System.Windows.Forms.DateTimePicker dpExpDate;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.DataGridView dgvreports;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}