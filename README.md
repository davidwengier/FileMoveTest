# FileMoveTest
Repro repo for https://github.com/dotnet/runtime/issues/35122

Output from running this on my M1 MacBook Pro is as follows:
```
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run
Unhandled exception. System.IO.FileNotFoundException: Could not find file '/Users/davidwengier/Code/FileMoveTest/output.txt.tmp'.
File name: '/Users/davidwengier/Code/FileMoveTest/output.txt.tmp'
   at System.IO.FileInfo.MoveTo(String destFileName, Boolean overwrite)
   at System.IO.FileInfo.MoveTo(String destFileName)
   at Program.<Main>$(String[] args) in /Users/davidwengier/Code/FileMoveTest/Program.cs:line 25
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run
Unhandled exception. System.IO.FileNotFoundException: Could not find file '/Users/davidwengier/Code/FileMoveTest/output.txt.tmp'.
File name: '/Users/davidwengier/Code/FileMoveTest/output.txt.tmp'
   at System.IO.FileInfo.MoveTo(String destFileName, Boolean overwrite)
   at System.IO.FileInfo.MoveTo(String destFileName)
   at Program.<Main>$(String[] args) in /Users/davidwengier/Code/FileMoveTest/Program.cs:line 32
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run
Unhandled exception. System.IO.FileNotFoundException: Could not find file '/Users/davidwengier/Code/FileMoveTest/output.txt.tmp'.
File name: '/Users/davidwengier/Code/FileMoveTest/output.txt.tmp'
   at System.IO.FileInfo.MoveTo(String destFileName, Boolean overwrite)
   at System.IO.FileInfo.MoveTo(String destFileName)
   at Program.<Main>$(String[] args) in /Users/davidwengier/Code/FileMoveTest/Program.cs:line 32
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run fixed
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run fixed
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run fixed
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run fixed
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
% dotnet run fixed
davidwengier@Davids-Work-M1-MacBook-Pro ~/Code/FileMoveTest 
%
```

Essentially, every second run that uses `MoveTo` fails, but no failures when using `Move`. I would expect both versions of the code to perform exactly the same.
