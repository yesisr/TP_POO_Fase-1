/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Item de stock: combina Material com quantidade e calcula custo total</summary>
    public class StorageItem : IStorable
    {
        private Material _material;
        private int _quantity;


        #region GetSetters

        public Material Material
        {
            get => _material;
            set => _material = value;
        }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }


        #endregion


        /// <summary>Construtor da Classe StorageItem</summary>
        /// <param name="m">Material do item</param>
        /// <param name="q">Quantidade em unidades</param>
        public StorageItem(Material m, int q)
        {
            _material = m;
            _quantity = q;
        }
    }
}