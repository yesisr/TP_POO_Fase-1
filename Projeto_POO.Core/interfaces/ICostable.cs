/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>
    /// Interface para itens que possuem custo
    /// Implementado por: Service, Labor, VehicleUsage, StorageItem
    /// </summary>
    public interface ICostable
    {
        decimal GetCost();
    }
}
