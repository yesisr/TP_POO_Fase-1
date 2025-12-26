/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-12-26</date>
/// <copyright>Copyright (c) 2025</copyright>

namespace Projeto_POO
{
    /// <summary>
    /// Exceção lançada quando uma quantidade fornecida é inválida
    /// </summary>
    public class InvalidQuantityException : Exception
    {
        public InvalidQuantityException() { }
        public InvalidQuantityException(string message) : base(message) { }
        public InvalidQuantityException(string message, Exception inner) : base(message, inner) { }
    }

    /// <summary>
    /// Exceção lançada quando um material solicitado não é encontrado
    /// </summary>
    public class MaterialNotFoundException : Exception
    {
        public MaterialNotFoundException() { }
        public MaterialNotFoundException(string message) : base(message) { }
        public MaterialNotFoundException(string message, Exception inner) : base(message, inner) { }
    }

    /// <summary>
    /// Exceção lançada quando um armazem solicitado não é encontrado
    /// </summary>
    public class StorageNotFoundException : Exception
    {
        public StorageNotFoundException() { }
        public StorageNotFoundException(string message) : base(message) { }
        public StorageNotFoundException(string message, Exception inner) : base(message, inner) { }
    }

    /// <summary>
    /// Exceção lançada quando um veículo não é encontrado
    /// </summary>
    public class VehicleNotFoundException : Exception
    {
        public VehicleNotFoundException() { }
        public VehicleNotFoundException(string message) : base(message) { }
        public VehicleNotFoundException(string message, Exception inner) : base(message, inner) { }
    }

    /// <summary>
    /// Exceção lançada quando um um veículo com a mesma matricula é inserido
    /// </summary>
    public class VehicleExistsException : Exception
    {
        public VehicleExistsException() { }
        public VehicleExistsException(string message) : base(message) { }
        public VehicleExistsException(string message, Exception inner) : base(message, inner) { }
    }

    /// <summary>
    /// Exceção lançada quando a obra não foi carregada
    /// </summary>
    public class ConstructionWorkNotFoundException : Exception
    {
        public ConstructionWorkNotFoundException() { }
        public ConstructionWorkNotFoundException(string message) : base(message) { }
        public ConstructionWorkNotFoundException(string message, Exception inner) : base(message, inner) { }
    }



}
