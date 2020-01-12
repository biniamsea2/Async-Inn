# Async-Inn


*Author: Biniam Tesfamariam*

----

## Problem Domain
The owners of “Async Inn” have approached you with plans to renovate their hotel chain. Currently they are tracking all the different locations and rooms in spreadsheets and binders. They currently have about 10 binders full of paperwork that consists of the difference between each location and the pricing for each room. The amount of time and paperwork it takes to manage the rooms and locations is costing the company both time and money. They are currently looking for a “better way” to maintain their business model.

They are currently looking for a full stack web application that will allow them to better manage the assets in their hotels. They are anticipating the ability to modify and manage rooms, amenities, and new hotel locations as they are built. They have turned to you to assist them in persisting their data across a relational database and maintain its integrity as they make changes to the system.

## Azure Deployed Site
https://asynchotel.azurewebsites.net

## Application Specifications
###### Your application should include the following:  

#### 1) Startup File  
- Explicit routing of MVC  
- MVC dependency in ConfigureServices  
- DBContext registered in ConfigureServices  
- Use of static files accepted  
#### 2) Controller  
- Home Controller  
#### 3) Data  
- DBContext present and properly configured  
- DB Tables for each entity model (DbSet<T>)  
- Composite key association present in OnModelCreating override.  
- appsettings.json file present with name of database updated.  
#### 4) Models  
- Each Entity from the DB Table converted into a Model  
- Proper naming conventions of Primary keys  
- Navigation properties present in each Model where required  
- Enum present in appropriate model  
#### 5) Views  
- View for home page that matches default routing  
#### 6) Home Page  
- stylesheet present in web application.  
- stylesheet referenced on home page.  
#### 7) Web application should build, compile, and redirect us to the home page upon launch.  


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

### Entity Relationship Diagram
![Image 1](https://github.com/biniamsea2/Async-Inn/blob/master/AsyncInn2.png)
### Application Home Page
![Image 1](https://github.com/biniamsea2/Async-Inn/blob/master/AyncINN/Screenshot%20(57).png)
### View of All Hotels
![Image 1](https://github.com/biniamsea2/Async-Inn/blob/master/AyncINN/Screenshot%20(58).png)
### Editing a Hotel
![Image 1](https://github.com/biniamsea2/Async-Inn/blob/master/AyncINN/Screenshot%20(62).png)
### Deleting a Hotel
![Image 1](https://github.com/biniamsea2/Async-Inn/blob/master/AyncINN/Screenshot%20(61).png)
### View of All Amenities
![Image 1](https://github.com/biniamsea2/Async-Inn/blob/master/AyncINN/Screenshot%20(60).png)
### View of All Rooms
![Image 1](https://github.com/biniamsea2/Async-Inn/blob/master/AyncINN/Screenshot%20(63).png)
### Delete a Room
![Image 1](https://github.com/biniamsea2/Async-Inn/blob/master/AyncINN/Screenshot%20(65).png)

---
### Hotel Table:  
The hotel table consists of all the hotel's information that the owners of the Async hotel requires. It includes the primary ID key, name, city, state, address, phone number, and the number of rooms. It has a 1:Many relationship to the HotelRoom table. 

### HotelRoom Table:  
The HotelRoom table is the join table with payload since it holds two foreign keys the HotelID and the Room ID. In addition is also has information on the rate and whether or not it's pet friendly. It has a many:1 relationship to the Room table.

### Room Table:  
Consits of a primary key and information on the name and layout of the room. We also have an enum of the room's layout, whether it's a one bedroom, two bedroom, or a studio. This table has a 1:many relationship with the RoomAmenities table.

### Room Amenities Table:  
RoomAmenities table is our pure join table since its taking only two foreign keys (AmenitiesID and RoomID). This table has a many:1 relationship to the Amenities table.

### Amenities Table:  
Our Amenities table is holding a primary key and information regarding the names if the amenities.

---

### Change Log
1.0: LAB 13 Intro to Entity Framework completed 10/31/19  
1.1: LAB 14 Entity Framework pt. 2 completed 11/4/19  
1.2: LAB 16 Dependency Injection partial 11/5/19  
1.3:  LAB 18 Testing & Deployment partial 11/10/19  

------------------------------
