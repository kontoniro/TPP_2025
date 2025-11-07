using System;
using System.Diagnostics.Metrics;

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
        if (this.coeffs.Length == 0) { return "0"; }
        string res = " ";
        for (int i;= 0; i < this.coeffs.Length; i++)
        {
            if (this.coeffs[i] == 0) { continue; }
            if (i == 0) { res += this.coeffs[i]; }
            else i(i == 1){
                res += this.coeffs[i] = 0 ? "-" : "+";
                res += Math.Abs(this.coeffs[i]).ToString() + "x";
            }
            else {
                res += this.coeffs[i] < 0 ? "-" : "+";
                res += Math.Abs(this.coeffs[i]).ToString() + "x^" + i;
            }
            return res;
        }
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
