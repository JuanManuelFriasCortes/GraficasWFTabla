namespace WindowsFormTabla
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
            PanelPrincipal = new Panel();
            LabelNombre = new Label();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            LabelNumero = new Label();
            LabelTitulo = new Label();
            PanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = Color.Coral;
            PanelPrincipal.Controls.Add(LabelNombre);
            PanelPrincipal.Controls.Add(richTextBoxResultados);
            PanelPrincipal.Controls.Add(buttonVer);
            PanelPrincipal.Controls.Add(textBoxNum);
            PanelPrincipal.Controls.Add(LabelNumero);
            PanelPrincipal.Controls.Add(LabelTitulo);
            PanelPrincipal.Location = new Point(0, 0);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(799, 450);
            PanelPrincipal.TabIndex = 0;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.BackColor = Color.RosyBrown;
            LabelNombre.Location = new Point(305, 23);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(171, 20);
            LabelNombre.TabIndex = 5;
            LabelNombre.Text = "Juan Manuel Frias Cortes";
            LabelNombre.Click += label1_Click;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(305, 81);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(171, 295);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.RosyBrown;
            buttonVer.Font = new Font("Tw Cen MT Condensed Extra Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVer.Location = new Point(95, 183);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(94, 29);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "ver Tabla";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(95, 150);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(125, 27);
            textBoxNum.TabIndex = 2;
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize = true;
            LabelNumero.BackColor = Color.RosyBrown;
            LabelNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelNumero.Location = new Point(95, 115);
            LabelNumero.Name = "LabelNumero";
            LabelNumero.Size = new Size(136, 20);
            LabelNumero.TabIndex = 1;
            LabelNumero.Text = "Que tabla quieres?";
            // 
            // LabelTitulo
            // 
            LabelTitulo.AutoSize = true;
            LabelTitulo.BackColor = Color.RosyBrown;
            LabelTitulo.Location = new Point(95, 53);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(142, 20);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "Tabla De Multiplicar";
            LabelTitulo.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelPrincipal);
            Name = "Form1";
            Text = "Form1";
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPrincipal;
        private Label LabelTitulo;
        private Button buttonVer;
        private TextBox textBoxNum;
        private Label LabelNumero;
        private RichTextBox richTextBoxResultados;
        private Label LabelNombre;
    }
}
