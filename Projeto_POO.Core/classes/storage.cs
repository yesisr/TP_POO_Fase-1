using System;
using System.Collections.Generic;

/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-xx-xx</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Armazém que gerencia um conjunto de StorageItems (materiais com quantidade).</summary>
    public class Storage
    {
        private string _name = string.Empty;

        /// <summary>Lista de itens de stock no armazém.</summary>
        public List<StorageItem> items;

        #region GetSetters

        /// <summary>Função Get para o nome do armazém.</summary>
        /// <returns>Nome do armazém.</returns>
        public string GetName() => _name;

        /// <summary>Função Set para o nome do armazém.</summary>
        /// <param name="value">Nova nome do armazém.</param>
        public string SetName(string value) => _name = value;

        #endregion

        /// <summary>Construtor da Classe Storage.</summary>
        /// <param name="n">Nome do armazém.</param>
        /// <param name="i">Lista inicial de StorageItems. Se nulo, inicializa com lista vazia.</param>
        public Storage(string n, List<StorageItem> i)
        {
            _name = n ?? string.Empty;
            items = i ?? new List<StorageItem>();
        }

        /// <summary>Adiciona quantidade de um material ao armazém. Se existir, incrementa; senão, cria novo item.</summary>
        /// <param name="m">Material a adicionar. Não pode ser nulo.</param>
        /// <param name="q">Quantidade a adicionar. Deve ser maior que zero.</param>
        /// <exception cref="ArgumentNullException">Se o material for nulo.</exception>
        /// <exception cref="InvalidQuantityException">Se a quantidade for menor ou igual a zero.</exception>
        public void addStock(Material m, int q)
        {
            if (m == null) throw new ArgumentNullException(nameof(m));
            if (q <= 0) throw new InvalidQuantityException("Quantidade deve ser maior que zero.");

            var existing = items.Find(i => i.GetMaterial().GetCode() == m.GetCode());
            if (existing != null)
            {
                existing.SetQuantity(existing.GetQuantity() + q);
            }
            else
            {
                items.Add(new StorageItem(m, q));
            }
        }

        /// <summary>Remove quantidade de um material do armazém.</summary>
        /// <param name="materialCode">Código do material a remover.</param>
        /// <param name="q">Quantidade a remover. Deve ser maior que zero.</param>
        /// <exception cref="InvalidQuantityException">Se a quantidade for menor ou igual a zero.</exception>
        /// <exception cref="MaterialNotFoundException">Se o material não existe no armazém.</exception>
        /// <exception cref="InsufficientStockException">Se o stock disponível é menor que o solicitado.</exception>
        public void removeStock(int materialCode, int q)
        {
            if (q <= 0) throw new InvalidQuantityException("Quantidade deve ser maior que zero.");

            var existing = items.Find(i => i.GetMaterial().GetCode() == materialCode);
            if (existing == null) throw new MaterialNotFoundException($"Material com código {materialCode} não encontrado no storage '{_name}'.");
            if (existing.GetQuantity() < q) throw new InsufficientStockException($"Stock insuficiente para o material {materialCode}. Disponível: {existing.GetQuantity()}, pedido: {q}.");

            existing.SetQuantity(existing.GetQuantity() - q);
            if (existing.GetQuantity() == 0) items.Remove(existing);
        }

        /// <summary>Obtém a quantidade total de um material pelo código.</summary>
        /// <param name="materialCode">Código do material.</param>
        /// <returns>Quantidade disponível. Retorna 0 se o material não existe.</returns>
        public int getQuantity(int materialCode)
        {
            var existing = items.Find(i => i.GetMaterial().GetCode() == materialCode);
            return existing?.GetQuantity() ?? 0;
        }
    }
}