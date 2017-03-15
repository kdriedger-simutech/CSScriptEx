# CSScriptEx
Provides common command line commands for the C# scripting environment.

Example usage:

From the command line:
======================

D:\code\cscripts\CSScriptEx\src>csi
Microsoft (R) Visual C# Interactive Compiler version 1.3.1.60616
Copyright (C) Microsoft Corporation. All rights reserved.

Type "#help" for more information.
> #load "profile.csx"
> ls
D:\code\cscripts\CSScriptEx\src\default.csx
D:\code\cscripts\CSScriptEx\src\profile.csx
""
> pwd
"D:\\code\\cscripts\\CSScriptEx\\src"
> cd="D:\\code\\cscripts\\CSScriptEx"
"D:\\code\\cscripts\\CSScriptEx"
> ls
D:\code\cscripts\CSScriptEx\.gitignore
D:\code\cscripts\CSScriptEx\LICENSE
D:\code\cscripts\CSScriptEx\README.md
""
> #load "default.csx"
(1,7): error CS1504: Source file 'default.csx' could not be opened -- Could not find file.
> cd="D:\\code\\cscripts\\CSScriptEx\\src"
"D:\\code\\cscripts\\CSScriptEx\\src"
> #load "default.csx"
> CsiAliases.dir();
> foreach(var e in ListDirectory(".")) { Console.WriteLine("=>" + e); }
=>.\default.csx
=>.\profile.csx
> foreach(var d in CsiAliases.dir()) { Console.WriteLine("=>" + d); }
=>D:\code\cscripts\CSScriptEx\src\default.csx
=>D:\code\cscripts\CSScriptEx\src\profile.csx
> cat("foo foo the snoo");
(1,1): error CS0103: The name 'cat' does not exist in the current context
> CsiAliases.cat("foo foo the snoo");
foo foo the snoo
> CsiAliases.type("foo foo the snoo", "by the fake Dr. Seuss");
foo foo the snoo
-------------
by the fake Dr. Seuss
-------------
>

