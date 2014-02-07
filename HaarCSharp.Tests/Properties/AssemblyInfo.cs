using System.Reflection;
using System.Runtime.InteropServices;

using ApprovalTests.Reporters;

[assembly: AssemblyTitle("HaarCSharp.Tests")]
[assembly: AssemblyDescription("Tests for HaarCSharp")]
[assembly: AssemblyCompany("Jim Counts")]
[assembly: AssemblyProduct("HaarCSharp.Tests")]
[assembly: AssemblyCopyright("Copyright © Jim Counts 2014")]
[assembly: ComVisible(false)]
[assembly: Guid("e365bf89-ee88-4a36-add9-3f41e75f9653")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: UseReporter(typeof(DiffReporter))]