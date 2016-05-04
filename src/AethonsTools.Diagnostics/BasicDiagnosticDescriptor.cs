namespace AethonsTools
{
    public sealed class BasicDiagnosticDescriptor : DiagnosticDescriptor<Severity, string>
    {
        public BasicDiagnosticDescriptor(Severity severity, string code, string title) : base(severity, code, title)
        {
        }
    }
}