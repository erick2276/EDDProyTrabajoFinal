﻿
using System;

namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnEliminarPredecesor = new System.Windows.Forms.Button();
            this.btnEliminarSucesor = new System.Windows.Forms.Button();
            this.btnAlturaArbol = new System.Windows.Forms.Button();
            this.btnCantidadHojas = new System.Windows.Forms.Button();
            this.btnCantidadNodos = new System.Windows.Forms.Button();
            this.btnHahs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(42, 16);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(52, 26);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(104, 16);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(6, 198);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(581, 392);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(104, 158);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 36);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "podar arbol";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(500, 9);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(72, 32);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(104, 85);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(62, 32);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(6, 21);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(36, 13);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(104, 121);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(62, 34);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(40, 54);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(60, 24);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(176, 119);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(60, 13);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(238, 119);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(186, 95);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(48, 13);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(178, 69);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(55, 13);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(238, 95);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(238, 69);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(57, 13);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(104, 50);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(62, 24);
            this.btnbuscar.TabIndex = 15;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnEliminarPredecesor
            // 
            this.btnEliminarPredecesor.Location = new System.Drawing.Point(500, 53);
            this.btnEliminarPredecesor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPredecesor.Name = "btnEliminarPredecesor";
            this.btnEliminarPredecesor.Size = new System.Drawing.Size(76, 42);
            this.btnEliminarPredecesor.TabIndex = 17;
            this.btnEliminarPredecesor.Text = "Eliminar Predecesor";
            this.btnEliminarPredecesor.UseVisualStyleBackColor = true;
            this.btnEliminarPredecesor.Click += new System.EventHandler(this.btnEliminarPredecesor_Click);
            // 
            // btnEliminarSucesor
            // 
            this.btnEliminarSucesor.Location = new System.Drawing.Point(500, 100);
            this.btnEliminarSucesor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarSucesor.Name = "btnEliminarSucesor";
            this.btnEliminarSucesor.Size = new System.Drawing.Size(76, 47);
            this.btnEliminarSucesor.TabIndex = 18;
            this.btnEliminarSucesor.Text = "Eliminar Sucesor";
            this.btnEliminarSucesor.UseVisualStyleBackColor = true;
            this.btnEliminarSucesor.Click += new System.EventHandler(this.btnEliminarSucesor_Click);
            // 
            // btnAlturaArbol
            // 
            this.btnAlturaArbol.Location = new System.Drawing.Point(188, 158);
            this.btnAlturaArbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlturaArbol.Name = "btnAlturaArbol";
            this.btnAlturaArbol.Size = new System.Drawing.Size(83, 37);
            this.btnAlturaArbol.TabIndex = 19;
            this.btnAlturaArbol.Text = "Altura del arbol";
            this.btnAlturaArbol.UseVisualStyleBackColor = true;
            this.btnAlturaArbol.Click += new System.EventHandler(this.btnAlturaArbol_Click);
            // 
            // btnCantidadHojas
            // 
            this.btnCantidadHojas.Location = new System.Drawing.Point(283, 157);
            this.btnCantidadHojas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCantidadHojas.Name = "btnCantidadHojas";
            this.btnCantidadHojas.Size = new System.Drawing.Size(68, 40);
            this.btnCantidadHojas.TabIndex = 20;
            this.btnCantidadHojas.Text = "Cantidad de hojas";
            this.btnCantidadHojas.UseVisualStyleBackColor = true;
            this.btnCantidadHojas.Click += new System.EventHandler(this.btnCantidadHojas_Click);
            // 
            // btnCantidadNodos
            // 
            this.btnCantidadNodos.Location = new System.Drawing.Point(356, 160);
            this.btnCantidadNodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCantidadNodos.Name = "btnCantidadNodos";
            this.btnCantidadNodos.Size = new System.Drawing.Size(77, 34);
            this.btnCantidadNodos.TabIndex = 21;
            this.btnCantidadNodos.Text = "Cantidad de nodos";
            this.btnCantidadNodos.UseVisualStyleBackColor = true;
            this.btnCantidadNodos.Click += new System.EventHandler(this.btnCantidadNodos_Click);
            // 
            // btnHahs
            // 
            this.btnHahs.Location = new System.Drawing.Point(500, 151);
            this.btnHahs.Margin = new System.Windows.Forms.Padding(2);
            this.btnHahs.Name = "btnHahs";
            this.btnHahs.Size = new System.Drawing.Size(76, 43);
            this.btnHahs.TabIndex = 22;
            this.btnHahs.Text = "Busqueda hash";
            this.btnHahs.UseVisualStyleBackColor = true;
            this.btnHahs.Click += new System.EventHandler(this.btnHahs_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 595);
            this.Controls.Add(this.btnHahs);
            this.Controls.Add(this.btnCantidadNodos);
            this.Controls.Add(this.btnCantidadHojas);
            this.Controls.Add(this.btnAlturaArbol);
            this.Controls.Add(this.btnEliminarSucesor);
            this.Controls.Add(this.btnEliminarPredecesor);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnHahs_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnEliminarPredecesor;
        private System.Windows.Forms.Button btnEliminarSucesor;
        private System.Windows.Forms.Button btnAlturaArbol;
        private System.Windows.Forms.Button btnCantidadHojas;
        private System.Windows.Forms.Button btnCantidadNodos;
        private System.Windows.Forms.Button btnHahs;
    }
}