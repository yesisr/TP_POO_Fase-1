/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    public class VehicleUsage
    {
        private Vehicle _vehicle;
        private decimal _hours;

        #region GetSetters

        /// <summary>GetSet para o veículo utilizado</summary>
        /// <returns>Instância do veículo</returns>
        public Vehicle Vehicle
        {
            get => _vehicle;
            set => _vehicle = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>GetSet para as horas de utilização </summary>
        /// <param name="value"> Horas a utilizar. Será arredondado para cima.</param>
        public decimal Hours
        {
            get => _hours;
            set => _hours = Math.Ceiling(value);
        }

        #endregion


        /// <summary> Construtor da Classe VehicleUsage </summary>
        /// <param name="v">Veículo utilizado. Não pode ser nulo.</param>
        /// <param name="h">Horas de utilização (será arredondado para cima).</param>
        public VehicleUsage(Vehicle v, decimal h)
        {
            _vehicle = v;
            _hours = Math.Ceiling(h);
        }
    }
}