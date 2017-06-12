namespace ape_arbolBinario
{
    partial class frmPrincipal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.txtResporte = new System.Windows.Forms.TextBox();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(160, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(79, 46);
            this.txtAgregar.Multiline = true;
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(75, 20);
            this.txtAgregar.TabIndex = 1;
            // 
            // txtResporte
            // 
            this.txtResporte.Location = new System.Drawing.Point(125, 117);
            this.txtResporte.Multiline = true;
            this.txtResporte.Name = "txtResporte";
            this.txtResporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResporte.Size = new System.Drawing.Size(155, 83);
            this.txtResporte.TabIndex = 2;
            // 
            // btnInOrder
            // 
            this.btnInOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnInOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInOrder.Location = new System.Drawing.Point(35, 117);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(75, 25);
            this.btnInOrder.TabIndex = 3;
            this.btnInOrder.Text = "InOrder";
            this.btnInOrder.UseVisualStyleBackColor = false;
            this.btnInOrder.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnPreOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreOrder.Location = new System.Drawing.Point(35, 146);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(75, 25);
            this.btnPreOrder.TabIndex = 4;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = false;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnPostOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostOrder.Location = new System.Drawing.Point(35, 175);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(75, 25);
            this.btnPostOrder.TabIndex = 5;
            this.btnPostOrder.Text = "PostOrder";
            this.btnPostOrder.UseVisualStyleBackColor = false;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(79, 72);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(75, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(160, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 251);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.txtResporte);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Árbol binario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.TextBox txtResporte;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}

