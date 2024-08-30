
namespace EjemploLogin
{
    partial class FormConversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversor));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGratis = new System.Windows.Forms.RadioButton();
            this.radkILOG = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radKilogramos = new System.Windows.Forms.RadioButton();
            this.radLitros = new System.Windows.Forms.RadioButton();
            this.radLibra = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Alimento :";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.Black;
            this.txtPeso.Location = new System.Drawing.Point(677, 244);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '*';
            this.txtPeso.Size = new System.Drawing.Size(113, 26);
            this.txtPeso.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(673, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Peso :";
            // 
            // txtTipoA
            // 
            this.txtTipoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoA.ForeColor = System.Drawing.Color.Black;
            this.txtTipoA.Location = new System.Drawing.Point(16, 114);
            this.txtTipoA.Name = "txtTipoA";
            this.txtTipoA.Size = new System.Drawing.Size(156, 26);
            this.txtTipoA.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radGratis);
            this.groupBox2.Controls.Add(this.radkILOG);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(432, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 179);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversion";
            // 
            // radGratis
            // 
            this.radGratis.AutoSize = true;
            this.radGratis.Location = new System.Drawing.Point(28, 86);
            this.radGratis.Name = "radGratis";
            this.radGratis.Size = new System.Drawing.Size(113, 24);
            this.radGratis.TabIndex = 2;
            this.radGratis.TabStop = true;
            this.radGratis.Text = "Onzas (onz)";
            this.radGratis.UseVisualStyleBackColor = true;
            // 
            // radkILOG
            // 
            this.radkILOG.AutoSize = true;
            this.radkILOG.Location = new System.Drawing.Point(28, 41);
            this.radkILOG.Name = "radkILOG";
            this.radkILOG.Size = new System.Drawing.Size(136, 24);
            this.radkILOG.TabIndex = 1;
            this.radkILOG.TabStop = true;
            this.radkILOG.Text = "Kilogramos (kg)";
            this.radkILOG.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.radKilogramos);
            this.groupBox1.Controls.Add(this.radLitros);
            this.groupBox1.Controls.Add(this.radLibra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(197, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 179);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Peso";
            // 
            // radKilogramos
            // 
            this.radKilogramos.AutoSize = true;
            this.radKilogramos.Location = new System.Drawing.Point(25, 131);
            this.radKilogramos.Name = "radKilogramos";
            this.radKilogramos.Size = new System.Drawing.Size(138, 24);
            this.radKilogramos.TabIndex = 2;
            this.radKilogramos.TabStop = true;
            this.radKilogramos.Text = "Kilogramos (Kg)";
            this.radKilogramos.UseVisualStyleBackColor = true;
            // 
            // radLitros
            // 
            this.radLitros.AutoSize = true;
            this.radLitros.Location = new System.Drawing.Point(25, 86);
            this.radLitros.Name = "radLitros";
            this.radLitros.Size = new System.Drawing.Size(94, 24);
            this.radLitros.TabIndex = 1;
            this.radLitros.TabStop = true;
            this.radLitros.Text = "Litros (Lt)";
            this.radLitros.UseVisualStyleBackColor = true;
            // 
            // radLibra
            // 
            this.radLibra.AutoSize = true;
            this.radLibra.Location = new System.Drawing.Point(25, 41);
            this.radLibra.Name = "radLibra";
            this.radLibra.Size = new System.Drawing.Size(102, 24);
            this.radLibra.TabIndex = 0;
            this.radLibra.TabStop = true;
            this.radLibra.Text = "Libras (Lb)";
            this.radLibra.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 131);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gramos (gr)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad :";
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.ForeColor = System.Drawing.Color.Black;
            this.txtCant.Location = new System.Drawing.Point(16, 215);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(77, 26);
            this.txtCant.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(677, 91);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 43);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(263, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Convertir para Cocina";
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 296);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipoA);
            this.Name = "FormConversor";
            this.Text = "FormConversor";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radGratis;
        private System.Windows.Forms.RadioButton radkILOG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radKilogramos;
        private System.Windows.Forms.RadioButton radLitros;
        private System.Windows.Forms.RadioButton radLibra;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
    }
}