/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Mão de obra subcontratada ou própria (herda de CostableItem).</summary>
    public class Labor : CostableItem
    {
        private bool _subcontracted;

        #region GetSetters

        /// <summary>Função Get para a flag de subcontratação.</summary>
        /// <returns>True se for subcontratada, false se for própria.</returns>
        public bool GetSubcontracted() => _subcontracted;

        /// <summary>Função Set para a flag de subcontratação.</summary>
        /// <param name="value">True para subcontratada, false para própria.</param>
        public void SetSubcontracted(bool value) => _subcontracted = value;

        #endregion

        /// <summary>Construtor da classe Labor.</summary>
        /// <param name="description">Descrição do trabalho. Não pode ser nula.</param>
        /// <param name="cost">Custo da mão de obra em euros.</param>
        /// <param name="subcontracted">Flag indicando se é subcontratada.</param>
        /// <exception cref="System.ArgumentNullException">Se a descrição for nula.</exception>
        public Labor(string description, decimal cost, bool subcontracted) : base(description, cost)
        {
            _subcontracted = subcontracted;
        }
    }
}