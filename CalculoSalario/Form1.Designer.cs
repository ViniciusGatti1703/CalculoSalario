namespace CalculoSalario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtSalarioBruto = new TextBox();
            txtDependentes = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 65);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Salário Bruto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 104);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Nro Dependentes";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Chartreuse;
            txtNome.Location = new Point(139, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(116, 23);
            txtNome.TabIndex = 3;
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.BackColor = Color.Chartreuse;
            txtSalarioBruto.Location = new Point(139, 60);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.Size = new Size(116, 23);
            txtSalarioBruto.TabIndex = 4;
            // 
            // txtDependentes
            // 
            txtDependentes.BackColor = Color.Chartreuse;
            txtDependentes.Location = new Point(139, 96);
            txtDependentes.Name = "txtDependentes";
            txtDependentes.Size = new Size(116, 23);
            txtDependentes.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Black;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(104, 153);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(306, 432);
            Controls.Add(btnCalcular);
            Controls.Add(txtDependentes);
            Controls.Add(txtSalarioBruto);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtSalarioBruto;
        private TextBox txtDependentes;
        private Button btnCalcular;
    }
}
