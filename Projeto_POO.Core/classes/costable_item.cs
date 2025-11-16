/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Classe abstrata para itens de custo (Serviço e Mão de Obra).</summary>
    public abstract class CostableItem : IDescribable, ICostable
    {
        private string _description;
        private decimal _cost;

        #region GetSetters

        /// <summary>Função Get para a descrição do item.</summary>
        /// <returns>String com a descrição.</returns>
        public string GetDescription() => _description;

        /// <summary>Função Set para a descrição do item.</summary>
        /// <param name="value">Nova descrição. Não pode ser nula.</param>
        /// <exception cref="System.ArgumentNullException">Se a descrição for nula.</exception>
        public void SetDescription(string value) => _description = value ?? throw new System.ArgumentNullException(nameof(value));

        /// <summary>Função Get para o custo do item.</summary>
        /// <returns>Valor do custo em euros.</returns>
        public decimal GetCost() => _cost;

        /// <summary>Função Set para o custo do item.</summary>
        /// <param name="value">Novo custo em euros.</param>
        public void SetCost(decimal value) => _cost = value;

        #endregion

        /// <summary>Construtor da classe CostableItem.</summary>
        /// <param name="desc">Descrição do item. Não pode ser nula.</param>
        /// <param name="cost">Custo do item em euros.</param>
        /// <exception cref="System.ArgumentNullException">Se a descrição for nula.</exception>
        public CostableItem(string desc, decimal cost)
        {
            _description = desc ?? throw new System.ArgumentNullException(nameof(desc));
            _cost = cost;
        }
    }
}
