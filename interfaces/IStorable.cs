/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>
    /// Interface para itens que podem ser armazenados com quantidade
    /// Implementado por: StorageItem
    /// </summary>
    public interface IStorable
    {
        public int Quantity {get; set;}
    }
}