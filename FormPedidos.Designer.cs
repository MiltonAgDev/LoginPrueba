
namespace EjemploLogin
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPremiun = new System.Windows.Forms.RadioButton();
            this.radExpress = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGratis = new System.Windows.Forms.RadioButton();
            this.radCasa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.radPremiun);
            this.groupBox1.Controls.Add(this.radExpress);
            this.groupBox1.Controls.Add(this.radNormal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(35, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Envió";
            // 
            // radPremiun
            // 
            this.radPremiun.AutoSize = true;
            this.radPremiun.Location = new System.Drawing.Point(25, 131);
            this.radPremiun.Name = "radPremiun";
            this.radPremiun.Size = new System.Drawing.Size(185, 22);
            this.radPremiun.TabIndex = 2;
            this.radPremiun.TabStop = true;
            this.radPremiun.Text = "Premiun (2 Dias $20)";
            this.radPremiun.UseVisualStyleBackColor = true;
            // 
            // radExpress
            // 
            this.radExpress.AutoSize = true;
            this.radExpress.Location = new System.Drawing.Point(25, 86);
            this.radExpress.Name = "radExpress";
            this.radExpress.Size = new System.Drawing.Size(240, 22);
            this.radExpress.TabIndex = 1;
            this.radExpress.TabStop = true;
            this.radExpress.Text = "Envio Express (10 Dias $10)";
            this.radExpress.UseVisualStyleBackColor = true;
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(25, 41);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(225, 22);
            this.radNormal.TabIndex = 0;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Envio Normal (20 Dias $5)";
            this.radNormal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(471, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "     Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.AutoSize = true;
            this.btnMostrar.BackColor = System.Drawing.Color.White;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(191, 284);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(118, 43);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.radGratis);
            this.groupBox2.Controls.Add(this.radCasa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(406, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 179);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de Entrega";
            // 
            // radGratis
            // 
            this.radGratis.AutoSize = true;
            this.radGratis.Location = new System.Drawing.Point(28, 86);
            this.radGratis.Name = "radGratis";
            this.radGratis.Size = new System.Drawing.Size(257, 22);
            this.radGratis.TabIndex = 2;
            this.radGratis.TabStop = true;
            this.radGratis.Text = "Recogerlo en Correos (Gratis)";
            this.radGratis.UseVisualStyleBackColor = true;
            // 
            // radCasa
            // 
            this.radCasa.AutoSize = true;
            this.radCasa.Location = new System.Drawing.Point(28, 41);
            this.radCasa.Name = "radCasa";
            this.radCasa.Size = new System.Drawing.Size(100, 22);
            this.radCasa.TabIndex = 1;
            this.radCasa.TabStop = true;
            this.radCasa.Text = "Casa ($5)";
            this.radCasa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elija como desea recibir su Pedido :";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radPremiun;
        private System.Windows.Forms.RadioButton radExpress;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radGratis;
        private System.Windows.Forms.RadioButton radCasa;
        private System.Windows.Forms.Label label1;
    }
}