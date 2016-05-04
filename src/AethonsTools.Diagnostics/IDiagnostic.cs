namespace AethonsTools
{
    public interface IDiagnostic
    {
        IDiagnosticDescriptor Descriptor { get; }
        string Message { get; }
    }
}