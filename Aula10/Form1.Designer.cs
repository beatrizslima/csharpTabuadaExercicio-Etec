
namespace Aula10
{
    partial class FormPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lavelValor = new System.Windows.Forms.Label();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.buttonMostrar1 = new System.Windows.Forms.Button();
            this.buttonMostrar2 = new System.Windows.Forms.Button();
            this.numericUpDownValor = new System.Windows.Forms.NumericUpDown();
            this.listBoxTab1 = new System.Windows.Forms.ListBox();
            this.listBoxTab2 = new System.Windows.Forms.ListBox();
            this.numericUpDownTab1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTab2 = new System.Windows.Forms.NumericUpDown();
            this.buttonMostrarTab1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTab2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownValor);
            this.panel1.Controls.Add(this.buttonMostrar2);
            this.panel1.Controls.Add(this.buttonMostrar1);
            this.panel1.Controls.Add(this.listBoxNumeros);
            this.panel1.Controls.Add(this.lavelValor);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonMostrarTab1);
            this.panel2.Controls.Add(this.numericUpDownTab1);
            this.panel2.Controls.Add(this.listBoxTab1);
            this.panel2.Location = new System.Drawing.Point(349, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 238);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.numericUpDownTab2);
            this.panel3.Controls.Add(this.listBoxTab2);
            this.panel3.Location = new System.Drawing.Point(350, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 222);
            this.panel3.TabIndex = 2;
            // 
            // lavelValor
            // 
            this.lavelValor.AutoSize = true;
            this.lavelValor.Location = new System.Drawing.Point(48, 92);
            this.lavelValor.Name = "lavelValor";
            this.lavelValor.Size = new System.Drawing.Size(91, 13);
            this.lavelValor.TabIndex = 0;
            this.lavelValor.Text = "Escolha um valor:";
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(51, 133);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(120, 238);
            this.listBoxNumeros.TabIndex = 1;
            this.listBoxNumeros.SelectedIndexChanged += new System.EventHandler(this.listBoxNumeros_SelectedIndexChanged);
            // 
            // buttonMostrar1
            // 
            this.buttonMostrar1.Location = new System.Drawing.Point(202, 188);
            this.buttonMostrar1.Name = "buttonMostrar1";
            this.buttonMostrar1.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar1.TabIndex = 2;
            this.buttonMostrar1.Text = "Mostrar 1";
            this.buttonMostrar1.UseVisualStyleBackColor = true;
            this.buttonMostrar1.Click += new System.EventHandler(this.buttonMostrar1_Click);
            // 
            // buttonMostrar2
            // 
            this.buttonMostrar2.Location = new System.Drawing.Point(202, 252);
            this.buttonMostrar2.Name = "buttonMostrar2";
            this.buttonMostrar2.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar2.TabIndex = 3;
            this.buttonMostrar2.Text = "Mostrar 2";
            this.buttonMostrar2.UseVisualStyleBackColor = true;
            this.buttonMostrar2.Click += new System.EventHandler(this.buttonMostrar2_Click);
            // 
            // numericUpDownValor
            // 
            this.numericUpDownValor.Location = new System.Drawing.Point(202, 90);
            this.numericUpDownValor.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownValor.Name = "numericUpDownValor";
            this.numericUpDownValor.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownValor.TabIndex = 4;
            this.numericUpDownValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxTab1
            // 
            this.listBoxTab1.FormattingEnabled = true;
            this.listBoxTab1.Location = new System.Drawing.Point(14, 90);
            this.listBoxTab1.Name = "listBoxTab1";
            this.listBoxTab1.Size = new System.Drawing.Size(407, 121);
            this.listBoxTab1.TabIndex = 0;
            // 
            // listBoxTab2
            // 
            this.listBoxTab2.FormattingEnabled = true;
            this.listBoxTab2.Location = new System.Drawing.Point(14, 76);
            this.listBoxTab2.Name = "listBoxTab2";
            this.listBoxTab2.Size = new System.Drawing.Size(407, 134);
            this.listBoxTab2.TabIndex = 0;
            // 
            // numericUpDownTab1
            // 
            this.numericUpDownTab1.Location = new System.Drawing.Point(240, 44);
            this.numericUpDownTab1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTab1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTab1.Name = "numericUpDownTab1";
            this.numericUpDownTab1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownTab1.TabIndex = 1;
            this.numericUpDownTab1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTab2
            // 
            this.numericUpDownTab2.Location = new System.Drawing.Point(240, 41);
            this.numericUpDownTab2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTab2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTab2.Name = "numericUpDownTab2";
            this.numericUpDownTab2.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownTab2.TabIndex = 2;
            this.numericUpDownTab2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonMostrarTab1
            // 
            this.buttonMostrarTab1.Location = new System.Drawing.Point(99, 42);
            this.buttonMostrarTab1.Name = "buttonMostrarTab1";
            this.buttonMostrarTab1.Size = new System.Drawing.Size(67, 20);
            this.buttonMostrarTab1.TabIndex = 2;
            this.buttonMostrarTab1.Text = "Mostrar";
            this.buttonMostrarTab1.UseVisualStyleBackColor = true;
            this.buttonMostrarTab1.Click += new System.EventHandler(this.buttonMostrarTab1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Beatriz Santos Lima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Juliana Sabino Lourenço Silva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Escolha um valor para calcular a tabuada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Escolha um valor para calcular a tabuada:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "Estrutura de Repetição";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTab2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonMostrar2;
        private System.Windows.Forms.Button buttonMostrar1;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Label lavelValor;
        private System.Windows.Forms.NumericUpDown numericUpDownValor;
        private System.Windows.Forms.Button buttonMostrarTab1;
        private System.Windows.Forms.NumericUpDown numericUpDownTab1;
        private System.Windows.Forms.ListBox listBoxTab1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownTab2;
        private System.Windows.Forms.ListBox listBoxTab2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

