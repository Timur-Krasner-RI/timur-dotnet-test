using OpenTelemetry.Trace;
using System.Security.Cryptography.Xml;

Console.WriteLine(typeof(TracerProvider).FullName);
_ = new SignedXml();
