using System;

namespace AethonsTools
{
    public class Diagnostic<T> : IDiagnostic
        where T : IDiagnosticDescriptor
    {
        public T Descriptor { get; }
        IDiagnosticDescriptor IDiagnostic.Descriptor => Descriptor;

        public string Message { get; }

        public Diagnostic(T descriptor, string message)
        {
            if (descriptor == null)
                throw new ArgumentNullException(nameof(descriptor));
            Descriptor = descriptor;
            Message = message ?? string.Empty;
        }

        public override string ToString() =>
            $"{Descriptor}: {Message}";
    }
}
