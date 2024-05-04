namespace Serie3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Monto = new TextBox();
            InteresAnual = new TextBox();
            Cuotas = new TextBox();
            Resultado = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            Resultado2 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            Resultado3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(89, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Monto de Prestamo";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(89, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Interes anual";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(89, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Numero de Cuotas";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(89, 299);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "Cuota Mensual";
            // 
            // Monto
            // 
            Monto.Location = new Point(285, 100);
            Monto.Name = "Monto";
            Monto.Size = new Size(125, 27);
            Monto.TabIndex = 4;
            // 
            // InteresAnual
            // 
            InteresAnual.Location = new Point(285, 165);
            InteresAnual.Name = "InteresAnual";
            InteresAnual.Size = new Size(125, 27);
            InteresAnual.TabIndex = 5;
            // 
            // Cuotas
            // 
            Cuotas.Location = new Point(285, 239);
            Cuotas.Name = "Cuotas";
            Cuotas.Size = new Size(125, 27);
            Cuotas.TabIndex = 6;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(285, 299);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(0, 20);
            Resultado.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(472, 100);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(607, 100);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(89, 367);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 10;
            textBox5.Text = "Total a Pagar";
            // 
            // Resultado2
            // 
            Resultado2.AutoSize = true;
            Resultado2.Location = new Point(285, 374);
            Resultado2.Name = "Resultado2";
            Resultado2.Size = new Size(0, 20);
            Resultado2.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(271, 12);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(261, 27);
            textBox6.TabIndex = 12;
            textBox6.Text = "Calculadora de cuotas de un prestamo";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(461, 165);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 13;
            textBox7.Text = "Total de Intereses";
            // 
            // Resultado3
            // 
            Resultado3.AutoSize = true;
            Resultado3.Location = new Point(607, 168);
            Resultado3.Name = "Resultado3";
            Resultado3.Size = new Size(0, 20);
            Resultado3.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado3);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(Resultado2);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Resultado);
            Controls.Add(Cuotas);
            Controls.Add(InteresAnual);
            Controls.Add(Monto);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox Monto;
        private TextBox InteresAnual;
        private TextBox Cuotas;
        private Label Resultado;
        private Button button1;
        private Button button2;
        private TextBox textBox5;
        private Label Resultado2;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label Resultado3;
    }
}
