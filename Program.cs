using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POO_EJERCICIOS_SEMANA_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO 1
            Bebida bebida1 = new Bebida("Coca-Cola", 101, 50);
            Alimento alimento1 = new Alimento("Pan", 202, 30);
            
            bebida1.ImprimirStock();
            alimento1.ImprimirStock();
            
            bebida1.VenderProducto(10);
            alimento1.VenderProducto(5);
           
            bebida1.ImprimirStock();
            alimento1.ImprimirStock();
            Console.ReadKey();*/

            /*EJERCICIO 2
            Triangulo triangulo = new Triangulo(5, 10);
            Cuadrado cuadrado = new Cuadrado(4);
            Circulo circulo = new Circulo(3);
            
            Console.WriteLine("Área del triángulo:");
            triangulo.MostrarArea();

            Console.WriteLine("\nÁrea del cuadrado:");
            cuadrado.MostrarArea();

            Console.WriteLine("\nÁrea del círculo:");
            circulo.MostrarArea();
            Console.ReadKey();*/

            //EJERCICIO 3
          /*  CuentaMayor cuentaMayor = new CuentaMayor(101, "Juan Pérez", 5000, "Activa", 17);
            CuentaMenor cuentaMenor = new CuentaMenor(102, "Ana López", 3000, "Activa");
            CuentaEstudiante cuentaEstudiante = new CuentaEstudiante(103, "Carlos García", 2000, "Activa", "Universidad XYZ");
            Console.WriteLine($"¿Es mayor de edad?: {cuentaMayor.EsMayor()}");
            Console.WriteLine("Información de Cuenta Mayor:");
            cuentaMayor.MostrarInformacion();

            cuentaMayor.ingresarMonto(1000);
            cuentaMayor.retirarMonto(600);
            Console.WriteLine("\nInformación de Cuenta Menor:");
            cuentaMenor.MostrarInformacion();
            cuentaMenor.ingresarMonto(500);
            cuentaMenor.retirarMonto(100);

            Console.WriteLine("\nInformación de Cuenta Estudiante:");
            cuentaEstudiante.MostrarInformacion();
            cuentaEstudiante.ingresarMonto(700);
            cuentaEstudiante.retirarMonto(300);
            Console.ReadKey();*/
            

            //EJERCICIO 4

            /*Programador Sambucetti = new Programador("Osvaldo", "Sambucetti", "1156458888", "sambucetti@uol.com", "20221887", 8550037, "Desarrollo", true, true, 13,
                "C#", "SuperSenior", 0);

            Sambucetti.MostrarInformacion();
            Console.ReadKey();  */

            //EJERCICIO 5
            /* Ambiente desarrollo = new Ambiente("Desarrollo", "Linux", 4, "PostgreSQL", "OpenJDK");
             Ambiente testing = new Ambiente("Testing", "Windows", 8, "MySQL", "Oracle JDK");
             Ambiente preproduccion = new Ambiente("Preproduccion", "Linux", 4, "PostgreSQL", "OpenJDK");
             Ambiente produccion = new Ambiente("Produccion", "Linux", 2, "PostgreSQL", "OpenJDK");

             desarrollo.VerificarDespliegue();
             testing.VerificarDespliegue();
             preproduccion.VerificarDespliegue();
             produccion.VerificarDespliegue();

             Console.ReadKey();*/

            //EJERCICIO 6

            /* Persona Ernesto = new Persona("Enersto", "Sabato", 99);
             Persona Jorge = new Persona("Jorge Luis", "Borges", 86);

             Jorge.CompararEdad(Ernesto.edad);
             Console.ReadKey();*/

            //EJERCICIO 7
          /*  Tren tren = new Tren();            
            tren.Acelerar(50);
            tren.Frenar();

            Vagon vagon = new Vagon(100); 
            vagon.AgregarPasajeros(50);
            vagon.VagonLleno();           
            vagon.AgregarPasajeros(60); 
            vagon.VagonLleno();

            Console.ReadKey();*/
        }
    }
    /* 1) El supermercado “Eureka” posee un problema al vender productos que no se descuentan del stock existente.Se requiere realizar 
     el modelado de las clases del stock de un supermercado, donde se detalle la clase Producto con sus dos clases hijas: Bebida y Alimento, 
    que posean un método que haga referencia a la venta de un producto y descuente la cantidad vendida del stock existente.*/

    /* public class Producto
     {
         public string nombre;
         public int codigo;
         public int stock;

         public Producto(string nom, int cod, int st)
         {
             nombre = nom;
             codigo = cod;
             stock = st;
         }

         public void VenderProducto(int cantidad)
         {
             if (cantidad > 0 && cantidad <= stock)
             {
                 stock -= cantidad;
                 Console.WriteLine($"Se han vendido {cantidad} unidades de {nombre}. Stock restante: {stock}");
             }
             else
             {
                 Console.WriteLine($"No se puede vender {cantidad} unidades de {nombre}. Stock disponible: {stock}");
             }
         }
         public void ImprimirStock()
         {
             Console.WriteLine($"Producto: {nombre}, Código: {codigo}, Stock disponible: {stock}");
         }
     }
     public class Bebida : Producto
     {
         public Bebida(string nom, int cod, int st) : base(nom, cod, st)
         {
         }
     }


     public class Alimento:Producto
     {
         public Alimento(string nom, int cod, int st) : base(nom, cod, st)
         {
         }

     }
    */
    /*  2) Se requiere un programa que nos ayude a calcular el área de un Triángulo, de un Cuadrado y de un Círculo 
      y que éstas clases dependan de la clase Figura, la cual debe tener un método que sea mostrarArea, 
      donde debe consulte el valor de la variable área y si no es nulo, mostrar por consola el valor.*/
    /*
    public class Figura
    {
        protected double area;

        public void MostrarArea()
        {
            if (area > 0)
            {
                Console.WriteLine($"El área calculada es: {area}");
            }
            else
            {
                Console.WriteLine("El área aún no ha sido calculada.");
            }
        }
    }    
    public class Triangulo : Figura
    {
        public double Base;
        public double Altura;

        public Triangulo(double baseT, double altura)
        {
            Base = baseT;
            Altura = altura;
            CalcularArea();
        }


        public void CalcularArea()
        {
            area = (Base * Altura) / 2;
        }
    }

    public class Cuadrado : Figura
    {
        public double Lado;

        public Cuadrado(double lado)
        {
            Lado = lado;
            CalcularArea();
        }

        public void CalcularArea()
        {
            area = Lado * Lado;
        }
    }

    public class Circulo : Figura
    {
        public double Radio;

        public Circulo(double radio)
        {
            Radio = radio;
            CalcularArea();
        }

        public void CalcularArea()
        {
            area = 3.1416 * (Radio * Radio);
        }
    }*/

    /*EJERCICIO 3 Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int_montoASumar),
     * retirarMonto(int_montoARestar) mostrar información de la cuenta (nro_cuenta,  nombre, saldo, estado_cuenta) 
     * de la cuenta y definir las clases CuentaMayor, CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos. 
     * En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.*/

    /* public class Cuenta
     {
         public int nro_cuenta;
         public string nombre;
         public double saldo;
         public string estado_cuenta;


         public Cuenta(int numero_cuenta, string nom, double sal, string estado)
         {
             nro_cuenta = numero_cuenta;
             nombre = nom;
             saldo = sal;
             estado_cuenta = estado;

         }

         public void ingresarMonto(int montoASumar)
         {
             saldo += montoASumar;

         }
         public void retirarMonto(int montoARestar)
         {
             saldo -= montoARestar;

         }

         public void MostrarInformacion()
         {
             Console.WriteLine($"Número de Cuenta: {nro_cuenta}");
             Console.WriteLine($"Titular: {nombre}");
             Console.WriteLine($"Saldo: ${saldo}");
             Console.WriteLine($"Estado de la Cuenta: {estado_cuenta}");
         }

     }

    public class CuentaMayor : Cuenta
    {
     public int Edad;

     public CuentaMayor(int numero_cuenta, string nom, double sal, string estado, int edad) : base(numero_cuenta, nom, sal, estado)
     {
         Edad = edad; 
     }

     public string EsMayor()
     {

            return Edad >= 18 ? "Si" :"No";
            
        } 
    }
    public class CuentaMenor : Cuenta
     {
         public CuentaMenor(int numeroCuenta, string nombreTitular, double saldo, string estadoCuenta)
             : base(numeroCuenta, nombreTitular, saldo, estadoCuenta)
         {
         }
     }


     public class CuentaEstudiante : Cuenta
     {
         public string InstitucionEducativa;

         public CuentaEstudiante(int numeroCuenta, string nombreTitular, double saldo, string estadoCuenta, string institucionEducativa)
             : base(numeroCuenta, nombreTitular, saldo, estadoCuenta)
         {
             InstitucionEducativa = institucionEducativa;
         }
     }*/

    /*EJERCICIO 4: Definir la clase Empleado, con nombre, apellido, teléfono, email, dni y sueldo.
    Definir la clase DptoSistemas (para el Departamento de Sistemas) que posea el área en la que trabaja de Sistemas, si posee título relacionado a su trabajo, 
    si posee una computadora laboral a su cargo y cantidad de gente a cargo. Definir la clase Programador donde se almacene en que lenguaje de programación trabaja,
    si es senior, semisenior o junior y la cantidad de veces que tumbó producción.
    Crear un método para mostrar información del empleado en la clase Programador donde muestre toda la información requerida.  */
    /*
       public class Empleado
       {
           public string nombre;
           public string apellido;
           public string telefono;
           public string email;
           public string dni;
           public double sueldo;


           public Empleado(string nom, string ape, string tel, string mail, string Documento, double sue)
           {
               nombre = nom;
               apellido = ape;
               telefono = tel;
               email = mail;
               dni = Documento;
               sueldo = sue;
           }
       }

       public class DptoSistenas : Empleado
       {
           public string AreaDeTrabajo;
           public bool TieneTitulo;
           public bool Computadora;
           public int Personas;


           public DptoSistenas(string nom, string ape, string tel, string mail, string Documento, double sue,string area, bool titulo, bool compu, int pipol):
               base(nom,ape,tel,mail,Documento,sue)
           {

               AreaDeTrabajo = area;
               TieneTitulo = titulo;
               Computadora = compu;
               Personas = pipol;

           }
       }

       public class Programador: DptoSistenas
       {
           public string Lenguaje;
           public string Señority;
           public int Tumbo;


           public Programador(string nom, string ape, string tel, string mail, string Documento, double sue, string area, bool titulo, bool compu, int pipol,string parla, string nivel, int macana)
               :base(nom, ape,tel, mail, Documento, sue, area,  titulo,  compu, pipol)
           {
               Lenguaje = parla;
               Señority = nivel;
               Tumbo = macana;


           }

           public void MostrarInformacion()
           {
               Console.WriteLine("===== Información del Empleado Programador =====");
               Console.WriteLine($"Nombre: {nombre} {apellido}");
               Console.WriteLine($"Teléfono: {telefono}");
               Console.WriteLine($"Email: {email}");
               Console.WriteLine($"DNI: {dni}");
               Console.WriteLine($"Sueldo: ${sueldo}");
               Console.WriteLine($"Área de Trabajo: {AreaDeTrabajo}");            
               Console.WriteLine($"Posee Título Relacionado: {(TieneTitulo  ? "Sí" : "No")}");
               Console.WriteLine($"Posee Computadora Laboral: {(Computadora ? "Sí" : "No")}");
               Console.WriteLine($"Cantidad de Gente a Cargo: {Personas}");
               Console.WriteLine($"Lenguaje de Programación: {Lenguaje}");
               Console.WriteLine($"Nivel: {Señority}");
               Console.WriteLine($"Veces que tumbó producción: {Tumbo}");
           }
       }*/

    /*EJERCICIO 5:Definir la clase Ambiente y generar los objetos: “Desarrollo”, “Testing”, “Preproduccion” y“Produccion” que posea un método 
     que sea verificarDespliegue y comprobar que la información del Ambiente sea igual a: “sistema_operativo: linux, ram:4, base_datos: postgresql, 
    app: openjdk”, si es correcto mostrar por pantalla que el despliegue se puede realizar, de lo contrario, mostrar que no será posible realizar el despliegue.*/

    /*  public class Ambiente
      {
          public string Nombre;
          public string SistemaOperativo;
          public int Ram;
          public string BaseDatos;
          public string Aplicacion;

          public Ambiente(string nombre, string sistemaOperativo, int ram, string baseDatos, string aplicacion)
          {
              Nombre = nombre;
              SistemaOperativo = sistemaOperativo;
              Ram = ram;
              BaseDatos = baseDatos;
              Aplicacion = aplicacion;
          }

          public void VerificarDespliegue()
          {
              if (SistemaOperativo.ToLower() == "linux" && Ram == 4 && BaseDatos.ToLower() == "postgresql" && Aplicacion.ToLower() == "openjdk")
              {
                  Console.WriteLine($"El despliegue en el ambiente \"{Nombre}\" se puede realizar correctamente.");
              }
              else
              {
                  Console.WriteLine($"El despliegue en el ambiente \"{Nombre}\" NO es posible debido a una configuración incorrecta.");
              }
          }
      }
      */
    //EJERCICIO 6: Crear la clase Persona, con un método que compare la edad de una persona con otra.
    //(Se deben crear dos objetos de la clase persona, y ejecutar el método compararEdad en persona2,
    //pasando como parámetro la edad de persona1).


    /* public class Persona
     {
         public string nombre;
         public string apellido;
         public  int edad;

         public Persona(string Nombre, string Apellido, int Edad)
         {
             nombre = Nombre;
             apellido = Apellido;
             edad = Edad;
         }

         public void CompararEdad(int edadOtraPersona)
         {
             if (edad > edadOtraPersona)
             {
                 Console.WriteLine($"{nombre}  {apellido} es mayor que la otra persona.");
             }
             else if (edad < edadOtraPersona)
             {
                 Console.WriteLine($"{nombre}   {apellido} es menor que la otra persona.");
             }
             else
             {
                 Console.WriteLine($"{nombre}   {apellido} y la otra persona tienen la misma edad.");
             }
         }       

     }*/

    // EJERCICIO 7:Definir la clase Tren y su hija, Vagón. Se deben crear los métodos vagon Lleno,acelerar(int velocidad) y frenar

   /* public class Tren
    {
        public int VelocidadActual;

        public Tren()
        {
            VelocidadActual = 0; 
        }        
        public void Acelerar(int velocidad)
        {
            if (velocidad > 0)
            {
                VelocidadActual += velocidad;
                Console.WriteLine($"El tren ha acelerado. Velocidad actual: {VelocidadActual} km/h.");
            }
            
        }
        public void Frenar()
        {
            if (VelocidadActual > 0)
            {
                VelocidadActual = 0;
                Console.WriteLine("El tren ha frenado. Velocidad actual: 0 km/h.");
            }
            
        }
    }
    public class Vagon : Tren
    {
        
        public int CapacidadMaxima;
        public int PasajerosActuales;

       
        public Vagon(int capacidadMaxima)
        {
            CapacidadMaxima = capacidadMaxima;
            PasajerosActuales = 0; 
        }

       
        public bool VagonLleno()
        {
            if (PasajerosActuales >= CapacidadMaxima)
            {
                Console.WriteLine("El vagón está lleno.");
                return true;
            }
            else
            {
                Console.WriteLine("El vagón aún tiene espacio disponible.");
                return false;
            }
        }

        public void AgregarPasajeros(int cantidad)
        {
            if (PasajerosActuales + cantidad <= CapacidadMaxima)
            {
                PasajerosActuales += cantidad;
                Console.WriteLine($"Se han agregado {cantidad} pasajeros. Pasajeros actuales: {PasajerosActuales}/{CapacidadMaxima}.");
            }
            else
            {
                Console.WriteLine($"No se pueden agregar {cantidad} pasajeros. El vagón excedería su capacidad máxima.");
            }
        }
    }*/
}








