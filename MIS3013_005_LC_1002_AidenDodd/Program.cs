//MIS 3013 005
//October 02, 2023
//Aiden Dodd, 113556164
Console.WriteLine("Functions");

int age;
age=Convert.ToInt32("23");// function call

double r;

r=adddouble(10,20.6);

Console.WriteLine(r);

//add of two double values, the result is a double 
double adddouble(double x1, double x2)
{
    double r;
    r = x1 + x2;
    return r;
}