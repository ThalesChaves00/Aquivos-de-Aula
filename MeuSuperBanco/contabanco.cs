using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MeuSuperBanco
{
    public class Contabanco
    {
        public string Numero { get; set; }
        public string Dono { get; set; }
        public decimal Saldo
        {
            get
            {
                decimal saldo = 10000;
                foreach (var item in todasTransacoes)
                {

                    saldo += item.Valor;
                }
                return saldo;
            }

        }

        public static int numeroConta = 123456789;

        private List <Transacao> todasTransacoes = new List <Transacao>();




        public Contabanco(string nome, decimal valor)
        {
            this.Dono = nome;
           

            numeroConta++;

            this.Numero = numeroConta.ToString();

        }
        public void Depositar( decimal valor,DateTime data,string obs)

        {
            if (valor<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor),"Nao aceitamos valor deposito de valor menor que 0");
            }

            Transacao trans = new Transacao(valor, data, obs);
            todasTransacoes.Add(trans);

        }
        public void Sacar(decimal valor, DateTime data, string obs)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Nao aceitamos valor saque de valor menor que 0");
            }
            if (Saldo - valor < 0)
            {
                throw new ArgumentOutOfRangeException( "Voce nao tem saldo");
            }
            Transacao trans = new Transacao(-valor, data, obs);
            todasTransacoes.Add(trans);
        
        }
        public string PegarMovimentacao()
        {
            var movimentacoes = new StringBuilder();
            movimentacoes.AppendLine("Data\t\t Valor\t\t Obs");

            foreach (var item in todasTransacoes)
            {

                movimentacoes.AppendLine($"{item.date.ToShortDateString()}\t {item.Valor}\t {item.Obs}");
            }
            return movimentacoes.ToString();


        }
    
    
    
    }
}

