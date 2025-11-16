/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

using System;

namespace Projeto_POO
{
    /// <summary>
    /// Exceção lançada quando uma quantidade inválida é fornecida (negativa ou zero).
    /// </summary>

    public class InvalidQuantityException : Exception
    {
        public InvalidQuantityException() { }

        /// <summary>
        /// Inicializa uma nova instância da classe InvalidQuantityException com uma mensagem de erro especificada.</summary>
        /// <param name="message"> A mensagem que descreve o erro. </param>
        public InvalidQuantityException(string message) : base(message) { }

        /// <summary> Inicializa uma nova instância da classe InvalidQuantityException com uma mensagem de erro e uma exceção interna. </summary>
        /// <param name="message"> A mensagem que descreve o erro. </param>
        /// <param name="inner"> A exceção que é a causa da exceção atual. </param>
        public InvalidQuantityException(string message, Exception inner) : base(message, inner) { }
    }

    /// <summary>
    /// Exceção lançada quando um material solicitado não é encontrado no armazém.
    /// </summary>
    public class MaterialNotFoundException : Exception
    {
        public MaterialNotFoundException() { }

        /// <summary> Inicializa uma nova instância da classe MaterialNotFoundException com uma mensagem de erro especificada. </summary>
        /// <param name="message"> A mensagem que descreve o erro. </param>
        public MaterialNotFoundException(string message) : base(message) { }

        /// <summary> Inicializa uma nova instância da classe MaterialNotFoundException com uma mensagem de erro e uma exceção interna. </summary>
        /// <param name="message"> A mensagem que descreve o erro. </param>
        /// <param name="inner"> A exceção que é a causa da exceção atual. </param>
        public MaterialNotFoundException(string message, Exception inner) : base(message, inner) { }
    }

    /// <summary>
    /// Exceção lançada quando a quantidade disponível de um material é insuficiente para a operação solicitada.
    /// </summary>
    public class InsufficientStockException : Exception
    {
        public InsufficientStockException() { }

        /// <summary>
        /// Inicializa uma nova instância da classe InsufficientStockException com uma mensagem de erro especificada.
        /// </summary>
        /// <param name="message">  A mensagem que descreve o erro. </param>
        public InsufficientStockException(string message) : base(message) { }

        /// <summary>
        /// Inicializa uma nova instância da classe InsufficientStockException
        /// com uma mensagem de erro e uma exceção interna.
        /// </summary>
        /// <param name="message"> A mensagem que descreve o erro. </param>
        /// <param name="inner"> A exceção que é a causa da exceção atual. </param>
        public InsufficientStockException(string message, Exception inner) : base(message, inner) { }
    }
}
