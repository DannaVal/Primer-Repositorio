    public class Persona
    {   //Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Estatura { get; set; }
        public double Peso { get; set; }
        public int Salario { get; set; }

    public Persona(string nombre, string apellido, int edad, double estatura, double peso, int salario){
            Nombre = nombre;
            Apellido = apellido;   
            Edad = edad;
            Estatura = estatura;
            Peso = peso;
            Salario = salario;         
        }

        public Persona(){}


        //Metodos
        public void infoPersona(){
            System.Console.WriteLine("Nombre: " + Nombre);
            System.Console.WriteLine("Apellido: " + Apellido);
            System.Console.WriteLine("Edad: " + Edad);
            System.Console.WriteLine("Estatura: " + Estatura);
            System.Console.WriteLine("Peso: " + Peso);
            System.Console.WriteLine("Salario: " + Salario);
        }
        
        public double indiceMasaC()
        {
            double imc = Peso / (Estatura * Estatura);
            return imc;
        }

        public void alertaIMC(double imc)
        {
            if (imc < 18.5)
            {
                System.Console.WriteLine("Bajo peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                System.Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc <= 26.9)
            {
                System.Console.WriteLine("Sobrepeso I");
            }
            else if (imc >= 27 && imc <= 29.9)
            {
                System.Console.WriteLine("Sobrepeso II");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                System.Console.WriteLine("Obesidad I");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                System.Console.WriteLine("Obesidad II");
            }
            else if (imc >= 40 && imc <= 49.9)
            {
                System.Console.WriteLine("Obesidad III (morbida)");
            }
            else if (imc >=50){
                System.Console.WriteLine("Obesidad IV (extrema)");
            }

        }
        
    }




            



