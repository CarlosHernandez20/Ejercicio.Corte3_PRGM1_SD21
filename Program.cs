using System;

namespace corte3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("¡Vamos a ayudarle a encontrar la porción de alimento seco adecuada para su perro!");

            int edad = 0;
            int actividad = 0;
            int opcion = 0;

            double peso = 0.00;

            string dato = "";

            
                Console.WriteLine("¿Desea continuar con el programa?");
                Console.WriteLine("1. Sí.   2. No");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
               

            while (opcion == 1)
            {
                Console.WriteLine("Por favor indica la edad de tu perro: ");
                Console.WriteLine("1. Cachorro.     2. Adulto.");
                dato = Console.ReadLine();
                edad = Convert.ToInt32(dato);

                switch (edad)
                {
                    case 1: 
                        Console.WriteLine("Por favor indica el peso de tu cachorro, en kilogramos: ");
                        dato = Console.ReadLine();
                        peso = Convert.ToDouble(dato);
                        if (peso < 25)
                            {
                                if (peso < 25 && peso < 17)
                                    {
                                        if (peso < 17 && peso < 10)
                                            {
                                                if (peso < 10 && peso < 5)
                                                    {
                                                        if (peso < 2)
                                                            {
                                                                Console.WriteLine("Debe llevar a su cachorro al veterinario para que lo orienten mejor.");
                                                            }else {Console.WriteLine("La porción de alimento seco de su cachorro debe ser de: 56gr");}
                                                    }else {Console.WriteLine("La porción de alimento seco de su cachorro debe ser de: 110gr - 148gr");}
                                            }else {Console.WriteLine("La porción de alimento seco de su cachorro debe ser de: 215gr - 280gr");}
                                    }else {Console.WriteLine("La porción de alimento seco de su cachorro debe ser de: 270gr - 370gr");}
                            }else {Console.WriteLine("Diríjase a la sección para adultos");}
                    break;

                    case 2:
                        Console.WriteLine("Por favor indique el nivel de actividad de su perro: ");
                        Console.WriteLine("1. Baja.     2. Normal.      3. Alta.");
                        dato = Console.ReadLine();
                        actividad = Convert.ToInt32(dato);

                        switch (actividad)
                            {
                                case 1: //Actividad BAJA//
                                    Console.WriteLine("Por favor introduce el peso de tu perro, en kilogramos:");
                                    dato = Console.ReadLine();
                                    peso = Convert.ToDouble(dato);

                                    if (peso < 2)
                                        {
                                            Console.WriteLine("Debes llevar al perro con un veterinario para recibir mejores orientaciones.");
                                        }else {
                                    if (peso > 2 && peso < 5)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 45gr - 85gr");
                                        }else {
                                    if (peso > 5 && peso < 10)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 86gr - 145gr");
                                        }else {
                                    if (peso > 10 && peso < 15)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 146gr - 195gr");
                                        }else {
                                    if (peso > 15 && peso < 25)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 196gr - 285gr");
                                        }else {
                                    if (peso > 25 && peso < 40)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 286gr - 410gr");
                                        }else {
                                    if (peso > 40 && peso < 55)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 411gr - 520gr");
                                        }else {
                                    if (peso > 55 && peso < 70)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 521gr - 620gr");
                                        }else {
                                    if (peso > 70 && peso < 90)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 621gr - 750gr");
                                        }else {Console.WriteLine("Debes llevar tu mascota al veterinario para mejores orientaciones.");}
                                        }   }   }   }   }   }   }   } //Por cada "else" añadí una llave de cierre en esta línea//
                                break;
                                case 2: //Actividad NORMAL//
                                    Console.WriteLine("Por favor introduce el peso de tu perro, en kilogramos:");
                                    dato = Console.ReadLine();
                                    peso = Convert.ToDouble(dato);

                                    if (peso < 2)
                                        {
                                            Console.WriteLine("Debes llevar al perro con un veterinario para recibir mejores orientaciones.");
                                        }else {
                                    if (peso > 2 && peso < 5)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 55gr - 100gr");
                                        }else {
                                    if (peso > 5 && peso < 10)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 101gr - 170gr");
                                        }else {
                                    if (peso > 10 && peso < 15)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 171gr - 225gr");
                                        }else {
                                    if (peso > 15 && peso < 25)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 226gr - 330gr");
                                        }else {
                                    if (peso > 25 && peso < 40)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 331gr - 475gr");
                                        }else {
                                    if (peso > 40 && peso < 55)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 476gr - 600gr");
                                        }else {
                                    if (peso > 55 && peso < 70)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 601gr - 720gr");
                                        }else {
                                    if (peso > 70 && peso < 90)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 721gr - 870gr");
                                        }else {Console.WriteLine("Debes llevar tu mascota al veterinario para mejores orientaciones.");}
                                        }   }   }   }   }   }   }   } //Se usa la misma estructura del caso anterior//
                                break;
                                case 3: //Actividad ALTA
                                    Console.WriteLine("Por favor introduce el peso de tu perro, en kilogramos:");
                                    dato = Console.ReadLine();
                                    peso = Convert.ToDouble(dato);

                                    if (peso < 2)
                                        {
                                            Console.WriteLine("Debes llevar al perro con un veterinario para recibir mejores orientaciones.");
                                        }else {
                                    if (peso > 2 && peso < 5)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 60gr - 115gr");
                                        }else {
                                    if (peso > 5 && peso < 10)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 116gr - 190gr");
                                        }else {
                                    if (peso > 10 && peso < 15)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 191gr - 255gr");
                                        }else {
                                    if (peso > 15 && peso < 25)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 256gr - 380gr");
                                        }else {
                                    if (peso > 25 && peso < 40)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 381gr - 535gr");
                                        }else {
                                    if (peso > 40 && peso < 55)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 536gr - 680gr");
                                        }else {
                                    if (peso > 55 && peso < 70)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 681gr - 820gr");
                                        }else {
                                    if (peso > 70 && peso < 90)
                                        {
                                            Console.WriteLine("La porción de tu mascota debe ser de: 821gr - 985gr");
                                        }else {Console.WriteLine("Debes llevar tu mascota al veterinario para mejores orientaciones.");}
                                        }   }   }   }   }   }   }   } //Se usa la misma estructura del caso anterior//
                                break;
                                default:
                                    Console.WriteLine("Selección inválida");
                                break;
                            }
                    break;
                    default:
                        Console.WriteLine("Selección inválida");
                    break;
                    
                }
                Console.WriteLine("¿Desea continuar con el programa?");
                Console.WriteLine("1. Sí.   2. No");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
            } 

            Console.WriteLine("Gracias");
            Console.WriteLine("Presiona cualquier tecla para continuar . . .");
            Console.ReadKey();
            
        }
    }
}
