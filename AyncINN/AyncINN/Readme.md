# Async-Inn

LAB 14: Entity Framework pt. 2

*Author: Biniam Tesfamariam*

----

## Description
To continue with your AsyncInn Hotel Management System, you need to seed hotel data to display in your application. 
For Today’s branch, focus on working within the existing code base that was scaffolded out (If you chose to scaffold). 
Practice learning and understanding a code base that you didn’t write, 
but need to make modifications too.
## Application Specifications
###### For our website, we will have the following pages:  

1) Home Page to greet the Hotel Admin. This page will also serve as a dashboard for the other locations of the site.  
2) Hotels page that will allow the Admin to create and edit new or existing hotels.  
3) Rooms page where the Admin will be able to create or edit new or existing rooms.  
4) Amenities page that will allow the Admin to add to their list of existing amenities.  
5) A page where they can link the Amenities to the rooms that currently exist.  
6) A page where they can add existing rooms to hotels.  
###### Following the design, Create a controller for each of the pages listed above. You should “Add » Controller” on the controllers folder and scaffold out the basic CRUD operations.

##### Your application should include the following:  

1) Seed your database with at least  
5 default Hotel Locations.  
6 Room Types.  
5 Amenities.   
2) Do not make any seeded associations with HotelRoom or RoomAmenities.    
3) Update the dropdown lists to include the Layout enum, and associations between the Room and Hotel, as well as the Room and Amenities. Be sure to display user friendly information in your views (example: display string names instead of ids).  
4) Based off of the readings from day 14, either utilize bootstrap (download it into your project from NuGet), or remove all bootstrap specific classes in your HTML. (clean it up!)  
5) Add your own styling to the Hotel creation page, Room Creation Page, and Amenities creation page.  
6) On the Home Page, create a navigation to the “Create Hotel” page, “Create Room” page, “Create Amenity” page, as well as pages for the “HotelRoom” association and “RoomAmenity” association. Each of these pages (excluding HotelRoom and Room Amenity (see below)) should allow the user to edit/remove existing data.   
All pages should allow to view the data.  

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
1.0: LAB 14: Entity Framework pt. 2 completed 11/4/19

------------------------------