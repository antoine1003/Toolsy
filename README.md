<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/antoine1003/toolsy">
    <img src="Images/icon256.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Toolsy</h3>

  <p align="center">
    An app to facilitate your repeated tasks.
    <br />
    <a href="https://github.com/antoine1003/toolsy"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/antoine1003/toolsy/issues">Report Bug</a>
    ·
    <a href="https://github.com/antoine1003/toolsy/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

[![Toolsy screenshot][product-screenshot]](Images/screenshot1.png)

As a developer I was tired of doing the same things over and over again: opening the same web pages, running the same commands or going to the same folders.

Toolsy is a small application that allows you to group all your regular actions in one place.

<p align="right">(<a href="#top">back to top</a>)</p>



### Built With


* [WPF](https://docs.microsoft.com/fr-fr/visualstudio/designers/getting-started-with-wpf?view=vs-2022)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Installation

To get started it's pretty simple: download the last [release](https://github.com/antoine1003/toolsy/releases) and install it.


<!-- USAGE EXAMPLES -->
## Usage

The app will use a JSON properly formatted to display tiles. Bellow is an example of a valid json file:

```json
[{
  "name":"JIRA",
  "type":"link",
  "value":"https://jira.mycompany.com"
},{
  "name":"Open project folder",
  "type":"folder",
  "value": "C:\\Users\\Username\\Projects",
  "description":"Open project folder"
},{
  "name":"Links GitHub",
  "type":"link",
  "value": ["https://www.jsonschemavalidator.net/","https://www.jsonschemavalidator.net/"],
  "description":"Multiple links opening"
},{
  "name":"Run bump_git.bat",
  "type":"file",
  "value": "C:\\Users\\Username\\Scripts\\bump_git.bat",
  "description":"Run file bump_git.bat"
}]
```

A JSON object can hacve 4 keys :

- `name`: _required_ Displayed name on the tile. *Should be unique !*
- `type`: _required_ Type of the action. Can be :
  - `link`: Open link or array of link in the default browser
  - `file`: Open path or array of path in explorer
  - `folder`: Open file or array of file in the default associated app.
- `value`: _required_ string are array of string
- `description`: _optional_ Show as tile's tooltip


Once you JSON is ready :

1. Open Toolsy
2. Click on the COG icon to access settings page
3. Select you JSON file and click `Save`
4. Click the refresh icon to display your tiles

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes using [Gitmoji](https://gitmoji.dev/) (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/antoine1003/toolsy.svg?style=for-the-badge
[contributors-url]: https://github.com/antoine1003/toolsy/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/antoine1003/toolsy.svg?style=for-the-badge
[forks-url]: https://github.com/antoine1003/toolsy/network/members
[stars-shield]: https://img.shields.io/github/stars/antoine1003/toolsy.svg?style=for-the-badge
[stars-url]: https://github.com/antoine1003/toolsy/stargazers
[issues-shield]: https://img.shields.io/github/issues/antoine1003/toolsy.svg?style=for-the-badge
[issues-url]: https://github.com/antoine1003/toolsy/issues
[license-shield]: https://img.shields.io/github/license/antoine1003/toolsy.svg?style=for-the-badge
[license-url]: https://github.com/antoine1003/toolsy/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/antoine-dautry
[product-screenshot]: Images/screenshot1.png