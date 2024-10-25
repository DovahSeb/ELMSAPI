using System.Net;

namespace ELMSAPI.Exceptions;

public class ReferencesNotFoundException : BaseException
{
    public ReferencesNotFoundException(string Name) : base($"Reference {Name} values not found", HttpStatusCode.NotFound) { }
}
