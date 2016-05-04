namespace AethonsTools
{
    public sealed class BasicDiagnostic : Diagnostic<BasicDiagnosticDescriptor>
    {
        public BasicDiagnostic(BasicDiagnosticDescriptor descriptor, string message) : base(descriptor, message)
        {
        }
    }
}