/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-xx-xx</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Veículo ou equipamento utilizado na obra com modelo, matrícula e custo horário.</summary>
    public class Vehicle : IDescribable, IReportable
    {
        private string _model = string.Empty;
        private string _plate = string.Empty;
        private decimal _costPerHour;

        #region GetSetters

        /// <summary>Função Get para o modelo do veículo.</summary>
        /// <returns>Nome do modelo.</returns>
        public string GetModel() => _model;

        /// <summary>Função Set para o modelo do veículo.</summary>
        /// <param name="value">Novo modelo. Se nulo, será convertido para string vazio.</param>
        public void SetModel(string value) => _model = value ?? string.Empty;

        /// <summary>Função Get para a descrição do veículo (modelo).</summary>
        /// <returns>Descrição/modelo do veículo.</returns>
        public string GetDescription() => _model;

        /// <summary>Função Set para a descrição do veículo.</summary>
        /// <param name="value">Nova descrição. Se nulo, será convertido para string vazio.</param>
        public void SetDescription(string value) => _model = value ?? string.Empty;

        /// <summary>Função Get para a matrícula do veículo.</summary>
        /// <returns>Matrícula única.</returns>
        public string GetPlate() => _plate;

        /// <summary>Função Set para a matrícula do veículo.</summary>
        /// <param name="value">Nova matrícula. Se nulo, será convertido para string vazio.</param>
        public void SetPlate(string value) => _plate = value ?? string.Empty;

        /// <summary>Função Get para o custo por hora de utilização.</summary>
        /// <returns>Valor em euros por hora.</returns>
        public decimal GetCostPerHour() => _costPerHour;

        /// <summary>Função Set para o custo por hora de utilização.</summary>
        /// <param name="value">Novo custo horário em euros.</param>
        public void SetCostPerHour(decimal value) => _costPerHour = value;

        #endregion

        /// <summary>Gera um relatório formatado com informações do veículo.</summary>
        /// <returns>String com formato: "Veículo: modelo (matrícula) - €custo/h".</returns>
        public string GetReport() => $"Veículo: {_model} ({_plate}) - €{_costPerHour}/h";

        /// <summary>Construtor da classe Vehicle.</summary>
        /// <param name="m">Modelo/tipo do veículo. Se nulo, será convertido para string vazio.</param>
        /// <param name="p">Matrícula do veículo. Se nulo, será convertido para string vazio.</param>
        /// <param name="c">Custo por hora de utilização em euros.</param>
        public Vehicle(string m, string p, decimal c)
        {
            _model = m ?? string.Empty;
            _plate = p ?? string.Empty;
            _costPerHour = c;
        }
    }
}
