/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-xx-xx</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Item de stock: combina Material com quantidade e calcula custo total.</summary>
    public class StorageItem : IStorable, ICostable, IReportable
    {
        private Material _material;
        private int _quantity;

        #region GetSetters

        /// <summary>Função Get para o material armazenado.</summary>
        /// <returns>Instância do Material.</returns>
        public Material GetMaterial() => _material;

        /// <summary>Função Set para o material armazenado.</summary>
        /// <param name="value">Novo material. Não pode ser nulo.</param>
        /// <exception cref="System.ArgumentNullException">Se o valor for nulo.</exception>
        public void SetMaterial(Material value) => _material = value ?? throw new System.ArgumentNullException(nameof(value));

        /// <summary>Função Get para a quantidade em stock.</summary>
        /// <returns>Quantidade em unidades.</returns>
        public int GetQuantity() => _quantity;

        /// <summary>Função Set para a quantidade em stock.</summary>
        /// <param name="value">Nova quantidade.</param>
        public void SetQuantity(int value) => _quantity = value;
        
        /// <summary>Função Get para o custo total (quantidade × preço unitário).</summary>
        /// <returns>Custo total em euros.</returns>
        public decimal GetCost() => _material != null ? _material.GetPrice() * _quantity : 0m;

        #endregion

        /// <summary>Gera um relatório formatado do item de stock.</summary>
        /// <returns>String com formato: "descrição: quantidade unidades - €custo_total"</returns>
        public string GetReport() => $"{_material?.GetDescription() ?? "Desconhecido"}: {_quantity} unidades - €{GetCost():F2}";

        /// <summary>Construtor da Classe StorageItem.</summary>
        /// <param name="m">Material do item. Não pode ser nulo.</param>
        /// <param name="q">Quantidade inicial em unidades.</param>
        /// <exception cref="System.ArgumentNullException">Se o material for nulo.</exception>
        public StorageItem(Material m, int q)
        {
            _material = m ?? throw new System.ArgumentNullException(nameof(m));
            _quantity = q;
        }
    }
}