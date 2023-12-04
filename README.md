SHJ.PersianCulture
=======

Simple SHJ.PersianCulture implementation in .NET persian culture  in asp.net
Examples in the [wiki](https://github.com/jabbekhaneh/SHJ.PersianCulture).

<!-- ### How do I get started? -->

### Installing SHJ.FileManager
You should install [SHJ.PersianCulture with NuGet](https://www.nuget.org/packages/SHJ.PersianCulture):

```bash
> Install-Package SHJ.PersianCulture
```

Or via the .NET Core command line interface:
   
```bash
> dotnet add package SHJ.PersianCulture
```
### How to use

```
using SHJ.PersianCulture;
```
### convert datetime sample
```
DateTime.Now.ToPersianDateTextify();
DateTime.Now.ToPersianDateTimeString("yyyy/mm/dd");
and ...
```

### persian Validators sample
```
IsNationalCode : Iranian national code
string nationalcode = "278880924000";
if (!nationalcode.IsNationalCode())
    {
            //Error 
    }
```

