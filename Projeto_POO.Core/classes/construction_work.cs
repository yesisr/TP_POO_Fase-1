/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Obra de construção civil: agregador central de todas as entidades da aplicação.</summary>
    public class ConstructionWork
    {
        private string _name = string.Empty;
        private string _address = string.Empty;
        private decimal _estimatedCost;
        private DateTime? _startDate;
        private DateTime? _endDate;

        #region GetSetters

        /// <summary>Função Get para o nome da obra.</summary>
        /// <returns>Nome da obra.</returns>
        public string GetName() => _name;

        /// <summary>Função Set para o nome da obra.</summary>
        /// <param name="value">Novo nome. Se nulo, será convertido para string vazio.</param>
        public void SetName(string value) => _name = value ?? string.Empty;

        /// <summary>Função Get para o endereço da obra.</summary>
        /// <returns>Endereço/localização.</returns>
        public string GetAddress() => _address;

        /// <summary>Função Set para o endereço da obra.</summary>
        /// <param name="value">Novo endereço. Se nulo, será convertido para string vazio.</param>
        public void SetAddress(string value) => _address = value ?? string.Empty;

        /// <summary>Função Get para o orçamento estimado.</summary>
        /// <returns>Valor estimado em euros.</returns>
        public decimal GetEstimatedCost() => _estimatedCost;

        /// <summary>Função Set para o orçamento estimado.</summary>
        /// <param name="value">Novo orçamento estimado em euros.</param>
        public void SetEstimatedCost(decimal value) => _estimatedCost = value;

        /// <summary>Função Get para a data de início.</summary>
        /// <returns>Data de início ou null se não definida.</returns>
        public DateTime? GetStartDate() => _startDate;

        /// <summary>Função Set para a data de início.</summary>
        /// <param name="value">Nova data de início.</param>
        public void SetStartDate(DateTime? value) => _startDate = value;

        /// <summary>Função Get para a data de término.</summary>
        /// <returns>Data de término ou null se não definida.</returns>
        public DateTime? GetEndDate() => _endDate;

        /// <summary>Função Set para a data de término.</summary>
        /// <param name="value">Nova data de término.</param>
        public void SetEndDate(DateTime? value) => _endDate = value;

        #endregion

        #region Lists

        /// <summary>Lista de armazéns da obra.</summary>
        public List<Storage> storageList { get; set; } = new();

        /// <summary>Lista de mão de obra.</summary>
        public List<Labor> laborList { get; set; } = new();

        /// <summary>Lista de veículos disponíveis.</summary>
        public List<Vehicle> vehicleList { get; set; } = new();

        /// <summary>Lista de utilizações de veículos.</summary>
        public List<VehicleUsage> vehicleUsageList { get; set; } = new();

        /// <summary>Lista de orçamentos.</summary>
        public List<Budget> budgetList { get; set; } = new();

        /// <summary>Lista de documentos da obra.</summary>
        public List<Document> documents { get; set; } = new();

        #endregion

        /// <summary>Construtor da classe ConstructionWork.</summary>
        /// <param name="n">Nome da obra. Se nulo, será convertido para string vazio.</param>
        /// <param name="a">Endereço da obra. Se nulo, será convertido para string vazio.</param>
        /// <param name="c">Orçamento estimado em euros.</param>
        public ConstructionWork(string n, string a, decimal c)
        {
            SetName(n);
            SetAddress(a);
            SetEstimatedCost(c);
        }

        //  métodos

        #region Storages

        /// <summary>Adiciona um novo armazém à obra.</summary>
        /// <param name="storage">Armazém a adicionar. Não pode ser nulo.</param>
        /// <exception cref="System.ArgumentNullException">Se o armazém for nulo.</exception>
        /// <exception cref="System.InvalidOperationException">Se um armazém com o mesmo nome já existe.</exception>
        public void addStorage(Storage storage)
        {
            if (storage == null) throw new System.ArgumentNullException(nameof(storage)); 
            if (storageList.Any(s => s.name == storage.name)) throw new System.InvalidOperationException($"Storage '{storage.name}' já existe.");
            // verifica se já existe
            storageList.Add(storage);
        }

        /// <summary>Obtém um armazém pelo seu nome.</summary>
        /// <param name="name">Nome do armazém.</param>
        /// <returns>Instância do Storage se encontrado, null caso contrário.</returns>
        public Storage? getStorage(string name)
        {
            return storageList.FirstOrDefault(s => s.name == name);
        }

        #endregion

        #region Stock

        /// <summary>Adiciona material a um armazém da obra.</summary>
        /// <param name="storageName">Nome do armazém de destino.</param>
        /// <param name="material">Material a adicionar. Não pode ser nulo.</param>
        /// <param name="quantity">Quantidade em unidades.</param>
        /// <exception cref="MaterialNotFoundException">Se o armazém não for encontrado.</exception>
        /// <exception cref="InvalidQuantityException">Se a quantidade for inválida.</exception>
        /// <exception cref="System.ArgumentNullException">Se o material for nulo.</exception>
        public void addMaterialToStorage(string storageName, Material material, int quantity)
        {
            Storage? storage = getStorage(storageName) ?? throw new MaterialNotFoundException($"Storage '{storageName}' não encontrado.");
            storage.addStock(material, quantity);
            // addStock lançará InvalidQuantityException ou ArgumentNullException se necessário
        }

        /// <summary>Remove material de um armazém da obra.</summary>
        /// <param name="storageName">Nome do armazém.</param>
        /// <param name="materialCode">Código do material a remover.</param>
        /// <param name="quantity">Quantidade a remover em unidades.</param>
        /// <returns>True se removido com sucesso.</returns>
        /// <exception cref="MaterialNotFoundException">Se o armazém não for encontrado.</exception>
        /// <exception cref="InsufficientStockException">Se não houver quantidade suficiente.</exception>
        public bool removeMaterialFromStorage(string storageName, int materialCode, int quantity)
        {
            Storage? storage = getStorage(storageName) ?? throw new MaterialNotFoundException($"Storage '{storageName}' não encontrado.");
            // removeStock lançará exceções se inválido
            storage.removeStock(materialCode, quantity);
            return true;
        }

        /// <summary>Obtém a quantidade total de um material em todos os armazéns.</summary>
        /// <param name="materialCode">Código do material.</param>
        /// <returns>Quantidade total em unidades.</returns>
        public int getStockQuantity(int materialCode)
        {
            return storageList.Sum(s => s.getQuantity(materialCode));
        }

        #endregion

        #region Vehicles

        /// <summary>Registra um novo veículo na obra.</summary>
        /// <param name="vehicle">Veículo a registar. Não pode ser nulo.</param>
        /// <exception cref="System.ArgumentNullException">Se o veículo for nulo.</exception>
        /// <exception cref="System.InvalidOperationException">Se um veículo com a mesma matrícula já existe.</exception>
        public void registerVehicle(Vehicle vehicle)
        {
            if (vehicle == null) throw new System.ArgumentNullException(nameof(vehicle));
            if (vehicleList.Any(v => v.GetPlate() == vehicle.GetPlate())) throw new System.InvalidOperationException($"Veículo com matrícula '{vehicle.GetPlate()}' já existe.");
            vehicleList.Add(vehicle);
        }

        /// <summary>Registra uma utilização de veículo na obra.</summary>
        /// <param name="plate">Matrícula do veículo a utilizar.</param>
        /// <param name="costHour">Custo por hora em euros.</param>
        /// <param name="hours">Número de horas de utilização.</param>
        /// <exception cref="System.InvalidOperationException">Se o veículo com a matrícula não for encontrado.</exception>
        /// <exception cref="InvalidQuantityException">Se as horas forem inválidas (≤ 0).</exception>
        public void addVehicleUsage(string plate, decimal costHour, decimal hours)
        {
            Vehicle? v = vehicleList.FirstOrDefault(v => v.GetPlate() == plate) ?? throw new System.InvalidOperationException($"Veículo '{plate}' não encontrado.");
            if (hours <= 0) throw new InvalidQuantityException("Horas devem ser maiores que zero.");
            vehicleUsageList.Add(new VehicleUsage(v, costHour, hours));
        }

        #endregion

        #region Services and Labor

        /// <summary>Adiciona um serviço subcontratado à obra.</summary>
        /// <param name="service">Serviço a adicionar. Não pode ser nulo.</param>
        /// <exception cref="System.ArgumentNullException">Se o serviço for nulo.</exception>
        public void addService(Service service)
        {
            if (service == null) throw new System.ArgumentNullException(nameof(service));
            serviceList.Add(service);
        }

        /// <summary>Adiciona mão de obra à obra.</summary>
        /// <param name="labor">Mão de obra a adicionar. Não pode ser nula.</param>
        /// <exception cref="System.ArgumentNullException">Se a mão de obra for nula.</exception>
        public void addLabor(Labor labor)
        {
            if (labor == null) throw new System.ArgumentNullException(nameof(labor));
            laborList.Add(labor);
        }

        #endregion 
 
        #region Budget and Documents

        /// <summary>Adiciona um orçamento à obra.</summary>
        /// <param name="budget">Orçamento a adicionar. Não pode ser nulo.</param>
        /// <exception cref="System.ArgumentNullException">Se o orçamento for nulo.</exception>
        public void addBudget(Budget budget)
        {
            if (budget == null) throw new System.ArgumentNullException(nameof(budget));
            budgetList.Add(budget);
        }

        /// <summary>Adiciona um documento à obra.</summary>
        /// <param name="doc">Documento a adicionar. Não pode ser nulo.</param>
        /// <exception cref="System.ArgumentNullException">Se o documento for nulo.</exception>
        public void AddDocument(Document doc)
        {
            if (doc == null) throw new System.ArgumentNullException(nameof(doc));
            documents.Add(doc);
        }

        #endregion

        #region Sum of Costs

        /// <summary>Calcula o custo total de materiais em todos os armazéns.</summary>
        /// <returns>Custo total em euros.</returns>
        public decimal totalCostMaterials()
        {
            return storageList.SelectMany(s => s.items).Sum(si => si.GetCost());
        }

        /// <summary>Calcula o custo total de serviços subcontratados.</summary>
        /// <returns>Custo total em euros.</returns>
        public decimal totalCostServices()
        {
            return serviceList.Sum(s => s.GetCost());
        }

        /// <summary>Calcula o custo total de mão de obra.</summary>
        /// <returns>Custo total em euros.</returns>
        public decimal totalCostLabor()
        {
            return laborList.Sum(l => l.GetCost());
        }

        /// <summary>Calcula o custo total de utilizações de veículos.</summary>
        /// <returns>Custo total em euros.</returns>
        public decimal totalCostVehicles()
        {
            return vehicleUsageList.Sum(v => v.GetCost());
        }

        /// <summary>Calcula o custo total da obra (soma de todos os custos).</summary>
        /// <returns>Custo total em euros.</returns>
        public decimal totalCost()
        {
            decimal totalCost = totalCostMaterials() + totalCostServices() + totalCostLabor() + totalCostVehicles();
            return totalCost;
        }

        /// <summary>Calcula a variação orçamental (estimado - realizado).</summary>
        /// <returns>Variação em euros (positivo = poupança, negativo = excesso).</returns>
        public decimal budgetVariation()
        {
            return GetEstimatedCost() - totalCost();
        }

        #endregion
    }
}