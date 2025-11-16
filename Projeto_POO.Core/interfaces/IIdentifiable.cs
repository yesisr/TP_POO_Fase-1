/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>
    /// Interface para itens com identificador único
    /// Implementado por: Material, Document, Budget
    /// </summary>
    public interface IIdentifiable
    {
        int GetCode();
        void SetCode(int code);
    }
}
