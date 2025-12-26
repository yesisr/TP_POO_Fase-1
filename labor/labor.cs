/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Mão de obra subcontratada ou própria, com descrição e custo</summary>
    public class Labor : IDescribable, ICostable
    {
        private bool _subcontracted;
        private string _description;
        private decimal _cost;

        
        #region GetSetters

        /// <summary>GetSet para a flag de subcontratação</summary>
        /// <returns>True se for subcontratada, false se for própria</returns>
        public bool Subcontracted
        {
            get => _subcontracted;
            set => _subcontracted = value;
        }

        /// <summary>GetSet para a descrição do trabalho</summary>
        /// <returns>Retorna a descrição do trabalho</returns>
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        /// <summary>GetSet para o custo da mão de obra em euros</summary>
        /// <returns>Retorna o custo</returns>
        public decimal Cost
        {
            get => _cost;
            set => _cost = value;
        }


        #endregion


        /// <summary>Construtor da classe Labor</summary>
        /// <param name="d">Descrição do trabalho</param>
        /// <param name="c">Custo da mão de obra em euros</param>
        /// <param name="s">Flag para indicar se é subcontratada</param>
        public Labor(string d, decimal c, bool s)
        {
            _description = d;
            _cost = c;
            _subcontracted = s;
        }
    }
}