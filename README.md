# Athena

Inspired by the Greek goddess of wisdom, [Athena](https://en.wikipedia.org/wiki/Athena) is an open-source tool designed to manage your book collection.

<p align="center">
  <img height="250" src="https://raw.githubusercontent.com/gomezportillo/Athena/master/assets/images/logo/logo.png" alt="Athena Logo"/>
</p>

You can store details such as the title, author, section, and the number of units owned for each book.

<p align="center">
  <img height="200" src="https://raw.githubusercontent.com/gomezportillo/Athena/master/assets/images/screenshots/ddbb.png" alt="Database Diagram"/>
</p>

## Download

You can download the latest version of the [executable](https://github.com/gomezportillo/Athena/raw/master/latest_build/Athena.exe) along with an [empty database](https://github.com/gomezportillo/Athena/raw/master/assets/empty_ddbb/Athena.accdb).

## Installation

Athena is a portable application, meaning no installation is required. Simply place `Athena.exe` and `Athena.accdb` in the same directory and run the executable. It has been tested on Windows 7, 8, 10, and various Linux distributions.

## Usage

Athena features two main tabs:

1. **Add Book**: This tab allows users to store books by entering their details. As you type, matching results from the database will be displayed for quick reference.
   <p align="center">
     <img src="https://raw.githubusercontent.com/gomezportillo/Athena/master/assets/images/screenshots/add_book.png" alt="Add Book" width="600"/>
   </p>

2. **Manage Books**: This tab displays all books in the database, enabling users to search for specific titles, authors, or sections. The results update dynamically as you type, and you can edit or delete books by right-clicking on them.

   <p align="center">
     <img src="https://raw.githubusercontent.com/gomezportillo/Athena/master/assets/images/screenshots/manage_books.png" alt="Manage Books" width="600"/>
   </p>

   When you choose to edit a book, a new form will prompt you to modify its details and save any changes.

   <p align="center">
     <img src="https://raw.githubusercontent.com/gomezportillo/Athena/master/assets/images/screenshots/edit_book.png" alt="Edit Book" width="600"/>
   </p>

Additionally, the **Help > About** section will display information related to Athena, including the date of the current build.

   <p align="center">
     <img src="https://raw.githubusercontent.com/gomezportillo/Athena/master/assets/images/screenshots/about.png" alt="About Athena" width="600"/>
   </p>

## Further Development

Athena is modular by design. As an open-source project, you are encouraged to enhance its capabilities by forking the repository. Open it in [Visual Studio](https://www.visualstudio.com/) and add new functionalities or modify the database tables (Microsoft Access is required for database modifications).

The tool [MDB Viewer Plus](http://www.alexnolan.net/software/mdb_viewer_plus.htm) can help you opening the database in case you do not have Microsoft Access or LibreOffice Base installed

## Known issues

You can find a warning regarding the missing `x86 Microsoft OLEDB driver` for database access. You can download it [here](assets/drivers_OSx86/AccessDatabaseEngine.exe). Simply install the driver and relaunch Athena.

For any bugs or suggestions for new features, please log them on the [issues page](https://github.com/gomezportillo/Athena/issues) or contact me at [pedroma.almagro@gmail.com](mailto:pedroma.almagro@gmail.com).
