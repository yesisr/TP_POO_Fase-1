/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Veículo ou equipamento utilizado na obra com modelo, matrícula e custo horário</summary>
    public class Vehicle : ICostable
    {
        private string _type;
        private string _model;
        private string _plate;
        private decimal _costPerHour;

        #region GetSetters


        /// <summary>GetSet para o tipo do veículo</summary>
        /// <returns>Tipo do veículo</returns>
        public string Type
        {
            get => _type;
            set => _type = value;
        }
        
        /// <summary>GetSet para o modelo do veículo</summary>
        /// <returns>Nome do modelo</returns>
        public string Model
        {
            get => _model;
            set => _model = value;
        }

        /// <summary>GetSet para a matrícula do veículo</summary>
        /// <returns>Matrícula única</returns>
        public string Plate
        {
            get => _plate;
            set => _plate = value;
        }

        /// <summary>GetSet para o custo por hora de utilização.</summary>
        /// <returns>Valor em euros por hora</returns>
        public decimal Cost
        {
            get => _costPerHour;
            set => _costPerHour = value;
        }


        #endregion

        /// <summary>Construtor da classe Vehicle</summary>
        /// <param name="t">Tipo do veículo</param>
        /// <param name="m">Modelo do veículo</param>
        /// <param name="p">Matrícula do veículo</param>
        /// <param name="c">Custo por hora de utilização em euros</param>
        public Vehicle(string t, string m, string p, decimal c)
        {
            _type = t;
            _model = m;
            _plate = p;
            _costPerHour = c;
        }
    }
}
