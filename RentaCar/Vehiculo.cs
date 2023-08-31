using System;

public class Vehiculo
{


    //Prpiedades de la clase Vehiculo

    private string Placa; // Se encapsula el dato
    private string Marca;
    private string Modelo;
    private int Anio;
    private string TipoVehiculo;

    public Vehiculo()//Se crea un constructor
    {
        Placa1 = "KAN894";
        Marca1 = "CHEVROLET";
        Modelo1 = "OPTRA";
        Anio1 = 2010;
        TipoVehiculo1 = "Automovil";

    }

    public string Placa1 { get => Placa; set => Placa = value; }
    public string Marca1 { get => Marca; set => Marca = value; }
    public string Modelo1 { get => Modelo; set => Modelo = value; }
    public int Anio1 { get => Anio; set => Anio = value; }
    public string TipoVehiculo1 { get => TipoVehiculo; set => TipoVehiculo = value; }
}
 

