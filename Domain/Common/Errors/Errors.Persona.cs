using ErrorOr;

namespace Domain.Common.Errors;

public class PersonaErrors
{
    // Too basic but just to test, I'll set up some more later
    public static Error NotFoundPersona = Error.NotFound(
        code: "Persona.NotFoundPersona",
        description: "La persona no existe o esta inactiva"
        );
}