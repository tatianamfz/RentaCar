using System;

namespace RentaCar
{ class Program
    {
        // See https://aka.ms/new-console-template for more information

        static void Main(string[] args)
        {
            
            Vehiculo objVehiculo = new Vehiculo(); //Se instancia la clase vehiculo

            Console.WriteLine("PLACA: "+objVehiculo.Placa1);// Se Imprime el dato por medio de la encapsulacion
            Console.WriteLine("MARCA: "+objVehiculo.Marca1);
            Console.WriteLine("MODELO: "+objVehiculo.Modelo1);
            Console.WriteLine("MODELO AÑO: "+objVehiculo.Anio1);
            Console.WriteLine("TIPO DE VEHICULO:"+objVehiculo.TipoVehiculo1);
            Console.WriteLine();

            Usuario objUsuario = new Usuario();

            Console.WriteLine(objUsuario.TipoId1 +" " + objUsuario.Id1);
            Console.WriteLine(objUsuario.Nombre1 +" "+ objUsuario.Apellido1);
            Console.WriteLine("N° Celular:" +objUsuario.Celular1);
            Console.WriteLine("Correo: " +objUsuario.Correo1);
            Console.WriteLine("Tipo de Usuario: "+objUsuario.TipoUsuario1);

            Console.WriteLine();

            Alquiler objAlquiler = new Alquiler();

            Console.WriteLine("Fecha Inicio Alquiler: "+ objAlquiler.FechaInicio1);
            Console.WriteLine("Fecha Fin Alquiler: " + objAlquiler.FechaFin1);
            Console.WriteLine("Valor Total: " + objAlquiler.ValorTotal1);


        }
        

    }




}



