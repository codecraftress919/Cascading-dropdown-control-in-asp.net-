# Cascading-dropdown-control-in-asp.net-
using database and dropdown web control in asp.net website , i file a cascading dropdowncontrol  which is connected to eachother

Overview

This project is a simple ASP.NET Web Forms application that demonstrates the use of cascading dropdown lists to dynamically load data based on user selections. The application interacts with a MySQL database to populate the dropdown lists with data from different tables. The tables in the database are related through primary and foreign keys, allowing for the cascading effect when selecting an item from a dropdown list.
Project Structure

The main components of this project are:

    Default.aspx: The ASPX page that contains the dropdown lists.
    Default.aspx.cs (Code-Behind File): The C# code that handles the logic for loading data into the dropdown lists.
    DataAccessLayer.cs: A class responsible for interacting with the database to fetch data.

Database

The database used in this project is MySQL. The database consists of the following tables:

    City:
        cityid (Primary Key)
        cityname

    Area:
        areaid (Primary Key)
        areaname
        cityid (Foreign Key referencing City)

    Street:
        streetid (Primary Key)
        streetname
        areaid (Foreign Key referencing Area)

These tables are related to each other through foreign key constraints, allowing for the cascading dropdown functionality.
