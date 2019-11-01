# Async-Inn

LAB 13: Intro to Entity Framework  

*Author: Biniam Tesfamariam*

----

## Description
This is an ASP.NET web application that creates hotel management system, 
this is the initial .NET Core MVC structure and application built from scratch.

## Application Specifications
###### Your application should include the following:  

1) Startup File  
- Explicit routing of MVC  
- MVC dependency in ConfigureServices  
- DBContext registered in ConfigureServices  
- Use of static files accepted  
2) Controller  
- Home Controller  
3) Data  
- DBContext present and properly configured  
- DB Tables for each entity model (DbSet<T>)  
- Composite key association present in OnModelCreating override.  
- appsettings.json file present with name of database updated.  
4) Models  
- Each Entity from the DB Table converted into a Model  
- Proper naming conventions of Primary keys  
- Navigation properties present in each Model where required  
- Enum present in appropriate model  
5) Views  
- View for home page that matches default routing  
6) Home Page  
- stylesheet present in web application.  
- stylesheet referenced on home page.  
7) Web application should build, compile, and redirect us to the home page upon launch.  


---

### Getting Started
Clone this repository to your local machine.

```
$ git clone https://github.com/biniamsea2/Async-Inn.git
```

### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```Async-Inn``` directory.

Then select and open ```AyncINN.sln```

---

### Visuals

#### Application Start
![Image 1](https://github.com/biniamsea2/Lab03-Systems-IO/blob/master/Screenshots/mainMenu.png)

---

### Change Log
1.0: LAB 13: Intro to Entity Framework partial 10/31/19

------------------------------