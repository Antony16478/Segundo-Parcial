using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageJugadores;
        private System.Windows.Forms.TabPage tabPageInventario;
        private System.Windows.Forms.TabPage tabPageBloques;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridView dgvBloques;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label lblNombreJugador;
        private System.Windows.Forms.NumericUpDown nudNivelJugador;
        private System.Windows.Forms.Label lblNivelJugador;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Button btnBuscarJugador;
        private System.Windows.Forms.Button btnActualizarJugador;
        private System.Windows.Forms.Button btnEliminarJugador;
        private System.Windows.Forms.TextBox txtNombreItem;
        private System.Windows.Forms.Label lblNombreItem;
        private System.Windows.Forms.ComboBox cmbTipoItem;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.ComboBox cmbRarezaItem;
        private System.Windows.Forms.Label lblRarezaItem;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.TextBox txtNombreBloque;
        private System.Windows.Forms.Label lblNombreBloque;
        private System.Windows.Forms.ComboBox cmbTipoBloque;
        private System.Windows.Forms.Label lblTipoBloque;
        private System.Windows.Forms.ComboBox cmbRarezaBloque;
        private System.Windows.Forms.Label lblRarezaBloque;
        private System.Windows.Forms.NumericUpDown nudCantidadBloque;
        private System.Windows.Forms.Label lblCantidadBloque;
        private System.Windows.Forms.Button btnAgregarBloque;
        private System.Windows.Forms.Button btnBuscarBloque;
        private System.Windows.Forms.Button btnActualizarBloque;
        private System.Windows.Forms.Button btnEliminarBloque;
        private System.Windows.Forms.Button btnBuscarPorIdBloque;
        private System.Windows.Forms.Button btnBuscarPorRarezaBloque;

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
            tabControl1 = new TabControl();
            tabPageJugadores = new TabPage();
            dgvJugadores = new DataGridView();
            txtNombreJugador = new TextBox();
            lblNombreJugador = new Label();
            nudNivelJugador = new NumericUpDown();
            lblNivelJugador = new Label();
            btnAgregarJugador = new Button();
            btnBuscarJugador = new Button();
            btnActualizarJugador = new Button();
            btnEliminarJugador = new Button();
            tabPageInventario = new TabPage();
            dgvInventario = new DataGridView();
            txtNombreItem = new TextBox();
            lblNombreItem = new Label();
            cmbTipoItem = new ComboBox();
            lblTipoItem = new Label();
            cmbRarezaItem = new ComboBox();
            lblRarezaItem = new Label();
            btnAgregarItem = new Button();
            btnBuscarItem = new Button();
            btnEliminarItem = new Button();
            tabPageBloques = new TabPage();
            dgvBloques = new DataGridView();
            txtNombreBloque = new TextBox();
            lblNombreBloque = new Label();
            cmbTipoBloque = new ComboBox();
            lblTipoBloque = new Label();
            cmbRarezaBloque = new ComboBox();
            lblRarezaBloque = new Label();
            nudCantidadBloque = new NumericUpDown();
            lblCantidadBloque = new Label();
            btnAgregarBloque = new Button();
            btnBuscarBloque = new Button();
            btnActualizarBloque = new Button();
            btnEliminarBloque = new Button();
            btnBuscarPorIdBloque = new Button();
            btnBuscarPorRarezaBloque = new Button();
            tabControl1.SuspendLayout();
            tabPageJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNivelJugador).BeginInit();
            tabPageInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            tabPageBloques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBloques).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadBloque).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageJugadores);
            tabControl1.Controls.Add(tabPageInventario);
            tabControl1.Controls.Add(tabPageBloques);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPageJugadores
            // 
            tabPageJugadores.Controls.Add(dgvJugadores);
            tabPageJugadores.Controls.Add(txtNombreJugador);
            tabPageJugadores.Controls.Add(lblNombreJugador);
            tabPageJugadores.Controls.Add(nudNivelJugador);
            tabPageJugadores.Controls.Add(lblNivelJugador);
            tabPageJugadores.Controls.Add(btnAgregarJugador);
            tabPageJugadores.Controls.Add(btnBuscarJugador);
            tabPageJugadores.Controls.Add(btnActualizarJugador);
            tabPageJugadores.Controls.Add(btnEliminarJugador);
            tabPageJugadores.Location = new Point(4, 29);
            tabPageJugadores.Name = "tabPageJugadores";
            tabPageJugadores.Padding = new Padding(3);
            tabPageJugadores.Size = new Size(792, 417);
            tabPageJugadores.TabIndex = 0;
            tabPageJugadores.Text = "Jugadores";
            tabPageJugadores.UseVisualStyleBackColor = true;
            // 
            // dgvJugadores
            // 
            dgvJugadores.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(8, 111);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 51;
            dgvJugadores.Size = new Size(614, 188);
            dgvJugadores.TabIndex = 6;
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(8, 51);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(300, 27);
            txtNombreJugador.TabIndex = 5;
            txtNombreJugador.TextChanged += txtNombreJugador_TextChanged;
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Location = new Point(8, 18);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(124, 20);
            lblNombreJugador.TabIndex = 4;
            lblNombreJugador.Text = "Nombre Jugador:";
            // 
            // nudNivelJugador
            // 
            nudNivelJugador.Location = new Point(350, 51);
            nudNivelJugador.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNivelJugador.Name = "nudNivelJugador";
            nudNivelJugador.Size = new Size(150, 27);
            nudNivelJugador.TabIndex = 7;
            nudNivelJugador.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudNivelJugador.ValueChanged += nudNivelJugador_ValueChanged;
            // 
            // lblNivelJugador
            // 
            lblNivelJugador.AutoSize = true;
            lblNivelJugador.Location = new Point(350, 18);
            lblNivelJugador.Name = "lblNivelJugador";
            lblNivelJugador.Size = new Size(103, 20);
            lblNivelJugador.TabIndex = 8;
            lblNivelJugador.Text = "Nivel Jugador:";
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.Location = new Point(634, 315);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(150, 29);
            btnAgregarJugador.TabIndex = 3;
            btnAgregarJugador.Text = "Agregar Jugador";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // btnBuscarJugador
            // 
            btnBuscarJugador.Location = new Point(458, 315);
            btnBuscarJugador.Name = "btnBuscarJugador";
            btnBuscarJugador.Size = new Size(150, 29);
            btnBuscarJugador.TabIndex = 2;
            btnBuscarJugador.Text = "Buscar Jugador";
            btnBuscarJugador.UseVisualStyleBackColor = true;
            btnBuscarJugador.Click += btnBuscarJugador_Click;
            // 
            // btnActualizarJugador
            // 
            btnActualizarJugador.Location = new Point(634, 360);
            btnActualizarJugador.Name = "btnActualizarJugador";
            btnActualizarJugador.Size = new Size(150, 29);
            btnActualizarJugador.TabIndex = 1;
            btnActualizarJugador.Text = "Actualizar Jugador";
            btnActualizarJugador.UseVisualStyleBackColor = true;
            btnActualizarJugador.Click += btnActualizarJugador_Click;
            // 
            // btnEliminarJugador
            // 
            btnEliminarJugador.Location = new Point(458, 360);
            btnEliminarJugador.Name = "btnEliminarJugador";
            btnEliminarJugador.Size = new Size(150, 29);
            btnEliminarJugador.TabIndex = 0;
            btnEliminarJugador.Text = "Eliminar Jugador";
            btnEliminarJugador.UseVisualStyleBackColor = true;
            btnEliminarJugador.Click += btnEliminarJugador_Click;
            // 
            // tabPageInventario
            // 
            tabPageInventario.Controls.Add(dgvInventario);
            tabPageInventario.Controls.Add(txtNombreItem);
            tabPageInventario.Controls.Add(lblNombreItem);
            tabPageInventario.Controls.Add(cmbTipoItem);
            tabPageInventario.Controls.Add(lblTipoItem);
            tabPageInventario.Controls.Add(cmbRarezaItem);
            tabPageInventario.Controls.Add(lblRarezaItem);
            tabPageInventario.Controls.Add(btnAgregarItem);
            tabPageInventario.Controls.Add(btnBuscarItem);
            tabPageInventario.Controls.Add(btnEliminarItem);
            tabPageInventario.Location = new Point(4, 29);
            tabPageInventario.Name = "tabPageInventario";
            tabPageInventario.Padding = new Padding(3);
            tabPageInventario.Size = new Size(792, 417);
            tabPageInventario.TabIndex = 1;
            tabPageInventario.Text = "Inventario";
            tabPageInventario.UseVisualStyleBackColor = true;
            // 
            // dgvInventario
            // 
            dgvInventario.BackgroundColor = SystemColors.ControlText;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(8, 96);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(776, 188);
            dgvInventario.TabIndex = 6;
            // 
            // txtNombreItem
            // 
            txtNombreItem.Location = new Point(8, 51);
            txtNombreItem.Name = "txtNombreItem";
            txtNombreItem.Size = new Size(300, 27);
            txtNombreItem.TabIndex = 5;
            txtNombreItem.TextChanged += txtNombreItem_TextChanged;
            // 
            // lblNombreItem
            // 
            lblNombreItem.AutoSize = true;
            lblNombreItem.Location = new Point(8, 18);
            lblNombreItem.Name = "lblNombreItem";
            lblNombreItem.Size = new Size(101, 20);
            lblNombreItem.TabIndex = 4;
            lblNombreItem.Text = "Nombre Ítem:";
            // 
            // cmbTipoItem
            // 
            cmbTipoItem.FormattingEnabled = true;
            cmbTipoItem.Items.AddRange(new object[] { "Bloque", "Objeto", "Mineral", "Herramienta" });
            cmbTipoItem.Location = new Point(350, 51);
            cmbTipoItem.Name = "cmbTipoItem";
            cmbTipoItem.Size = new Size(150, 28);
            cmbTipoItem.TabIndex = 7;
            cmbTipoItem.SelectedIndexChanged += cmbTipoItem_SelectedIndexChanged;
            // 
            // lblTipoItem
            // 
            lblTipoItem.AutoSize = true;
            lblTipoItem.Location = new Point(350, 18);
            lblTipoItem.Name = "lblTipoItem";
            lblTipoItem.Size = new Size(76, 20);
            lblTipoItem.TabIndex = 8;
            lblTipoItem.Text = "Tipo Ítem:";
            // 
            // cmbRarezaItem
            // 
            cmbRarezaItem.FormattingEnabled = true;
            cmbRarezaItem.Items.AddRange(new object[] { "Común", "Raro", "Épico", "Legendario" });
            cmbRarezaItem.Location = new Point(550, 51);
            cmbRarezaItem.Name = "cmbRarezaItem";
            cmbRarezaItem.Size = new Size(150, 28);
            cmbRarezaItem.TabIndex = 9;
            cmbRarezaItem.SelectedIndexChanged += cmbRarezaItem_SelectedIndexChanged;
            // 
            // lblRarezaItem
            // 
            lblRarezaItem.AutoSize = true;
            lblRarezaItem.Location = new Point(550, 18);
            lblRarezaItem.Name = "lblRarezaItem";
            lblRarezaItem.Size = new Size(91, 20);
            lblRarezaItem.TabIndex = 10;
            lblRarezaItem.Text = "Rareza Ítem:";
            // 
            // btnAgregarItem
            // 
            btnAgregarItem.Location = new Point(634, 310);
            btnAgregarItem.Name = "btnAgregarItem";
            btnAgregarItem.Size = new Size(150, 29);
            btnAgregarItem.TabIndex = 3;
            btnAgregarItem.Text = "Agregar Ítem";
            btnAgregarItem.UseVisualStyleBackColor = true;
            btnAgregarItem.Click += btnAgregarItem_Click;
            // 
            // btnBuscarItem
            // 
            btnBuscarItem.Location = new Point(634, 345);
            btnBuscarItem.Name = "btnBuscarItem";
            btnBuscarItem.Size = new Size(150, 29);
            btnBuscarItem.TabIndex = 2;
            btnBuscarItem.Text = "Buscar Ítem";
            btnBuscarItem.UseVisualStyleBackColor = true;
            btnBuscarItem.Click += btnBuscarItem_Click;
            // 
            // btnEliminarItem
            // 
            btnEliminarItem.Location = new Point(634, 380);
            btnEliminarItem.Name = "btnEliminarItem";
            btnEliminarItem.Size = new Size(150, 29);
            btnEliminarItem.TabIndex = 1;
            btnEliminarItem.Text = "Eliminar Ítem";
            btnEliminarItem.UseVisualStyleBackColor = true;
            btnEliminarItem.Click += btnEliminarItem_Click;
            // 
            // tabPageBloques
            // 
            tabPageBloques.Controls.Add(dgvBloques);
            tabPageBloques.Controls.Add(txtNombreBloque);
            tabPageBloques.Controls.Add(lblNombreBloque);
            tabPageBloques.Controls.Add(cmbTipoBloque);
            tabPageBloques.Controls.Add(lblTipoBloque);
            tabPageBloques.Controls.Add(cmbRarezaBloque);
            tabPageBloques.Controls.Add(lblRarezaBloque);
            tabPageBloques.Controls.Add(nudCantidadBloque);
            tabPageBloques.Controls.Add(lblCantidadBloque);
            tabPageBloques.Controls.Add(btnAgregarBloque);
            tabPageBloques.Controls.Add(btnBuscarBloque);
            tabPageBloques.Controls.Add(btnActualizarBloque);
            tabPageBloques.Controls.Add(btnEliminarBloque);
            tabPageBloques.Controls.Add(btnBuscarPorIdBloque);
            tabPageBloques.Controls.Add(btnBuscarPorRarezaBloque);
            tabPageBloques.Location = new Point(4, 29);
            tabPageBloques.Name = "tabPageBloques";
            tabPageBloques.Padding = new Padding(3);
            tabPageBloques.Size = new Size(792, 417);
            tabPageBloques.TabIndex = 2;
            tabPageBloques.Text = "Bloques";
            tabPageBloques.UseVisualStyleBackColor = true;
            // 
            // dgvBloques
            // 
            dgvBloques.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvBloques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBloques.Location = new Point(6, 84);
            dgvBloques.Name = "dgvBloques";
            dgvBloques.RowHeadersWidth = 51;
            dgvBloques.Size = new Size(583, 221);
            dgvBloques.TabIndex = 6;
            dgvBloques.CellContentClick += dgvBloques_CellContentClick;
            // 
            // txtNombreBloque
            // 
            txtNombreBloque.Location = new Point(8, 51);
            txtNombreBloque.Name = "txtNombreBloque";
            txtNombreBloque.Size = new Size(300, 27);
            txtNombreBloque.TabIndex = 5;
            txtNombreBloque.TextChanged += txtNombreBloque_TextChanged;
            // 
            // lblNombreBloque
            // 
            lblNombreBloque.AutoSize = true;
            lblNombreBloque.Location = new Point(8, 18);
            lblNombreBloque.Name = "lblNombreBloque";
            lblNombreBloque.Size = new Size(118, 20);
            lblNombreBloque.TabIndex = 4;
            lblNombreBloque.Text = "Nombre Bloque:";
            // 
            // cmbTipoBloque
            // 
            cmbTipoBloque.FormattingEnabled = true;
            cmbTipoBloque.Items.AddRange(new object[] { "Mineral", "Madera", "Piedra", "Decoración" });
            cmbTipoBloque.Location = new Point(350, 51);
            cmbTipoBloque.Name = "cmbTipoBloque";
            cmbTipoBloque.Size = new Size(150, 28);
            cmbTipoBloque.TabIndex = 7;
            cmbTipoBloque.SelectedIndexChanged += cmbTipoBloque_SelectedIndexChanged;
            // 
            // lblTipoBloque
            // 
            lblTipoBloque.AutoSize = true;
            lblTipoBloque.Location = new Point(350, 18);
            lblTipoBloque.Name = "lblTipoBloque";
            lblTipoBloque.Size = new Size(93, 20);
            lblTipoBloque.TabIndex = 8;
            lblTipoBloque.Text = "Tipo Bloque:";
            // 
            // cmbRarezaBloque
            // 
            cmbRarezaBloque.FormattingEnabled = true;
            cmbRarezaBloque.Items.AddRange(new object[] { "Común", "Raro", "Épico", "Legendario" });
            cmbRarezaBloque.Location = new Point(550, 51);
            cmbRarezaBloque.Name = "cmbRarezaBloque";
            cmbRarezaBloque.Size = new Size(150, 28);
            cmbRarezaBloque.TabIndex = 9;
            cmbRarezaBloque.SelectedIndexChanged += cmbRarezaBloque_SelectedIndexChanged;
            // 
            // lblRarezaBloque
            // 
            lblRarezaBloque.AutoSize = true;
            lblRarezaBloque.Location = new Point(550, 18);
            lblRarezaBloque.Name = "lblRarezaBloque";
            lblRarezaBloque.Size = new Size(108, 20);
            lblRarezaBloque.TabIndex = 10;
            lblRarezaBloque.Text = "Rareza Bloque:";
            // 
            // nudCantidadBloque
            // 
            nudCantidadBloque.Location = new Point(6, 361);
            nudCantidadBloque.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadBloque.Name = "nudCantidadBloque";
            nudCantidadBloque.Size = new Size(150, 27);
            nudCantidadBloque.TabIndex = 11;
            nudCantidadBloque.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadBloque.ValueChanged += nudCantidadBloque_ValueChanged;
            // 
            // lblCantidadBloque
            // 
            lblCantidadBloque.AutoSize = true;
            lblCantidadBloque.Location = new Point(8, 322);
            lblCantidadBloque.Name = "lblCantidadBloque";
            lblCantidadBloque.Size = new Size(129, 20);
            lblCantidadBloque.TabIndex = 12;
            lblCantidadBloque.Text = "Cantidad Bloques:";
            // 
            // btnAgregarBloque
            // 
            btnAgregarBloque.Location = new Point(639, 96);
            btnAgregarBloque.Name = "btnAgregarBloque";
            btnAgregarBloque.Size = new Size(150, 29);
            btnAgregarBloque.TabIndex = 3;
            btnAgregarBloque.Text = "Agregar Bloque";
            btnAgregarBloque.UseVisualStyleBackColor = true;
            btnAgregarBloque.Click += btnAgregarBloque_Click;
            // 
            // btnBuscarBloque
            // 
            btnBuscarBloque.Location = new Point(639, 173);
            btnBuscarBloque.Name = "btnBuscarBloque";
            btnBuscarBloque.Size = new Size(150, 29);
            btnBuscarBloque.TabIndex = 2;
            btnBuscarBloque.Text = "Buscar Bloque";
            btnBuscarBloque.UseVisualStyleBackColor = true;
            btnBuscarBloque.Click += btnBuscarBloque_Click;
            // 
            // btnActualizarBloque
            // 
            btnActualizarBloque.Location = new Point(634, 233);
            btnActualizarBloque.Name = "btnActualizarBloque";
            btnActualizarBloque.Size = new Size(150, 29);
            btnActualizarBloque.TabIndex = 1;
            btnActualizarBloque.Text = "Actualizar Bloque";
            btnActualizarBloque.UseVisualStyleBackColor = true;
            btnActualizarBloque.Click += btnActualizarBloque_Click;
            // 
            // btnEliminarBloque
            // 
            btnEliminarBloque.Location = new Point(235, 350);
            btnEliminarBloque.Name = "btnEliminarBloque";
            btnEliminarBloque.Size = new Size(150, 29);
            btnEliminarBloque.TabIndex = 0;
            btnEliminarBloque.Text = "Eliminar Bloque";
            btnEliminarBloque.UseVisualStyleBackColor = true;
            btnEliminarBloque.Click += btnEliminarBloque_Click;
            // 
            // btnBuscarPorIdBloque
            // 
            btnBuscarPorIdBloque.Location = new Point(423, 350);
            btnBuscarPorIdBloque.Name = "btnBuscarPorIdBloque";
            btnBuscarPorIdBloque.Size = new Size(150, 29);
            btnBuscarPorIdBloque.TabIndex = 13;
            btnBuscarPorIdBloque.Text = "Buscar por ID";
            btnBuscarPorIdBloque.UseVisualStyleBackColor = true;
            btnBuscarPorIdBloque.Click += btnBuscarPorIdBloque_Click;
            // 
            // btnBuscarPorRarezaBloque
            // 
            btnBuscarPorRarezaBloque.Location = new Point(634, 291);
            btnBuscarPorRarezaBloque.Name = "btnBuscarPorRarezaBloque";
            btnBuscarPorRarezaBloque.Size = new Size(150, 29);
            btnBuscarPorRarezaBloque.TabIndex = 14;
            btnBuscarPorRarezaBloque.Text = "Buscar por Rareza";
            btnBuscarPorRarezaBloque.UseVisualStyleBackColor = true;
            btnBuscarPorRarezaBloque.Click += btnBuscarPorRarezaBloque_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Gestión de Minecraft";
            tabControl1.ResumeLayout(false);
            tabPageJugadores.ResumeLayout(false);
            tabPageJugadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNivelJugador).EndInit();
            tabPageInventario.ResumeLayout(false);
            tabPageInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            tabPageBloques.ResumeLayout(false);
            tabPageBloques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBloques).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadBloque).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}