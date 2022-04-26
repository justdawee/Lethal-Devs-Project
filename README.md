<div id="top"></div>

![GitHub contributors](https://img.shields.io/github/contributors-anon/justdawee/Lethal-Devs-Project?style=for-the-badge)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/justdawee/Lethal-Devs-Project?style=for-the-badge)
![GitHub last commit](https://img.shields.io/github/last-commit/JustDawee/Lethal-Devs-Project?style=for-the-badge)
![GitHub issues](https://img.shields.io/github/issues/justdawee/Lethal-Devs-Project?style=for-the-badge)
![GitHub Repo stars](https://img.shields.io/github/stars/justdawee/Lethal-Devs-Project?style=for-the-badge)
![GitHub](https://img.shields.io/github/license/justdawee/Lethal-Devs-Project?style=for-the-badge)
![Website](https://img.shields.io/website?down_color=lightgrey&down_message=offline&style=for-the-badge&up_color=green&up_message=online&url=http%3A%2F%2Fjustdawee.com%2F)
![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)
![CSharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![HTML](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)
![PHP](https://img.shields.io/badge/PHP-777BB4?style=for-the-badge&logo=php&logoColor=white)
![MariaDB](https://img.shields.io/badge/MariaDB-003545?style=for-the-badge&logo=mariadb&logoColor=white)

<br />
<div align="center">
  <a href="https://github.com/justdawee/Lethal-Devs-Project">
    <img src="VMS-Admin/Lethal Devs Project/Resources/caricon.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Vehicle Management System</h3>

  <p align="center">
    This is a Vehicle Database where you can add your vehicles, and get some statistics about them.
    <br />
    <a href="https://github.com/justdawee/Lethal-Devs-Project/Docs/Dokumentacio.pdf"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/justdawee/Lethal-Devs-Project">View Demo</a>
    ·
    <a href="https://github.com/justdawee/Lethal-Devs-Project/issues">Report Bug</a>
    ·
    <a href="https://github.com/justdawee/Lethal-Devs-Project/issues">Request Feature</a>
  </p>
</div>


## About The Project

![VMS-LethalDevs](https://i.imgur.com/0EbdBVN.png)

<i>This project is made for my school project, the program is a random idea. I like cars so I thought why not I make an app where you can store vehicles and data related to them. Thats how the Vehicle Management System comes from. This app builds from a Desktop Application that is made in C# (Windows Forms Application), in there you can manage the database line an Admin UI. The main app is a webpage where users can register, login and add their vehicles to the database. The user can only see vehicles added by itself, cant see every records. That's it unfortunately... If I had more time, I make it more complex or better... :) </i>

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

To use this application, you will need several things...
At first, you will need a Webserver and a MySQL server, I recommend XAMPP for this purpose, but you can use any web service out there.
After you installed the web+sql server, you need to setup the webfiles and mysql database.
Add files from VMS-Web to your webserver htdocs folder, and after that, import the included database file what you can find in VMS-SQL.
If these are done, basically you can use the software, but if you want to manage it from the Windows Application, you need to do some other things.
At first, download the latest relase from the repository, and install the required dependencies.

For further info follow Installation steps below...

### Prerequisites

Apache/Nginx <br>
PHP 7.4.29 or higher <br>
MySQL/MariaDB <br>
<a href="https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472">.NET Framework 4.7.2</a> (Desktop App)<br>
<a href="https://www.apachefriends.org/hu/download.html">XAMPP</a> (optional webserver)<br>

### Installation

1. Install Prerequisites
2. Clone the repo
   ```sh
   git clone https://github.com/justdawee/Lethal-Devs-Project.git
   ```
3. Put files from VMS-Web
   ```
   Copy VMS-Web files to your htdocs folder.
   ```
4. Setup MySQL Database
   ```
   Go to phpmyadmin and create a database 'vms_lethaldevs' or preffered name.
   Then import the included .sql file. You can find it in VMS-SQL folder.
   ```
5. Check config files
   ```
   Check data in config.php, if data does not match with yours, change it.
   ```
6. Desktop app setup
   ```
   Download the desktop app from relases, if success follow next steps.
   ```
7. Change default MySQL settings
   ```
   Go to app directory and find 'Lethal Devs Project.exe.config' and edit it with text editor.
   Inside the file, search <Lethal_Devs_Project.Properties.Settings>
   and below that line, you will find the default MySQL settings.
   Change them according to your mysql server data.
   Save file.
   ```
8. Start Desktop App
   ```
   If the MySQL connection settings are correct, you should login with your account.
   You can only login in the Desktop app if you are an Admin, you can make yourself admin by changing
   the field in the 'users' table in mysql, find your record and change 'admin' entry from 0 to 1.
   After that you should login without any issues.
   ```
9. Done
   ```
   The desktop app is independent of the web app, it made only for admin purpose.
   If you have any issue, write one in the issues section. Thhanks.
   Enjoy.
   ```
<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Use this space to show useful examples of how a project can be used. Additional screenshots, code examples and demos work well in this space. You may also link to more resources.

_For more examples, please refer to the [Documentation](https://example.com)_

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [ ] Feature 1
- [ ] Feature 2
- [ ] Feature 3
    - [ ] Nested Feature

See the [open issues](https://github.com/github_username/repo_name/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Your Name - [@twitter_handle](https://twitter.com/twitter_handle) - email@email_client.com

Project Link: [https://github.com/github_username/repo_name](https://github.com/github_username/repo_name)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* []()
* []()
* []()

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/github_username/repo_name.svg?style=for-the-badge
[contributors-url]: https://github.com/github_username/repo_name/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/github_username/repo_name.svg?style=for-the-badge
[forks-url]: https://github.com/github_username/repo_name/network/members
[stars-shield]: https://img.shields.io/github/stars/github_username/repo_name.svg?style=for-the-badge
[stars-url]: https://github.com/github_username/repo_name/stargazers
[issues-shield]: https://img.shields.io/github/issues/github_username/repo_name.svg?style=for-the-badge
[issues-url]: https://github.com/github_username/repo_name/issues
[license-shield]: https://img.shields.io/github/license/github_username/repo_name.svg?style=for-the-badge
[license-url]: https://github.com/github_username/repo_name/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/linkedin_username
[product-screenshot]: images/screenshot.png
