
namespace WindowsForms
{
    partial class FormBosstrap
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
            this.Nombre = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.butmostrar = new System.Windows.Forms.Button();
            this.checkAceptar = new System.Windows.Forms.CheckBox();
            this.radMujer = new System.Windows.Forms.RadioButton();
            this.radHombre = new System.Windows.Forms.RadioButton();
            this.radOtro = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listPaises = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(12, 18);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(144, 16);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Escribe un Mensaje";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(162, 18);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(204, 20);
            this.txtMensaje.TabIndex = 1;
            // 
            // butmostrar
            // 
            this.butmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmostrar.Location = new System.Drawing.Point(96, 237);
            this.butmostrar.Name = "butmostrar";
            this.butmostrar.Size = new System.Drawing.Size(158, 23);
            this.butmostrar.TabIndex = 2;
            this.butmostrar.Text = "Mostrar Mensaje";
            this.butmostrar.UseVisualStyleBackColor = true;
            this.butmostrar.Click += new System.EventHandler(this.butmostrar_Click);
            // 
            // checkAceptar
            // 
            this.checkAceptar.AutoSize = true;
            this.checkAceptar.Location = new System.Drawing.Point(115, 195);
            this.checkAceptar.Name = "checkAceptar";
            this.checkAceptar.Size = new System.Drawing.Size(124, 17);
            this.checkAceptar.TabIndex = 3;
            this.checkAceptar.Text = "Aceptar Condiciones";
            this.checkAceptar.UseVisualStyleBackColor = true;
            // 
            // radMujer
            // 
            this.radMujer.AutoSize = true;
            this.radMujer.Location = new System.Drawing.Point(6, 20);
            this.radMujer.Name = "radMujer";
            this.radMujer.Size = new System.Drawing.Size(51, 17);
            this.radMujer.TabIndex = 4;
            this.radMujer.TabStop = true;
            this.radMujer.Text = "Mujer";
            this.radMujer.UseVisualStyleBackColor = true;
            // 
            // radHombre
            // 
            this.radHombre.AutoSize = true;
            this.radHombre.Location = new System.Drawing.Point(6, 43);
            this.radHombre.Name = "radHombre";
            this.radHombre.Size = new System.Drawing.Size(62, 17);
            this.radHombre.TabIndex = 5;
            this.radHombre.TabStop = true;
            this.radHombre.Text = "Hombre";
            this.radHombre.UseVisualStyleBackColor = true;
            // 
            // radOtro
            // 
            this.radOtro.AutoSize = true;
            this.radOtro.Location = new System.Drawing.Point(6, 67);
            this.radOtro.Name = "radOtro";
            this.radOtro.Size = new System.Drawing.Size(43, 17);
            this.radOtro.TabIndex = 6;
            this.radOtro.TabStop = true;
            this.radOtro.Text = "otro";
            this.radOtro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radHombre);
            this.groupBox1.Controls.Add(this.radOtro);
            this.groupBox1.Controls.Add(this.radMujer);
            this.groupBox1.Location = new System.Drawing.Point(15, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // listPaises
            // 
            this.listPaises.FormattingEnabled = true;
            this.listPaises.Items.AddRange(new object[] {
            "España",
            "Argentina",
            "Peru",
            "Holanda",
            "Francia",
            "Alemania",
            "Italia"});
            this.listPaises.Location = new System.Drawing.Point(246, 58);
            this.listPaises.Name = "listPaises";
            this.listPaises.Size = new System.Drawing.Size(120, 95);
            this.listPaises.TabIndex = 8;
            // 
            // FormBosstrap
            // 
            this.ClientSize = new System.Drawing.Size(376, 272);
            this.Controls.Add(this.listPaises);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkAceptar);
            this.Controls.Add(this.butmostrar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.Nombre);
            this.Name = "FormBosstrap";
            this.Text = "Prueba de Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button butmostrar;
        private System.Windows.Forms.CheckBox checkAceptar;
        private System.Windows.Forms.RadioButton radMujer;
        private System.Windows.Forms.RadioButton radHombre;
        private System.Windows.Forms.RadioButton radOtro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listPaises;
    }
}

