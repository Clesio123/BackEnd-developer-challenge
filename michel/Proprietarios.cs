using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clesio
{
    class Proprietarios
    {
        String nome;
        String numBI;
        String numCarta;
        DateTime datadeNascimento;
        //Boolean Sexo;

        //Dados do veiculo
        String matricula, modelo;
        String numdoguia, numdeverbete;
        int tipodeCombustivel, tipodeveiculo;
        DateTime DatadeFabrico, DatadeImportacao;

        public Proprietarios()
        {
        }


        




        public string Nome { get => nome; set => nome = value; }
        public string NumBI { get => numBI; set => numBI = value; }
        public string NumCarta { get => numCarta; set => numCarta = value; }
        public DateTime DatadeNascimento { get => datadeNascimento; set => datadeNascimento = value; }
        // public bool Sexo1 { get => Sexo; set => Sexo = value; }



        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int TipodeCombustivel { get => tipodeCombustivel; set => tipodeCombustivel = value; }
        public int Tipodeveiculo { get => tipodeveiculo; set => tipodeveiculo = value; }
        public string Numdoguia { get => numdoguia; set => numdoguia = value; }
        public string Numdeverbete { get => numdeverbete; set => numdeverbete = value; }
        public DateTime DatadeFabrico1 { get => DatadeFabrico; set => DatadeFabrico = value; }
        public DateTime DatadeImportacao1 { get => DatadeImportacao; set => DatadeImportacao = value; }



    }
}
