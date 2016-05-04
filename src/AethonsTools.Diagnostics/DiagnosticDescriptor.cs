namespace AethonsTools
{
    public class DiagnosticDescriptor<TSeverity, TCode> : IDiagnosticDescriptor
    {
        public TSeverity Severity { get; }
        string IDiagnosticDescriptor.Severity => Severity?.ToString();

        public TCode Code { get; }
        string IDiagnosticDescriptor.Code => Code?.ToString();

        public string Title { get; }

        public DiagnosticDescriptor(TSeverity severity, TCode code, string title)
        {
            Severity = severity;
            Code = code;
            Title = title;
        }

        public override string ToString() =>
            $"{Severity} {Code} ({Title})";
    }
}