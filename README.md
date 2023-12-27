# Simple-POS
This straightforward Point of Sale system is tailored for managing purchase and sale transactions, while also providing comprehensive records for suppliers and customers. Additionally, it offers tracking capabilities for stocks and facilitates monitoring of profit and loss.

<details> 
<summary>Table of Contents</summary>
  
- [About The Project](#about-the-project)
- [Built with](#built-with)
- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Setting up](#setting-up)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

</details>

## About The Project
Upon launching the project, the initial window features a menu bar at the top, housing several buttons. However, access to certain buttons is restricted until you log in.
<table>
  <tr>
    <td>Before Log In</td>
    <td>Log In Button</td>
    <td>Logging In</td>
  </tr>
  <tr>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-1.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-2.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-3.png" width="350"></td>
  </tr>
</table>

Upon successful login, the previously labeled __Log In__ button is now identified as __Log Out__, and access is granted to all other buttons.
<table>
  <tr>
    <td>"Log In" label has changed</td>
    <td>Buttons become active</td>
  </tr>
  <tr>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-4.png" width="500"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-5.png" width="500"></td>
  </tr>
</table>

Upon selecting the __Item__ button, a window will appear displaying a comprehensive list of items in stock, along with detailed information. In this interface, you have the ability to manipulate the data by creating, updating, deleting, or searching for items.
<img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-6.png">

<table>
  <tr>
    <td>Creating A New Stock</td>
    <td>Updating the data</td>
    <td>After Update</td>
  </tr>
  <tr>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-7.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-8.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-9.png" width="350"></td>
  </tr>
</table>

Searching
<table>
  <tr>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-10.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-11.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-12.png" width="350"></td>
  </tr>
</table>

Similarly, when you click on the __Supplier__ button, a window will be presented, showcasing a list of suppliers with detailed information. Within this interface, you can perform various operations such as creating, updating, deleting, or searching for supplier-related data.
<table>
  <tr>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-13.png" width="500"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-14.png" width="500"></td>
  </tr>
</table>

The functionality of the __User Setting__ button operates in a similar fashion. However, when creating or updating new users, the window prompts for passwords and allows you to specify the buttons to which the new user will have access.
<table>
  <tr>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-15.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-16.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-17.png" width="350"></td>
  </tr>
</table>

Within the __Purchase__ button, editing rows is restricted. Nevertheless, when creating a new record for a purchase from a specific supplier, you have the option to view the details of the purchase by clicking on the plus sign located on very left column.
<table>
  <tr>
    <td>Accessing Purchase Button</td>
    <td>Creating New Purchase</td>
    <td>Checking Details of the Purchase</td>
  </tr>
  <tr>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-18.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-19.png" width="350"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-20.png" width="350"></td>
  </tr>
</table>

The functionality of the __Sale__ button follows a similar pattern. When generating a new sale voucher, the __Change__ is automatically calculated based on the provided __Payment__, and likewise, the __Total__ and __Total Amount__ adjust dynamically according to the entered __SalePrice__ and __SaleQty__. Additionally, the __QtyOnHand__ is automatically populated when you press the ```Tab``` key after entering the __ItemName__.
<table>
  <tr>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-21.png" width="500"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-22.png" width="500"></td>
  </tr>
</table>

The __Item__ table will reflect changes as you purchase and sell goods, providing a dynamic overview of the updated inventory status.
<img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-23.png">

Finally, the __Profit/Loss__ button allows you to assess the profit or loss incurred within a user-selected time period. Additionally, you have the capability to filter the results based on the __ItemName__.
<table>
  <tr>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-24.png" width="500"></td>
    <td><img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-25.png" width="500"></td>
  </tr>
</table>

Upon all of this, you can exit the program using either the __Exit__ button under the __File__ menu or by clicking the close (cross) icon located at the top right corner of the window.

<img src="https://github.com/Skylar-KyiShinKhant/Simple-POS/blob/Editing-files/pos-ss/Screenshot-26.png">


## Built with
- C#
- SQL

## Getting Started
To set up a local copy, follow these straightforward steps as outlined.

## Prerequisites
To run this project, it is essential to have the **Microsoft Visual Studio** installed. Additionally, for database verification, having **SQL Server Management Studio** application would be important.

## Setting up
1. Clone the repo into the __Microsoft Visual Studio__
2. Execute SQL scripts in your __SQL Server__
3. Connect to your __Microsoft Visual Studio__ to __SQL Server__
4. Run the project

## Contributing
We love contributions — they're what make the open-source community awesome! Your ideas to improve this project are welcome. Feel free to fork the repository, submit a pull request. And of course, your support by giving the project a star would be appreciated! Thanks for being part of it!

## License
Distributed under the MIT License. See ```LICENSE.txt``` for more information.

## Contact
Name : Skylar Kyi Shin Khant

Email : kyishinkhant2003@gmail.com

Project Link : https://github.com/Skylar-KyiShinKhant/Simple-POS.git
