using System;

namespace TesteDATEtIMEConsoleApp1
{
    public class Montagem
    {
        private string EscreveAnos(Periodos periodo)
        {
           int valor = periodo.Anos();

            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));


                montagem = VerificaDezena(montagem, a, b, c);
                montagem = VerificaNecessidadeDoENaDezena(montagem, strValor, c);

                if (b != 1 && c == 1)
                    montagem += " ano";
                else
                    montagem += " anos";

                return montagem;
            }
        }

        private string VerificaNecessidadeDoENaDezena(string montagem, string strValor, int c)
        {
            if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " e ";


            if (strValor.Substring(1, 1) != "1")
                montagem = VerificaUnidade(montagem, c);

            return montagem;
        }

        private string VerificaDezena(string montagem, int a, int b, int c)
        {
            montagem = VerificaDe20a90(montagem, a, b, c);
            return montagem;
        }

        private string VerificaUnidade(string montagem, int c)
        {
            if (c == 1) montagem += "um";
            else if (c == 2) montagem += "dois";
            else if (c == 3) montagem += "três";
            else if (c == 4) montagem += "quatro";
            else if (c == 5) montagem += "cinco";
            else if (c == 6) montagem += "seis";
            else if (c == 7) montagem += "sete";
            else if (c == 8) montagem += "oito";
            else if (c == 9) montagem += "nove";
            return montagem;
        }

        private string VerificaDe10a19(string montagem, int a, int c)
        {
            if (c == 0) montagem += ((a > 0) ? " e " : string.Empty) + "dez";
            else if (c == 1) montagem +=  "onze";
            else if (c == 2) montagem += "doze";
            else if (c == 3) montagem += "treze";
            else if (c == 4) montagem += "quatorze";
            else if (c == 5) montagem += "quinze";
            else if (c == 6) montagem +=  "dezesseis";
            else if (c == 7) montagem +=  "dezessete";
            else if (c == 8) montagem +=  "dezoito";
            else if (c == 9) montagem += "dezenove";
            return montagem;
        }

        private string VerificaDe20a90(string montagem, int a, int b, int c)
        {
            if (b == 1)
            {
                montagem = VerificaDe10a19(montagem, a, c);
            }
            else if (b == 2) montagem += "vinte";
            else if (b == 3) montagem += "trinta";
            else if (b == 4) montagem += "quarenta";
            else if (b == 5) montagem += "cinquenta";
            else if (b == 6) montagem +=  "sessenta";
            else if (b == 7) montagem +=  "setenta";
            else if (b == 8) montagem += "oitenta";
            else if (b == 9) montagem += "noventa";
            return montagem;
        }

        private string EscreveMeses(Periodos periodo)
        {
            int valorMeses = periodo.Meses();

            if (valorMeses == 1)
                return " um mês";
            else if (valorMeses == 2)
                return " dois meses";
            else if (valorMeses == 3)
                return " três meses";
            else if (valorMeses == 4)
                return " quatro meses";
            else if (valorMeses == 5)
                return " cinco meses";
            else if (valorMeses == 6)
                return " seis meses";
            else if (valorMeses == 7)
                return " sete meses";
            else if (valorMeses == 8)
                return " oito meses";
            else if (valorMeses == 9)
                return " nove meses";
            else if (valorMeses == 10)
                return " dez meses";
            else if (valorMeses == 11)
                return " onze meses";
            return null;
        }

        private string EscreveSemanas(Periodos periodo)
        {
            int valorSemanas = periodo.Semanas();

            if (valorSemanas == 1)
                return " uma semana";
            else if (valorSemanas == 2)
                return " duas semanas";
            else if (valorSemanas == 3)
                return " três semanas";
            else if (valorSemanas == 4)
                return " quatro semanas";

            return null;
        }

        private string EscreveDias(Periodos periodo)
        {
            int valorDias = periodo.Dias();

            if (valorDias == 1)
                return " um dia";
            else if (valorDias == 2)
                return " dois dias";
            else if (valorDias == 3)
                return " três dias";
            else if (valorDias == 4)
                return " quatro dias";
            else if (valorDias == 5)
                return " cinco dias";
            else if (valorDias == 6)
                return " seis dias";
            return null;
        }

        public string ToExtensoDiasEHoras(Periodos periodo)
        {
            string escreve = "";

            if (periodo.total_dias >= 365)
                escreve += EscreveAnos(periodo);

            if (periodo.total_dias >= 30)
                escreve += VerificaNecessidadeDoENaEscrita(escreve) + EscreveMeses(periodo);

            if (periodo.total_dias >= 7)
                escreve += VerificaNecessidadeDoENaEscrita(escreve) + EscreveSemanas(periodo);

            if (periodo.total_dias < 7 && periodo.total_dias > 0)
                escreve += VerificaNecessidadeDoENaEscrita(escreve) + EscreveDias(periodo) ;

            else if(periodo.total_dias == 0)
            {
                if (periodo.total_horas > 1)            
                    escreve += periodo.total_horas + " horas ";
                if (periodo.total_minutos > 1)
                    escreve += periodo.total_minutos + " minutos ";
                if (periodo.total_segundos > 1)
                    escreve += periodo.total_segundos + " segundos ";
                if (periodo.total_horas == 1)
                    escreve += periodo.total_horas + " hora ";
                if (periodo.total_minutos == 1)
                    escreve += periodo.total_minutos + " minuto ";
                if (periodo.total_segundos == 1)
                    escreve += periodo.total_segundos + " segundo ";
            }
 
            escreve += " atrás";

            return escreve;
        }

        private string VerificaNecessidadeDoENaEscrita(string escreve)
        {
            string escreveE = "";

            if (escreve != "")
                escreveE = " e ";

            return escreveE;
        }

    }
}
