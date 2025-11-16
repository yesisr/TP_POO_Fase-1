/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>Material de construção com código, descrição e preço unitário.</summary>
    public class Material : IIdentifiable, IDescribable, ICostable, IReportable
    {
        private int _code;
        private string _description = string.Empty;
        private decimal _price;

        #region GetSetters

        /// <summary>Função Get para o código do material.</summary>
        /// <returns>Código identificador único.</returns>
        public int GetCode() => _code;

        /// <summary>Função Set para o código do material.</summary>
        /// <param name="value">Novo código.</param>
        public void SetCode(int value) => _code = value;

        /// <summary>Função Get para a descrição do material.</summary>
        /// <returns>Descrição textual.</returns>
        public string GetDescription() => _description;

        /// <summary>Função Set para a descrição do material.</summary>
        /// <param name="value">Nova descrição. Se nulo, converte para string vazio.</param>
        public void SetDescription(string value) => _description = value ?? string.Empty;

        /// <summary>Função Get para o preço unitário do material.</summary>
        /// <returns>Preço em euros.</returns>
        public decimal GetPrice() => _price;

        /// <summary>Função Set para o preço unitário do material.</summary>
        /// <param name="value">Novo preço em euros.</param>
        public void SetPrice(decimal value) => _price = value;

        /// <summary>Função Get para o custo (equivalente ao preço unitário).</summary>
        /// <returns>Preço em euros.</returns>
        public decimal GetCost() => _price;

        #endregion

        /// <summary>Gera um relatório formatado do material.</summary>
        /// <returns>String com formato: "Material #código: descrição - €preço/un"</returns>
        public string GetReport() => $"Material #{_code}: {_description} - €{_price:F2}/un";

        /// <summary>Construtor da Classe Material.</summary>
        /// <param name="c">Código único do material.</param>
        /// <param name="d">Descrição do material. Se nulo, converte para string vazio.</param>
        /// <param name="p">Preço unitário em euros.</param>
        public Material(int c, string d, decimal p)
        {
            _code = c;
            _description = d ?? string.Empty;
            _price = p;
        }
    }
}
