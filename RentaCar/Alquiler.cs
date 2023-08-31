using System;

public class Alquiler
{



    private DateTime FechaInicio;
    private DateTime FechaFin;
    private Double ValorTotal;

    public DateTime FechaInicio1 { get => FechaInicio; set => FechaInicio = value; }
    public DateTime FechaFin1 { get => FechaFin; set => FechaFin = value; }
    public double ValorTotal1 { get => ValorTotal; set => ValorTotal = value; }

    //TODO: terminar de crear la clase alquiler y la clase de informe, incluir la herencia y el polimorfismo

    public Alquiler() {

        FechaInicio = new(01/08/2023);
        FechaFin = new(31/08/2023);
        ValorTotal = 2000000;
    }


}

