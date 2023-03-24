# _Employee and Client Tracker_

#### By Justin Lee

#### _.net Fullstack application that uses SQL databases to register an imaginary factory workers and workers that are qualified to fix certain machines._
## Technologies Used

* C#
* .Net
* HTML
* Bootstrap

## Description

This website is a application that allows an imaginary owner of a bakery to display his products and have relational ties between his products and their flavors using Many to Many database relationship.


## Setup/Installation Requirements

1. Clone this repo.
2. Navigate to the ``Bakery`` Directory and use command ``dotnet build`` to add dependancies. 
3. Create a file called ``appsettings.json`` which will house these lines: 
``{"ConnectionStrings": {"DefaultConnection":"Server=localhost;Port=3306;database=[YOUR_DATA_BASE_HERE];uid=[YOUR_USER_ID_HERE];pwd=[YOUR_PASSWORD_HERE];"}}`` 
This will allow our website to connect with our local SQL database. This requires users to have a SQL database account set up on their local machine. Remove brackets when entering the name of your database, user id, and pw.
4. a. Database is constructed using ``EntityFrameWorkCore.Design`` and its migration feature which should be installed during the ``dotnet build`` command : 
5. b. Use the ``dotnet ef database update`` command. As the Migration files are included in the repo, you do not need to ``dotnet ef migrations add "..."``
6. After running ``dotnet run``, application should be hosted to your local host in web browser.


## Known Bugs

* N/A

## License

MIT

Copyright (c) 2023 _Justin Lee _
