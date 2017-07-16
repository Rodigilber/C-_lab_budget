using System;

namespace POSMainForm
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            this.Status_Bar = new System.Windows.Forms.StatusStrip();
            this.user_logged_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGrid_pacientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Status_Bar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Status_Bar
            // 
            this.Status_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_logged_name,
            this.lblDateTime});
            this.Status_Bar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Status_Bar.Location = new System.Drawing.Point(0, 484);
            this.Status_Bar.Name = "Status_Bar";
            this.Status_Bar.Size = new System.Drawing.Size(902, 22);
            this.Status_Bar.TabIndex = 0;
            this.Status_Bar.Text = "Status_Bar-txt";
            // 
            // user_logged_name
            // 
            this.user_logged_name.Name = "user_logged_name";
            this.user_logged_name.Size = new System.Drawing.Size(91, 17);
            this.user_logged_name.Text = "userName_label";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(500, 3, 0, 2);
            this.lblDateTime.MergeIndex = 1;
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(139, 17);
            this.lblDateTime.Text = "toolStripStatusLabel-Text";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.catalogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.seleccionarToolStripMenuItem});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pacienteToolStripMenuItem.Text = "Paciente ";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo ...";
            // 
            // seleccionarToolStripMenuItem
            // 
            this.seleccionarToolStripMenuItem.Name = "seleccionarToolStripMenuItem";
            this.seleccionarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.seleccionarToolStripMenuItem.Text = "Buscar";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.modificarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analisisToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.catalogoToolStripMenuItem.Text = "Catalogo ";
            // 
            // analisisToolStripMenuItem
            // 
            this.analisisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.analisisToolStripMenuItem.Name = "analisisToolStripMenuItem";
            this.analisisToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.analisisToolStripMenuItem.Text = "Analisis";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // timer_main
            // 
            this.timer_main.Enabled = true;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGrid_pacientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items Recientes";
            // 
            // dataGrid_pacientes
            // 
            this.dataGrid_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_pacientes.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_pacientes.Name = "dataGrid_pacientes";
            this.dataGrid_pacientes.Size = new System.Drawing.Size(635, 340);
            this.dataGrid_pacientes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(902, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Status_Bar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-Lab";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Status_Bar.ResumeLayout(false);
            this.Status_Bar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.StatusStrip Status_Bar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel user_logged_name;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGrid_pacientes;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}