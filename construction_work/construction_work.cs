/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Obra de construção civil: agregador central de todas as classes da aplicação</summary>
    public class ConstructionWork : IDescribable, ICostable
    {
        private string _description = string.Empty;
        private string _address = string.Empty;
        private decimal _estimatedCost;
        private DateTime? _startDate;
        private DateTime? _endDate;


        #region GetSetters

        /// <summary>GetSet para a descrição(nome) da obra</summary>
        /// <returns>Descrição da obra</returns>
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        /// <summary>GetSet para a morada da obra</summary>
        /// <returns>Morada/localização</returns>
        public string Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>GetSet para o orçamento estimado</summary>
        /// <returns>Valor estimado em euros</returns>
        public decimal Cost
        {
            get => _estimatedCost;
            set => _estimatedCost = value;
        } 
        
        /// <summary>GetSet para a data de início</summary>
        /// <returns>Data de início</returns>
        public DateTime? StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        /// <summary>GetSet para a data de terminação</summary>
        /// <returns>Data de terminação</returns>
        public DateTime? EndDate
        {
            get => _endDate;
            set => _endDate = value;
        }


        #endregion


        #region Lists

        /// <summary>Lista de armazéns da obra</summary>
        private List<Storage> _storageList = new();

        /// <summary>Lista de mão de obra</summary>
        private List<Labor> _laborList = new();

        /// <summary>Lista de veículos disponíveis</summary>
        private List<Vehicle> _vehicleList = new();

        /// <summary>Lista de utilizações de veículos</summary>
        private List<VehicleUsage> _vehicleUsageList = new();

        /// <summary>Lista de orçamentos</summary>
        private List<Budget> _budgetList = new();


        #endregion


        /// <summary>Construtor da classe ConstructionWork</summary>
        /// <param name="n">Nome da obra</param>
        /// <param name="a">Endereço da obra</param>
        /// <param name="c">Orçamento estimado em euros</param>
        public ConstructionWork(string n, string a, decimal c)
        {
            _description = n;
            _address = a;
            _estimatedCost = c;
        }
    }
}