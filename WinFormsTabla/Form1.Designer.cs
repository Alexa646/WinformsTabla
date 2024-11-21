namespace WinFormsTabla
{
    partial class Form1
    {
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
            panelprincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumeros = new Label();
            labeltitulo = new Label();
            labelnombre = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(255, 192, 192);
            panelprincipal.Controls.Add(labelnombre);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumeros);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(12, 12);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(776, 426);
            panelprincipal.TabIndex = 0;
            panelprincipal.Paint += panel1_Paint;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Location = new Point(261, 82);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(383, 320);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = Color.White;
            buttonver.Location = new Point(15, 179);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(75, 23);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver Tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(15, 136);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(181, 23);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumeros
            // 
            labelnumeros.AutoSize = true;
            labelnumeros.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnumeros.Location = new Point(15, 84);
            labelnumeros.Name = "labelnumeros";
            labelnumeros.Size = new Size(181, 25);
            labelnumeros.TabIndex = 1;
            labelnumeros.Text = "¿Cual tabla quieres?";
            labelnumeros.Click += labelnumeros_Click;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitulo.Location = new Point(15, 13);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(240, 32);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de multiplicar";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnombre.Location = new Point(15, 45);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(412, 25);
            labelnombre.TabIndex = 5;
            labelnombre.Text = "Hecho por: Alexander Vladimir Rangel Gudiño ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labelnumeros;
        private Label labeltitulo;
        private Button buttonver;
        private TextBox textBoxnum;
        private RichTextBox richTextBoxresultados;
        private Label labelnombre;
    }
}
