using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Domain.Exceptions;

[Serializable]
public class PersonaNotRegisteredException : Exception
{
    public PersonaNotRegisteredException() : base("could not register persona") { }

    [ExcludeFromCodeCoverage]
    protected PersonaNotRegisteredException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}