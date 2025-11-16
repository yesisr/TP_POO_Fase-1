/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>
    /// Interface para itens com descrição/nome
    /// Implementado por: Material, Labor, Budget, Document
    /// </summary>
    public interface IDescribable
    {
        string GetDescription();
        void SetDescription(string description);
    }
}
