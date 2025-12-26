/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Material de construção com código, descrição e preço unitário.</summary>
    public class Material : IIdentifiable, IDescribable, ICostable
    {
        private int _code;
        private string _description = string.Empty;
        private decimal _cost;

        #region GetSetters
        

        /// <summary>GetSet para o código do material</summary>
        /// <returns>Código identificador único</returns>
        public int Code
        {
            get => _code;
            set => _code = value;
        }

        /// <summary>GetSet para a descrição do material</summary>
        /// <returns>Descrição do material</returns>
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        /// <summary>GetSet para o custo unitário do material</summary>
        /// <returns>Preço em euros</returns>
        public decimal Cost
        {
            get => _cost;
            set => _cost = value;
        }


        #endregion


        /// <summary>Construtor da Classe Material</summary>
        /// <param name="c">Código único do material</param>
        /// <param name="d">Descrição do material</param>
        /// <param name="C">Custo unitário em euros</param>
        public Material(int c, string d, decimal C)
        {
            _code = c;
            _description = d;
            _cost = C;
        }
    }
}
