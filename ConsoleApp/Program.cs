// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Hotel hotel = new Hotel();
hotel.Nombre = "Hotel 1"
hotel.Direccion = "calle2, transversal"

Habitacion habitacion1 = new Habitacion();
habitacion1.Tipo = "Doble"
habitacion1.disponible = true
habitacion1.precio = 12.50m;

Cliente cliente = new Cliente();
cliente.Nombre = "Laura hernandez"
cliente.Documento = "1092019201"

Reserva reserva = new Reserva ();
reserva.cliente

public class Habitacion{

    public int ID = 0;
    public String Tipo = "";
    public bool disponible;
    public decimal precio;
}

public class Cliente{

    public int ID = 0;
    public String? Nombre = "";
    public String Documento = "";
}

Public class Hotel {

    public int ID = 0;
    public String Nombre = "";
    public String Direccion = ""; 
    public List <Habitacion> habitaciones;
}

public class Reserva{

    public int ID = 0;
    public Cliente cliente;
    public Habitacion habitacion;
    public DateTime fecha_entrada = DateTime.Now;
}