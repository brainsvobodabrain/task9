/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sumel(int m, int n,int step=0, int summ=0){
    if (step<m){
        step=m;
    }
    if (step<=n){
        summ=summ+step;
        
        if (step==n) {
            System.Console.WriteLine($"{summ}");
            return summ;
            }
        step=step+1;         
        summ=summ+sumel(m,n,step,summ);
        return summ;
    }else{
        System.Console.WriteLine($"{summ}");
        return summ;
    }
}
System.Console.Write("Введите M:");
int m=Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите N:");
int n=Convert.ToInt32(Console.ReadLine());
int ss=sumel(m,n);
