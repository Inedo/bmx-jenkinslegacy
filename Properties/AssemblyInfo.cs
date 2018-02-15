using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Inedo.BuildMaster.Extensibility;
using Inedo.Extensibility;

[assembly: AssemblyTitle("JenkinsLegacy")]
[assembly: AssemblyDescription("Contains legacy actions to get artifacts and trigger builds in Jenkins.")]

[assembly: ComVisible(false)]
[assembly: AssemblyCompany("Inedo, LLC")]
[assembly: AssemblyProduct("BuildMaster")]
[assembly: AssemblyCopyright("Copyright © 2008 - 2018")]
[assembly: AssemblyVersion("0.0.0.0")]
[assembly: AssemblyFileVersion("0.0")]
[assembly: CLSCompliant(false)]
[assembly: RequiredBuildMasterVersion("6.0.0")]

[assembly: ScriptNamespace("Jenkins")]