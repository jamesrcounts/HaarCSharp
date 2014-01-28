using System.Reflection;
using System.Runtime.InteropServices;
using ApprovalTests.Reporters;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("HaarCSharp.Tests")]
[assembly: AssemblyDescription("Tests for HaarCSharp")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Jim Counts")]
[assembly: AssemblyProduct("HaarCSharp.Tests")]
[assembly: AssemblyCopyright("Copyright © Jim Counts 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e365bf89-ee88-4a36-add9-3f41e75f9653")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: UseReporter(typeof(DiffReporter))]
