using System;

namespace profesional3_visualnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1;
            Console.WriteLine("Que programa quieres Ejecutar \n 1) Pedir por teclado \n 2) Perimetro de cuadrado");
            Console.WriteLine("3) Ejercicio Condicional 1");
            Console.WriteLine("4) Ejercicio Condicional 3");
            num1 = Console.ReadLine();
            if(int.Parse(num1) == 1){
                pedirporteclado();
            } else if(int.Parse(num1) == 2){
                perimetro();
            } else if(int.Parse(num1) == 3){
                condicional1();
            }else if(int.Parse(num1) == 4){
                condicional3();
            }
        }

        static void pedirporteclado(){
            Console.WriteLine("Hello World!");
            int num1, num2, suma, producto; 
            string linea; 
            Console.Write("Ingrese primer valor:"); 
            linea = Console.ReadLine(); 
            num1 = int.Parse(linea); 
            Console.Write("Ingrese segundo valor:"); 
            linea = Console.ReadLine(); 
            num2 = int.Parse(linea); 
            suma = num1 + num2; 
            producto = num1 * num2; 
            Console.Write("La suma de los dos valores es:"); 
            Console.WriteLine(suma); 
            Console.Write("El producto de los dos valores es:"); 
            Console.WriteLine(producto); Console.ReadKey();
        }

        static void perimetro(){
            Console.WriteLine("Vamos a calcular el perimetro de un cuadrado:");
            int perimetro;
            string linea;
            Console.Write("Por favor ingrese el tamaño de un lado del cuadrado:");
            linea = Console.ReadLine();  
            perimetro = int.Parse(linea)*4;
            Console.Write("El perimetro del cuadro es:");
            Console.WriteLine(perimetro);  
        }

        static void condicional1(){
            Console.Write("EJERCICIO 1 CONDICIONALES \n");
            int num1, num2; 
            string linea; 
            Console.Write("Ingrese primer valor:"); 
            linea = Console.ReadLine(); 
            num1 = int.Parse(linea); 
            Console.Write("Ingrese segundo valor:"); 
            linea = Console.ReadLine(); 
            num2 = int.Parse(linea); 
            if(num1 > num2){
                Console.Write("La suma de los numeros es: \n");
                Console.Write(num1+num2); 
                Console.Write("\n La diferencia es:");
                Console.Write(num1-num2);
            }
        }

        static void condicional3(){
            Console.Write("EJERCICIO 2 CONDICIONALES \n");
            string linea; 
            Console.Write("Ingrese valor:"); 
            linea = Console.ReadLine(); 
            Console.Write(linea.Length);
            if(linea.Length == 1){
                Console.Write("El numero tiene solo un digito");
            } else if(linea.Length == 2){
                Console.Write("El numero tiene dos digitos");
            }else{
                Console.Write("El numero ingresado no es valido");
            }
        }


       
    }
}
