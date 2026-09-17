# timur-dotnet-test

NuGet fixture for Aikido Libraries In Use. Packages are ones with Root.io Aikido fixes in `as_root_io_cve_info`.

- `OpenTelemetry.Api` 1.12.0 (fix `1.12.0.416102`)
- `System.Security.Cryptography.Xml` 8.0.3 (fix `8.0.3.416103`)

Aikido NuGet builds append `41610` plus iteration digits (`1.12.0.416102`), not an extra dotted `.41610.`.
