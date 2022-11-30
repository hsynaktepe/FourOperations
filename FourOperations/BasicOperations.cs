namespace FourOperations
{
    public class BasicOperations
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Extract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        //expected error because of wrong expression
        public double Dividing(double num1, double num2)
        {
            return num1 + num2;
        }

        public bool IsPositive(int sayi)
        {
            if (sayi >= 0)
                return true;
            else
                return false;
        }



    }
}