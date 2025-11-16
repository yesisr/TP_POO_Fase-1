/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Orçamento da obra com nome, valor e data de criação.</summary>
    public class Budget : IDateable, IDescribable, ICostable, IReportable
    {
        private string _name = string.Empty;
        private decimal _budgetValue;
        private DateTime _date;

        #region GetSetters

        /// <summary>Função Get para a descrição (nome) do orçamento.</summary>
        /// <returns>Nome do orçamento.</returns>
        public string GetDescription() => _name;

        /// <summary>Função Set para a descrição (nome) do orçamento.</summary>
        /// <param name="value">Novo nome. Se nulo, será convertido para string vazio.</param>
        public void SetDescription(string value) => _name = value ?? string.Empty;

        /// <summary>Função Get para o nome do orçamento.</summary>
        /// <returns>Nome do orçamento.</returns>
        public string GetName() => _name;

        /// <summary>Função Set para o nome do orçamento.</summary>
        /// <param name="value">Novo nome. Se nulo, será convertido para string vazio.</param>
        public void SetName(string value) => _name = value ?? string.Empty;

        /// <summary>Função Get para o valor do orçamento.</summary>
        /// <returns>Valor em euros.</returns>
        public decimal GetBudgetValue() => _budgetValue;

        /// <summary>Função Set para o valor do orçamento.</summary>
        /// <param name="value">Novo valor em euros.</param>
        public void SetBudgetValue(decimal value) => _budgetValue = value;

        /// <summary>Função Get para o custo (valor do orçamento).</summary>
        /// <returns>Valor do orçamento em euros.</returns>
        public decimal GetCost() => _budgetValue;

        /// <summary>Função Get para a data de criação do orçamento.</summary>
        /// <returns>Data do orçamento.</returns>
        public DateTime GetDate() => _date;

        /// <summary>Função Set para a data de criação do orçamento.</summary>
        /// <param name="value">Nova data.</param>
        public void SetDate(DateTime value) => _date = value;

        #endregion

        /// <summary>Gera um relatório formatado do orçamento.</summary>
        /// <returns>String com formato: "Orçamento: nome - €valor (data)".</returns>
        public string GetReport() => $"Orçamento: {_name} - €{_budgetValue:F2} ({_date:dd/MM/yyyy})";

        /// <summary>Construtor da classe Budget.</summary>
        /// <param name="n">Nome do orçamento. Se nulo, será convertido para string vazio.</param>
        /// <param name="v">Valor do orçamento em euros.</param>
        /// <param name="d">Data de criação do orçamento.</param>
        public Budget(string n, decimal v, DateTime d)
        {
            _name = n ?? string.Empty;
            _budgetValue = v;
            _date = d;
        }
    }
}