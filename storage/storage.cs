/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>
namespace Projeto_POO
{
    /// <summary>Armazém que gerencia um conjunto de StorageItems (materiais com quantidade)</summary>
    public class Storage : IDescribable
    {
        private string _description = string.Empty;
        private List<StorageItem> _items;


        #region GetSetters

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public IReadOnlyList<StorageItem> Items  {
            get => _items.AsReadOnly();
            // set não é necessário
        }


        #endregion


        /// <summary>Construtor da Classe Storage</summary>
        /// <param name="d">Nome do armazém</param>
        public Storage(string d)
        {
            _description = d;
            _items = new List<StorageItem>();
        }
    }
}