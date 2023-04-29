namespace ExemploCalculadora
{
    public class Calculadora : ICalculadora
    {
        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

       public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }

            return num1 / num2;
        }
    }
}