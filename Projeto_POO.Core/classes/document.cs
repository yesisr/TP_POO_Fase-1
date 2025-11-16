using System;

namespace Projeto_POO
{
    /// <summary>Documento da obra com tipo, caminho de arquivo e data.</summary>
    public class Document : IDateable, IDescribable, IReportable
    {
        private string _type = string.Empty;
        private string _path = string.Empty;
        private DateTime _date;

        #region GetSetters

        /// <summary>Função Get para o tipo de documento.</summary>
        /// <returns>Tipo/categoria do documento.</returns>
        public string GetDocumentType() => _type;

        /// <summary>Função Set para o tipo de documento.</summary>
        /// <param name="value">Novo tipo. Se nulo, será convertido para string vazio.</param>
        public void SetDocumentType(string value) => _type = value ?? string.Empty;

        /// <summary>Função Get para a descrição (tipo) do documento.</summary>
        /// <returns>Tipo do documento.</returns>
        public string GetDescription() => _type;

        /// <summary>Função Set para a descrição do documento.</summary>
        /// <param name="value">Nova descrição. Se nulo, será convertido para string vazio.</param>
        public void SetDescription(string value) => _type = value ?? string.Empty;

        /// <summary>Função Get para o caminho do arquivo.</summary>
        /// <returns>Caminho do arquivo no sistema.</returns>
        public string GetPath() => _path;

        /// <summary>Função Set para o caminho do arquivo.</summary>
        /// <param name="value">Novo caminho. Se nulo, será convertido para string vazio.</param>
        public void SetPath(string value) => _path = value ?? string.Empty;

        /// <summary>Função Get para a data do documento.</summary>
        /// <returns>Data de criação/adição do documento.</returns>
        public DateTime GetDate() => _date;

        /// <summary>Função Set para a data do documento.</summary>
        /// <param name="value">Nova data.</param>
        public void SetDate(DateTime value) => _date = value;

        #endregion

        /// <summary>Gera um relatório formatado do documento.</summary>
        /// <returns>String com formato: "Documento: tipo - caminho (data)".</returns>
        public string GetReport() => $"Documento: {_type} - {_path} ({_date:dd/MM/yyyy})";

        /// <summary>Construtor da classe Document.</summary>
        /// <param name="t">Tipo/categoria do documento. Se nulo, será convertido para string vazio.</param>
        /// <param name="p">Caminho do arquivo. Se nulo, será convertido para string vazio.</param>
        /// <param name="d">Data do documento.</param>
        public Document(string t, string p, DateTime d)
        {
            _type = t ?? string.Empty;
            _path = p ?? string.Empty;
            _date = d;
        }
    }
}