# Athena
An open-source tool for a home library management.

<p align="center">
  <img height=250 src=assets/images/logo/logo.png?raw=true" alt="Logo"/>
</p>
[Athena](https://en.wikipedia.org/wiki/Athena) is a project aimed to basic book management. You can store the title, author, section and units owned of a book.

<p align="center">
  <img src=assets/images/screenshots/ddbb.png?raw=true" alt="Database diagram"/>
</p>

## Download
Download the [executable](https://github.com/gomezportillo/Athena/raw/master/latest_build/Athena.exe) and a [empty database](https://github.com/gomezportillo/Athena/raw/master/assets/empty_ddbb/Athena.accdb).

## Installation
Athena is portable, so does not need any installation. Place Athena.exe and Athena.accdb on same directory and execute the first one. It has been tested on Windows 7, 8, 10 and some Linux distros.

## Use
Athena consists on two main tabs,
- First one, *Add book*, will allow the user to store books by entering its data. At the same time you are writing on the fields, matching stored results will be showed.
<p align="center">
  <img src=assets/images/screenshots/add_book.png?raw=true" alt="Add book"/>
</p>
- Second one, *Manage books*, will list all the books on the database, allowing the user to search an specific one by title, author or section, updating results at the same time the user writs, and to edit or delete a book by right-clicking on it.
<p align="center">
  <img src=assets/images/screenshots/manage_books.png?raw=true" alt="Manage books"/>
</p>
Edit will prompt a new form in where the user will be able to edit the data of that book and save changes.
<p align="center">
  <img src=assets/images/screenshots/edit_book.png?raw=true" alt="Edit book"/>
</p>

Help>About will prompt a form displaying information relative to Athena and the date of the current build.
<p align="center">
  <img src=assets/images/screenshots/about.png?raw=true" alt="About Athena"/>
</p>

## Further development
Athena is module-based. As it is an open-source project, you can add new capabilities by forking this repository, opening it with [Visual Studio](https://www.visualstudio.com/) and adding new functionality to the software or new tables to the database (you will need to have [Microsoft Access](https://products.office.com/es-es/access) installed to do so).

## Issues
You may be warned if you do not have installed the x86 Microsoft OLEDB driver for working with the database. You can find it [here](assets/drivers_OSx86/AccessDatabaseEngine.exe). Just download, install it and launch Athena again.

Should you find any error or think on any welcome capability, please do not hesitate to log it on the [issues page](https://github.com/gomezportillo/Athena/issues) or to contact me at [pedroma.almagro@gmail.com](mailto:pedroma.almagro@gmail.com)
