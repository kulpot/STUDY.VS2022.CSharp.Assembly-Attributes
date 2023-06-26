using System;

//ref link:https://www.youtube.com/watch?v=Vjs7Ocf1Lcc&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=11


// no assemblyInfo.cs in vs2022 // its in project properties then packages // link help:https://learn.microsoft.com/en-us/answers/questions/774224/vs2022-winform-project-and-assemblyinfo-cs-file-mi

/*
 *          Sample AssemblyInfo.cs
 *          
 *  using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    // General Information about an assembly is controlled through the following 
    // set of attributes. Change these attribute values to modify the information
    // associated with an assembly.
    [assembly: AssemblyTitle("MyProject")]
    [assembly: AssemblyDescription("")]
    [assembly: AssemblyConfiguration("")]
    [assembly: AssemblyCompany("My Company")]
    [assembly: AssemblyProduct("MyProject")]
    [assembly: AssemblyCopyright("Copyright ©  2019")]
    [assembly: AssemblyTrademark("")]
    [assembly: AssemblyCulture("")]

    // Setting ComVisible to false makes the types in this assembly not visible 
    // to COM components.  If you need to access a type in this assembly from 
    // COM, set the ComVisible attribute to true on that type.
    [assembly: ComVisible(false)]

    // The following GUID is for the ID of the typelib if this project is exposed to COM
    [assembly: Guid("8e128185-dcf8-4f3d-9e21-e4e7bbbd7cbd")]

    // Version information for an assembly consists of the following four values:
    //
    //      Major Version
    //      Minor Version 
    //      Build Number
    //      Revision
    //
    // You can specify all the values or you can default the Build and Revision Numbers 
    // by using the '*' as shown below:
    //[assembly: AssemblyVersion("1.0.*")]
    [assembly: AssemblyVersion("1.0.5.25")]
    [assembly: AssemblyFileVersion("1.0.5.25")]
 * 
 */

[assembly: Me]

class MeAttribute : Attribute { }

class MainClass
{
    static void Main()
    {

    }
}