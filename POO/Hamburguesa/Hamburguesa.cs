namespace POO.Hamburguesa
{
    public class Hamburguesa
    {
        //Atributos

        public bool Pan { get; set; }
        public bool Carne { get; set; }
        public bool Lechuga { get; set; }
        public bool Pepinos { get; set; }
        public bool Queso { get; set; }
        public bool SalsaTomate { get; set; }
        public bool SalsaMostaza { get; set; }

        //Constructor

        public Hamburguesa(){
            Pan = true;
        }

        public Hamburguesa(bool carne, bool lechuga, bool pepino, bool queso, bool salsaTomate, bool salsaMostaza){
            Pan = true;
            Carne = carne;
            Lechuga = lechuga;
            Pepinos = pepino;
            Queso = queso;
            SalsaTomate = salsaTomate;
            SalsaMostaza = salsaMostaza;
        }
        //Metodos

        public void Pedido(){
            System.Console.WriteLine("Pan" + Pan);
            System.Console.WriteLine("Carne" + Carne);
            System.Console.WriteLine("Lechuga" + Lechuga);
            System.Console.WriteLine("Pepino" + Pepinos);
            System.Console.WriteLine("Queso" + Queso);
            System.Console.WriteLine("Salsa de tomate" + SalsaTomate);
            System.Console.WriteLine("Salsa de mostaza" + SalsaMostaza);
        }

        public static int descuento(int valorProducto, int valorDesc) { 
            int descuento = valorProducto - (valorProducto * (valorDesc / 100));
            return descuento;
        }

        public static void saludo(){
            System.Console.WriteLine("Hola");
        }
        
    }
}