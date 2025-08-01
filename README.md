### **Simple Console Product Management System**

#### **Project Description**

This project is a simple command-line application developed in C\# for a university final exam (`UAS`). The program simulates a basic product management system where a user can add and verify a product's details through an interactive menu.

The primary goal of this project is to demonstrate fundamental programming concepts in C\#, including menu-driven navigation, user input handling, conditional logic, and basic error management. Its core logic relies on **static members**, meaning it is designed to hold information for only **one product at a time** within the program's memory.

-----

#### **Core Concepts Applied**

This project applies several key programming concepts:

  * **Static Members:** The entire application operates using `static` variables (`ID_M`, `NAMA_M`) and `static` methods (`TAMBAH`, `CHECK`). This means all data and functions belong to the class itself, not to an object instance, making the product data globally accessible within the class.
  * **Procedural Decomposition:** The code is organized into distinct methods (`TAMBAH`, `CHECK`), each responsible for a specific task (adding a product, verifying a product). This separates concerns and makes the code easier to read and maintain.
  * **Control Flow:** The program's logic is managed using various control flow structures:
      * **`while` loop:** Drives the main menu, keeping the application running until the user chooses to exit.
      * **`switch` statement:** Efficiently handles user menu selections to call the appropriate method.
      * **`if-else` logic:** Used extensively for input validation (e.g., checking if an entry is empty) and for providing specific feedback in the `CHECK` method.
  * **Input Validation & Type Safety:** The `int.TryParse()` method is used to safely convert the user's string input for the product ID into an integer. This prevents the program from crashing if the user enters non-numeric text.
  * **Error Handling:** A `try-catch` block is used as a general safety measure to catch any unexpected runtime exceptions, ensuring the program can report an error gracefully instead of terminating abruptly.

-----

#### **Code Structure**

The project consists of a single C\# class that contains all the logic.

**`LIVECODE_UAS_NICO.cs`**

  * **Purpose:** The main class containing the entire application logic.
  * **Static Variables:**
      * `static int ID_M`: Stores the ID of the single product.
      * `static string NAMA_M`: Stores the name of the single product.
  * **Methods:**
      * `static void Main(string[] args)`: The entry point of the program. It displays the main menu and handles user navigation.
      * `static void TAMBAH()`: Prompts the user to enter a product ID and name, validates the input, and stores the data in the static variables.
      * `static void CHECK()`: Prompts the user to enter an ID and name, then compares this input against the stored data, providing detailed feedback on whether the match is successful.

-----

#### **Project Structure**

This project is contained within a single source file. A recommended structure for a repository would be:

```
.
├── LIVECODE_UAS_NICO.cs
└── README.md
```

-----

#### **How to Run the Project**

To run this program, you need to have the [.NET SDK](https://dotnet.microsoft.com/download) installed.

1.  **Prepare File:** Make sure the `LIVECODE_UAS_NICO.cs` file is in your project directory.
2.  **Run Program:** Open your terminal or Command Prompt, navigate to the directory containing the C\# file, and run the program with the following command:
    ```sh
    dotnet run
    ```

-----

#### **Interaction Example (Console Output)**

Here is a complete walkthrough of what you will see in the console, including both successful and failed checks.

**Successful Path**
First, the user adds a product and successfully checks it.

```
=== PILIH MENU ===
1. Tambah Produk
2. Mengecek Produk
3. Keluar

Anda memilih menu : 1

Mohon isi ID : 101
Berhasil memasukkan ID : 101

Mohon isi Nama Makanan : Bakso
Berhasil memasukkan Nama Makanan : Bakso

Jadi kita ada produk Bakso dengan ID:101

=== PILIH MENU ===
1. Tambah Produk
2. Mengecek Produk
3. Keluar

Anda memilih menu : 2

Silahkan input ID : 101
Silahkan input Nama : Bakso

Sudah terdaftar!!
```

**Failed Check Scenarios**
Next, the user tries to check the product with incorrect details, demonstrating the different error messages.

  * **Scenario 1: Incorrect ID**

    ```
    === PILIH MENU ===
    ...
    Anda memilih menu : 2

    Silahkan input ID : 999
    Silahkan input Nama : Bakso

    Input ID SALAH!
    ```

  * **Scenario 2: Incorrect Name**

    ```
    === PILIH MENU ===
    ...
    Anda memilih menu : 2

    Silahkan input ID : 101
    Silahkan input Nama : Soto

    Input NAMA SALAH!
    ```

  * **Scenario 3: Both Incorrect**

    ```
    === PILIH MENU ===
    ...
    Anda memilih menu : 2

    Silahkan input ID : 999
    Silahkan input Nama : Soto

    Kedua input ID dan NAMA SALAH!
    ```

-----

#### **Important Notes and Development Potential**

  * **Data Storage Limitation:** The use of `static` variables is the most significant limitation, as it only allows one product to be stored. To expand this, the program could be refactored to use a `List<Product>` to manage multiple products.
  * **Object-Oriented Design:** The current implementation is procedural. A more robust solution would involve creating a `Product` class to encapsulate the `ID` and `Name` properties. This would be a better demonstration of Object-Oriented Programming (OOP).
  * **Improved User Experience:** The `CHECK` method contains a loop that forces the user to re-enter data until it is correct. This could be improved by performing a single check and then returning the user to the main menu.
  * **Refactoring:** The code could be further refined by creating dedicated methods for reading and validating user input to reduce repetition.
