namespace CalculadoraPlanilla
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSalarioNeto = new System.Windows.Forms.Label();
            this.lbSeguroEducativo = new System.Windows.Forms.Label();
            this.lbSeguroSocial = new System.Windows.Forms.Label();
            this.labelSalarioN = new System.Windows.Forms.Label();
            this.Labelseguro2 = new System.Windows.Forms.Label();
            this.labelSeguro = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSalarioBruto);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de empleado";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(196, 228);
            this.txtSalarioBruto.MaxLength = 50;
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(185, 26);
            this.txtSalarioBruto.TabIndex = 5;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(196, 150);
            this.txtCedula.MaxLength = 50;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(185, 26);
            this.txtCedula.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(196, 58);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario bruto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "N de identidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Planilla";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSalarioNeto);
            this.groupBox2.Controls.Add(this.lbSeguroEducativo);
            this.groupBox2.Controls.Add(this.lbSeguroSocial);
            this.groupBox2.Controls.Add(this.labelSalarioN);
            this.groupBox2.Controls.Add(this.Labelseguro2);
            this.groupBox2.Controls.Add(this.labelSeguro);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 319);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculos de salario";
            // 
            // lbSalarioNeto
            // 
            this.lbSalarioNeto.AutoSize = true;
            this.lbSalarioNeto.Location = new System.Drawing.Point(169, 222);
            this.lbSalarioNeto.Name = "lbSalarioNeto";
            this.lbSalarioNeto.Size = new System.Drawing.Size(0, 19);
            this.lbSalarioNeto.TabIndex = 5;
            // 
            // lbSeguroEducativo
            // 
            this.lbSeguroEducativo.AutoSize = true;
            this.lbSeguroEducativo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeguroEducativo.Location = new System.Drawing.Point(169, 144);
            this.lbSeguroEducativo.Name = "lbSeguroEducativo";
            this.lbSeguroEducativo.Size = new System.Drawing.Size(0, 18);
            this.lbSeguroEducativo.TabIndex = 4;
            // 
            // lbSeguroSocial
            // 
            this.lbSeguroSocial.AutoSize = true;
            this.lbSeguroSocial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeguroSocial.Location = new System.Drawing.Point(169, 74);
            this.lbSeguroSocial.Name = "lbSeguroSocial";
            this.lbSeguroSocial.Size = new System.Drawing.Size(0, 18);
            this.lbSeguroSocial.TabIndex = 3;
            // 
            // labelSalarioN
            // 
            this.labelSalarioN.AutoSize = true;
            this.labelSalarioN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalarioN.Location = new System.Drawing.Point(24, 222);
            this.labelSalarioN.Name = "labelSalarioN";
            this.labelSalarioN.Size = new System.Drawing.Size(99, 18);
            this.labelSalarioN.TabIndex = 2;
            this.labelSalarioN.Text = "Salario Neto:";
            // 
            // Labelseguro2
            // 
            this.Labelseguro2.AutoSize = true;
            this.Labelseguro2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelseguro2.Location = new System.Drawing.Point(24, 144);
            this.Labelseguro2.Name = "Labelseguro2";
            this.Labelseguro2.Size = new System.Drawing.Size(136, 18);
            this.Labelseguro2.TabIndex = 1;
            this.Labelseguro2.Text = "Seguro Educativo:";
            // 
            // labelSeguro
            // 
            this.labelSeguro.AutoSize = true;
            this.labelSeguro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeguro.Location = new System.Drawing.Point(24, 70);
            this.labelSeguro.Name = "labelSeguro";
            this.labelSeguro.Size = new System.Drawing.Size(111, 18);
            this.labelSeguro.TabIndex = 0;
            this.labelSeguro.Text = "Seguro Social:";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(372, 401);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(146, 55);
            this.btLimpiar.TabIndex = 3;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(135, 401);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(146, 55);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(596, 401);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(146, 55);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 468);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbSeguroSocial;
        private System.Windows.Forms.Label labelSalarioN;
        private System.Windows.Forms.Label Labelseguro2;
        private System.Windows.Forms.Label labelSeguro;
        private System.Windows.Forms.Label lbSalarioNeto;
        private System.Windows.Forms.Label lbSeguroEducativo;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btSalir;
    }
}

