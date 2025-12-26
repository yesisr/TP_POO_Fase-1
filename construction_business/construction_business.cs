
/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Nome da Empresa de construção</summary>
    public class Business
    {
        private string _name = "";
        private List<ConstructionWork> _workList = new();

        #region GetSetters

        /// <summary>GetSet do nome</summary>
        /// <value>Nome</value>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        #endregion

        /// <summary>Construtor da classe de Empresa</summary>
        /// <param name="n">Nome da Empresa</param>
        /// <param name="l">Lista de Trabalhos</param>
        public Business(string n, List<ConstructionWork> l)
        {
            _name = n;
            _workList = l;
        }
    }
}