namespace POO.Hamburguesa
{
    public class Program
    {
        Hamburguesa h1 = new Hamburguesa();

        System.Console.WriteLine("Carne");
        bool carne = bool.Parse(Console.ReadLine());
        System.Console.WriteLine("Lechuga");
        bool lechuga = bool.Parse(Console.ReadLine());
        System.Console.WriteLine("Pepino");
        bool pepino = bool.Parse(Console.ReadLine());
        System.Console.WriteLine("Queso");
        bool queso = bool.Parse(Console.ReadLine());
        System.Console.WriteLine("Salsa de tomate");
        bool salsaTomate = bool.Parse(Console.ReadLine());
        System.Console.WriteLine("Salsa de mostaza");
        bool salsaMostaza = bool.Parse(Console.ReadLine());

        h1.Carne = carne;
        h1.Lechuga = lechuga;
        h1.Pepinos = pepino;
        h1.Queso = queso;
        h1.SalsaTomate = salsaTomate;
        h1.SalsaMostaza = salsaMostaza;

        h1.Pedido();

        Hamburguesa h2 = new Hamburguesa(carne, lechuga, pepino, queso, salsaTomate, salsaMostaza);

        h2.Pedido();

        Hamburguesa.descuento(15000, 5);

        Hamburguesa.saludo();
    }
}