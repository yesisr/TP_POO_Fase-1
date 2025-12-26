/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Orçamento da obra com data de criação, descrição e valor</summary>
    public class Budget : IDateable, IDescribable
    {
        private DateTime _date;
        private string _description = string.Empty;
        private decimal _budgetValue;

        #region GetSetters
        
        /// <summary>GetSet para a data de criação do orçamento</summary>
        /// <returns>Data do orçamento</returns>
        public DateTime Date
        {
            get => _date;
            set => _date = DateTime.Now; // Cria a data no instante em que foi criado
        }

        /// <summary>GetSet para a descrição do orçamento</summary>
        /// <returns>Nome do orçamento</returns>
        public String Description
        {
            get => _description;
            set => _description = value;
        }

        /// <summary>Função Get para o valor do orçamento</summary>
        /// <returns>Valor em euros</returns>
        public decimal BudgetValue
        {
            get => _budgetValue;
            set => _budgetValue = value;
        }

        #endregion

        /// <summary>Construtor da classe Budget</summary>
        /// <param name="n">Nome do orçamento</param>
        /// <param name="v">Valor do orçamento em euros</param>
        public Budget(string n, decimal v)
        {
            _description = n;
            _budgetValue = v;
        }
    }
}