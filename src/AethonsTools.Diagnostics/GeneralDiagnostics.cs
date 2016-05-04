namespace AethonsTools
{
    public static class GeneralDiagnostics
    {
        public static readonly BasicDiagnosticDescriptor GENFatal = new BasicDiagnosticDescriptor(Severity.Fatal, "GEN-Fatal", "General Fatal Error");
        public static readonly BasicDiagnosticDescriptor GENError = new BasicDiagnosticDescriptor(Severity.Error, "GEN-Error", "General Error");
        public static readonly BasicDiagnosticDescriptor GENWarning = new BasicDiagnosticDescriptor(Severity.Fatal, "GEN-Warning", "General Warning");
        public static readonly BasicDiagnosticDescriptor GENInfo = new BasicDiagnosticDescriptor(Severity.Fatal, "GEN-Info", "General Info");
        public static readonly BasicDiagnosticDescriptor GENTrace = new BasicDiagnosticDescriptor(Severity.Fatal, "GEN-Trace", "General Trace");

        public static BasicDiagnostic Fatal(string message) => new BasicDiagnostic(GENFatal, message);
        public static BasicDiagnostic Error(string message) => new BasicDiagnostic(GENError, message);
        public static BasicDiagnostic Warning(string message) => new BasicDiagnostic(GENWarning, message);
        public static BasicDiagnostic Info(string message) => new BasicDiagnostic(GENInfo, message);
        public static BasicDiagnostic Trace(string message) => new BasicDiagnostic(GENTrace, message);
    }
}