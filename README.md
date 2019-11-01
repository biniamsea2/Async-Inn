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

#### Entity Relationship Diagram
![Image 1](https://github.com/biniamsea2/Async-Inn/blob/master/AsyncInn2.png)

---
### Hotel Table: The hotel table consists of all the hotel's information that the owners of the Async hotel requires. It includes the primary ID key, name, city, state, address, phone number, and the number of rooms. It has a 1:Many relationship to the HotelRoom table. 

Room Table: The room table is the joint table with payload since it holds two foreign keys the location ID and the room type ID as well as the room number and the price. It also holds the room number and the price. The room relies on two tables the location and room type tables.

Nickname Table: The nickname table is pure join table keys which are the location ID, room type ID, and the amenities group ID. 

Room Type: Room type table holds the primary ID key and the layout of the room type. It also relies on the room table.
Amenities Group Table: Takes in a primary key and a foreign key. The foreign key is the amenities ID. We are grouping a bunch of amenities in a group.

Amenities Enum: The amenities is an enum and has the primary ID key. This will hold all the different types of amenities.

---

### Change Log
1.0: LAB 13: Intro to Entity Framework partial 10/31/19

------------------------------
