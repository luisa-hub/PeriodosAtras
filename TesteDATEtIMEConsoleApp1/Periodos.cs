using System;

namespace TesteDATEtIMEConsoleApp1
{
    public class Periodos
    {
        public DateTime data_inicial = new DateTime(2021, 05, 26, 16, 06, 10);
        public DateTime data_comparar;
        public TimeSpan diferenca_datas;
        public int total_dias;
        public int total_horas;
        public int total_minutos;
        public int total_segundos;

        public Periodos(int ano, int mes, int dia, int hora, int minuto, int segundo)
        {

            this.data_comparar = new DateTime(ano, mes, dia, hora, minuto, segundo);
            diferenca_datas = data_inicial.Subtract(data_comparar);
            total_dias = diferenca_datas.Days;
            total_horas = diferenca_datas.Hours;
            total_minutos = diferenca_datas.Minutes;
        }



        public int Anos()
        {
            int anos = total_dias / 365;
            total_dias = total_dias % 365;
            return anos;

        }

        public int Meses()
        {
            int meses = total_dias / 30;
            total_dias = total_dias % 30;
            return meses;

        }

        public int Semanas()
        {
            int semanas = total_dias / 7;
            total_dias = total_dias % 7;
            return semanas;

        }

        public int Dias()
        {
            int dias = total_dias ;
            return dias;
        }
    }
}
