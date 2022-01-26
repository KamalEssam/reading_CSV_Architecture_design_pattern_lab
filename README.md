
## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)

## General info
This project is simple Project ASP.NET Core MVC, it help user to arrange data formatting coming from csv file.
## Technologies
Project is created with:
* ASP.net Core MVC
* HTML
* Css3
* Repository design Patter 
* MVC design Pattern 

## Setup
To run this project, install it local, without Visual Studio it would be as easy as:

```
$ git clone https://github.com/KamalEssam/reading_CSV_Architecture_design_pattern_lab.git
$ cd reading_CSV_Architecture_design_pattern_lab
$ dotnet run
```
dotnet run will restore (dotnet restore) the dependencies, build (dotnet build) the project and run it. 

**However, that's not the case, so you can only:**

- Restore the nuget packages using Visual Studio or nuget.exe cli.
- Compile it* using or msbuild.
- Run it... from Visual Studio, which makes the rest of the process kind of worthless.

```
$ git clone https://github.com/KamalEssam/reading_CSV_Architecture_design_pattern_lab.git
$ cd reading_CSV_Architecture_design_pattern_lab
$ nuget.exe restore
$ msbuild /t:build
```
## Note : ##
#### you can also use visual studio Clone Asp.net project directly from __clone github extension__ #### 
