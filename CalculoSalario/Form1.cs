namespace CalculoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double salarioBruto = 
                Convert.ToDouble(txtSalarioBruto.Text);
            int dependentes =
                Convert.ToInt32(txtDependentes.Text);

            double valeTransporte = CalcularVT(salarioBruto);
            double inss = CalcularINSS(salarioBruto);
            double irrf = CalcularIRRF(salarioBruto, inss, dependentes);
            double salarioLiquido = salarioBruto - valeTransporte - inss - irrf;

            MessageBox.Show($"Vale Transporte: {valeTransporte}");
            MessageBox.Show($"INSS: {inss}");
            MessageBox.Show($"IRFF: {irrf}");
            MessageBox.Show($"Salário Líquido: {salarioLiquido}");
        }

        private double CalcularVT(double salario)
        {
            double desconto = salario * 0.06;
            return desconto;
        }

        private double CalcularINSS(double salario)
        {
            double desconto = 0;

            if (salario <= 1412.00)
            {
                desconto = salario * 0.075;
            }
            else if (salario <= 2666.68)
            {
                desconto = salario * 0.09;
            }
            else if (salario <= 4000.03)
            {
                desconto = salario * 0.12;
            }
            else if (salario <= 7786.02)
            {
                desconto = salario * 0.14;
            }
            else
            {
                desconto = 7786.02 * 0.14;
            }
            
            return desconto;
        }

        private double CalcularIRRF(double salario, double inss, 
                                int dependentes)
        {
            double desconto = 0;
            double salarioBase = salario - inss - dependentes * 189.59;

            if (salarioBase <= 2112.00)
            {
                desconto = 0;
            }
            else if (salarioBase <= 2826.65)
            {
                desconto = salarioBase * 0.075 - 158.40;
            }
            else if (salarioBase <= 3751.05)
            {
                desconto = salarioBase * 0.15 - 370.40;
            }
            else if (salarioBase <= 4664.68)
            {
                desconto = salarioBase * 0.225 - 651.73;
            }
            else
            {
                desconto = salarioBase * 0.275 - 884.96;
            }

            return desconto;
        }


    }
}
