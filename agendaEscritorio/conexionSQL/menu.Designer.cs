﻿namespace conexionSQL
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgMostrarDatos = new System.Windows.Forms.DataGridView();
            this.tiposDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.verTodaLaTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbNombreUsu = new System.Windows.Forms.CheckBox();
            this.ckbClave = new System.Windows.Forms.CheckBox();
            this.ckbTipoCuenta = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.verToolStripMenuItem,
            this.acerdaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.acerdaDeToolStripMenuItem.Text = "Acerca de ";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeCuentasToolStripMenuItem,
            this.verTodaLaTablaToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // dtgMostrarDatos
            // 
            this.dtgMostrarDatos.AllowUserToAddRows = false;
            this.dtgMostrarDatos.AllowUserToDeleteRows = false;
            this.dtgMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostrarDatos.Location = new System.Drawing.Point(25, 47);
            this.dtgMostrarDatos.Name = "dtgMostrarDatos";
            this.dtgMostrarDatos.ReadOnly = true;
            this.dtgMostrarDatos.Size = new System.Drawing.Size(399, 171);
            this.dtgMostrarDatos.TabIndex = 1;
            // 
            // tiposDeCuentasToolStripMenuItem
            // 
            this.tiposDeCuentasToolStripMenuItem.Name = "tiposDeCuentasToolStripMenuItem";
            this.tiposDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiposDeCuentasToolStripMenuItem.Text = "Tipos de cuentas";
            this.tiposDeCuentasToolStripMenuItem.Click += new System.EventHandler(this.tiposDeCuentasToolStripMenuItem_Click);
            // 
            // verTodaLaTablaToolStripMenuItem
            // 
            this.verTodaLaTablaToolStripMenuItem.Name = "verTodaLaTablaToolStripMenuItem";
            this.verTodaLaTablaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verTodaLaTablaToolStripMenuItem.Text = "Ver toda la tabla";
            this.verTodaLaTablaToolStripMenuItem.Click += new System.EventHandler(this.verTodaLaTablaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbTipoCuenta);
            this.panel1.Controls.Add(this.ckbClave);
            this.panel1.Controls.Add(this.ckbNombreUsu);
            this.panel1.Location = new System.Drawing.Point(13, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 117);
            this.panel1.TabIndex = 2;
            // 
            // ckbNombreUsu
            // 
            this.ckbNombreUsu.AutoSize = true;
            this.ckbNombreUsu.Enabled = false;
            this.ckbNombreUsu.Location = new System.Drawing.Point(34, 13);
            this.ckbNombreUsu.Name = "ckbNombreUsu";
            this.ckbNombreUsu.Size = new System.Drawing.Size(117, 17);
            this.ckbNombreUsu.TabIndex = 0;
            this.ckbNombreUsu.Text = "Nombre de Usuario";
            this.ckbNombreUsu.UseVisualStyleBackColor = true;
            this.ckbNombreUsu.CheckedChanged += new System.EventHandler(this.ckbNombreUsu_CheckedChanged);
            // 
            // ckbClave
            // 
            this.ckbClave.AutoSize = true;
            this.ckbClave.Enabled = false;
            this.ckbClave.Location = new System.Drawing.Point(34, 37);
            this.ckbClave.Name = "ckbClave";
            this.ckbClave.Size = new System.Drawing.Size(52, 17);
            this.ckbClave.TabIndex = 1;
            this.ckbClave.Text = "clave";
            this.ckbClave.UseVisualStyleBackColor = true;
            this.ckbClave.CheckedChanged += new System.EventHandler(this.ckbClave_CheckedChanged);
            // 
            // ckbTipoCuenta
            // 
            this.ckbTipoCuenta.AutoSize = true;
            this.ckbTipoCuenta.Enabled = false;
            this.ckbTipoCuenta.Location = new System.Drawing.Point(203, 13);
            this.ckbTipoCuenta.Name = "ckbTipoCuenta";
            this.ckbTipoCuenta.Size = new System.Drawing.Size(98, 17);
            this.ckbTipoCuenta.TabIndex = 2;
            this.ckbTipoCuenta.Text = "Tipo de cuenta";
            this.ckbTipoCuenta.UseVisualStyleBackColor = true;
            this.ckbTipoCuenta.CheckedChanged += new System.EventHandler(this.ckbTipoCuenta_CheckedChanged);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgMostrarDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCuentasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgMostrarDatos;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem verTodaLaTablaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbClave;
        private System.Windows.Forms.CheckBox ckbNombreUsu;
        private System.Windows.Forms.CheckBox ckbTipoCuenta;
    }
}