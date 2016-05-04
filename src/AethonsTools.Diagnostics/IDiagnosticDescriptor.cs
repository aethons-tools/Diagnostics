namespace AethonsTools
{
    public interface IDiagnosticDescriptor
    {
        string Severity { get; }
        string Code { get; }
        string Title { get; }
    }
}