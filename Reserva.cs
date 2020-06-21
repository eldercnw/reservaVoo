
using System;


    class Reserva
    {
        public Cliente Cliente { get; set; }
        public Voo Voo { get; set; }
        public Compra Compra { get; set; }
        private static int TotalReservas = 0;

        public static int EnviarTotalReservas()
        {
            return TotalReservas;
        }
        
        public static void CancelarReserva()
        {

        }
    }

