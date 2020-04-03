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

        static void codicionalswitch1(){
            Console.Write("Ingrese un valor entre 1 y 5:");
            int valor = int.Parse(Console.ReadLine());
            switch (valor)
            {
                case 1: Console.Write("uno");
                        break;
                case 2: Console.Write("dos");
                        break;
                case 3: Console.Write("tres");
                        break;
                case 4: Console.Write("cuatro");
                        break;
                case 5: Console.Write("cinco");
                        break;
                default:
                        Console.Write("Se ingreso un valor fuera de rango");
                        break;
            }
            Console.ReadKey();
        }

        static void codicionalswitch2(){
            Console.Write("Ingrese un número en castellano entre uno y cinco:");
            string nro = Console.ReadLine();
            switch (nro)
            {
                case "uno": Console.Write(1);
                            break;
                case "dos": Console.Write(2);
                            break;
                case "tres": Console.Write(3);
                            break;
                case "cuatro": Console.Write(4);
                            break;
                case "cinco": Console.Write(5);
                            break;
                default: Console.Write("Debe ingresar un valor entre uno y cinco");
                            break;
            }
            Console.ReadKey();
        }



        static void ciclowhile1(){
            int suma,f,valor,promedio;
            string linea;
            suma=0;
            for(f=1;f<=10;f++) 
            {
                Console.Write("Ingrese valor:");
                linea=Console.ReadLine();
                valor=int.Parse(linea);
                suma=suma+valor;
            }
            Console.Write("La suma es:");
            Console.WriteLine(suma);
            promedio=suma/10;
            Console.Write("El promedio es:");
            Console.Write(promedio);
            Console.ReadKey();
        }

        static void ciclowhile2(int x){
            while (x <= 100)
            {
            Console.Write(x);
            Console.Write(" - ");
            x = x + 1;
            }
        }

        staic void ciclowhile2(){
            int x,suma,valor,promedio;
            string linea;
            x=1;
            suma=0;
            while (x<=10) 
            {
                Console.Write("Ingrese un valor:");
                linea = Console.ReadLine();
                valor=int.Parse(linea);
                suma=suma+valor;
                x=x+1;
            }
            promedio=suma/10;
            Console.Write("La suma de los 10 valores es:");
            Console.WriteLine(suma);
            Console.Write("El promedio es:");
            Console.Write(promedio);
            Console.ReadKey();
        }

        static void ciclofor3(int suma, int f, int valor, int promedio){

            string linea = "";
            suma=0;
            for(f=1;f<=10;f++) 
            {
                Console.Write("Ingrese valor:");
                linea=Console.ReadLine();
                valor=int.Parse(linea);
                suma=suma+valor;
            }
            Console.Write("La suma es:");
            Console.WriteLine(suma);
            promedio=suma/10;
            Console.Write("El promedio es:");
            Console.Write(promedio);
            Console.ReadKey();
        }

        static void ciclofor4(int aprobados, int reprobados, int f, int nota){
            string linea;
            aprobados=0;
            reprobados=0;
            for(f=1;f<=10;f++) 
            {
                Console.Write("Ingrese la nota:");
                linea = Console.ReadLine();
                nota=int.Parse(linea);
                if (nota>=7) 
                {
                    aprobados=aprobados+1;
                }
                else
                {
            	    reprobados=reprobados+1;
                }
            }
            Console.Write("Cantidad de aprobados:");
            Console.WriteLine(aprobados);
            Console.Write("Cantidad de reprobados:");
            Console.Write(reprobados);
            Console.ReadKey();
        }

        static void ciclodowhile1(){
             int valor;
            string linea;
            do {
                Console.Write("Ingrese un valor entre 0 y 999 (0 finaliza):");
                linea = Console.ReadLine();
                valor=int.Parse(linea);
                if (valor>=100) 
                {
                    Console.WriteLine("Tiene 3 dígitos.");
                } 
                else
                {
                    if (valor>=10) 
                    {
                        Console.WriteLine("Tiene 2 dígitos.");
                    } 
                    else 
                    {
                        Console.WriteLine("Tiene 1 dígito.");
                    }
                }
            } while (valor!=0);
        }

        static void ciclodowhile2(){
            int suma,cant,valor,promedio;
            string linea;
            suma=0;
            cant=0;
            do {
                Console.Write("Ingrese un valor (0 para finalizar):");
                linea = Console.ReadLine();
                valor=int.Parse(linea);
                if (valor!=0) {
                    suma=suma+valor;
                    cant++;
                }
            } while (valor!=0);
            if (cant!=0) {
                promedio=suma/cant;
                Console.Write("El promedio de los valores ingresados es:");
                Console.Write(promedio);
            } else {
                Console.Write("No se ingresaron valores.");
            }
            Console.ReadLine();
        }


        static void ciclodowhile3(){
            int cant1,cant2,cant3,suma;
            float peso;
            string linea;
            cant1=0;
            cant2=0;
            cant3=0;
            do {
                Console.Write("Ingrese el peso de la pieza (0 pera finalizar):");
                linea = Console.ReadLine();
                peso=float.Parse(linea);
                if (peso>10.2) 
                {
                    cant1++;
                }
                else 
                {
                    if (peso>=9.8)
                    {
                        cant2++;
                    }
                    else 
                    {
                        if (peso>0) 
                        {
                            cant3++;
                        }
                    }
                }
            } while(peso!=0);
            suma=cant1+cant2+cant3;
            Console.Write("Piezas aptas:");
            Console.WriteLine(cant2);
            Console.Write("Piezas con un peso superior a 10.2:");
            Console.WriteLine(cant1);
            Console.Write("Piezas con un peso inferior a 9.8:");
            Console.WriteLine(cant3);
            Console.ReadLine();
        }





        


       
    }
}
