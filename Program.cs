using System;

class Polynomial
{
    private int degree;
    private double[] coeffs;

    public Polynomial()
    {
        degree = 0;
        coeffs = new double[1] { 0.0 };
    }

    public Polynomial(double[] new_coeffs)
    {
        degree = new_coeffs.Length - 1;
        coeffs = (double[])new_coeffs.Clone();
    }

    public int Degree
    {
        get { return degree; }
    }

    public double[] Coeffs
    {
        get { return (double[])coeffs.Clone(); }
    }

    public override string ToString()
    {
        for (int i = 0; i < coeffs.Length; i++)
        {
            double currentCoeff = coeffs[i];
        if (Math.Abs(currentCoeff) < double.Epsilon)
            {
                continue;
            }
        if (currentCoeff > 0)
         if (!isFirstTerm)
                {
                    sb.Append(" + ");
                }
            }
            else
            {
                sb.Append(" - ")
            }
            string coeffString = currentCoeff.ToString();
            if (i == 0)
            {
                sb.Append(coeffString);
            }
            else if (i == 1)
            {
                if (currentCoeff != 1.0)
                {
                    sb.Append(coeffString);
                }
                sb.Append("x");
            }
            else
            {
                if (currentCoeff != 1.0)
                {
                    sb.Append(coeffString);
                }
                sb.Append("x^").Append(i);
            }
        return "";
    }
}

class Programm
{
    static void Main(string[] args)
    {
        double[] coeffs = { 1.0, 0.0, 2.0 };
        Polynomial p = new Polynomial(coeffs); // 1 + 2x^2

        Console.WriteLine(p);
    }
}