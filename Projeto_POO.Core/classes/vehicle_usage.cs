using System;

namespace Projeto_POO
{
    public class VehicleUsage : ICostable, IReportable
    {
        private Vehicle _vehicle;
        private decimal _hours;

        #region GetSetters

        /// <summary> Função Get para o veículo utilizado. </summary>
        /// <returns> Instância do Vehicle. </returns>
        public Vehicle GetVehicle() => _vehicle;

        /// <summary> Função Set para o veículo utilizado </summary>
        /// <param name="value"> Novo veículo. Não pode ser nulo. </param>
        public void SetVehicle(Vehicle value) => _vehicle = value ?? throw new ArgumentNullException(nameof(value));

        /// <summary> Função Get para as horas de utilização </summary>
        /// <returns> Número de horas </returns>
        public decimal GetHours() => _hours;

        /// <summary> Função Set para as horas de utilização </summary>
        /// <param name="value"> Horas a utilizar. Será arredondado para cima. </param>
        public void SetHours(decimal value) => _hours = Math.Ceiling(value);

        /// <summary> Função Get para o custo total do uso do veículo </summary>
        /// <returns> Custo em euros (horas × custo por hora). </returns>
        public decimal GetCost() => _vehicle != null ? _hours * _vehicle.GetCostPerHour() : 0m;

        #endregion

        /// <summary> Gera um relatório formatado com informações do uso. </summary>
        /// <returns> String com formato: "Uso de modelo: Xh - €custo_total" </returns>
        public string GetReport() => $"Uso de {_vehicle?.GetModel()}: {_hours}h - €{GetCost():F2}";

        /// <summary> Construtor da Classe VehicleUsage </summary>
        /// <param name="v">Veículo utilizado. Não pode ser nulo.</param>
        /// <param name="h">Horas de utilização (será arredondado para cima).</param>
        /// <param name="c">Parâmetro ignorado (o custo é calculado automaticamente).</param>
        public VehicleUsage(Vehicle v, decimal h, decimal c)
        {
            _vehicle = v ?? throw new ArgumentNullException(nameof(v));
            _hours = Math.Ceiling(h);
        }
    }
}