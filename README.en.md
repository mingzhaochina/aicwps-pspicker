# AICWPS-PSPicker

#### Description
Introduction
P and S phase picking software based on PhaseNet.

Installation tutorial

Instructions for use
log in:
This part is mainly used as the login interface of the system. The user needs to fill in the user name and password in the pop-up window, and select the version (stand-alone/networked) and language (Chinese/English) of the system.
For users using the online version of the system, you need to click the "Settings" button to set the server's IP address and other information.
Server settings:
When users use the networked version of the system, they need to install the docker environment on the server side and import the corresponding version of the image, then the calculation process can be completed on the server side, and the system only needs to communicate with the server. In this module, the user can set the server's IP address, local IP address, server user name and password and other information.
Main interface:
The main interface of the program is the medium for information interaction between the system and the user. The user can perform various operations in the main interface. The main interface also builds a framework for algorithm setting, file selection, result output, drawing pictures and other modules. These modules Fill in the main interface in the form of sub-pages to make the program look more tidy and beautiful.
Algorithm settings:
In the algorithm setting page, users can set the probability threshold, operating equipment (including cpu, gpu, FPGA), whether to enable multi-threading, and output file format (including csv, json, jopens) according to their needs. These parameters will be saved in the instructions and sent to docker for processing when the user finishes adding the file.
For the stand-alone system, the user needs to set up a shared folder in the docker installed on the computer in advance for file interaction with the system, and set the shared folder directory on the system page.
File selection:
After the algorithm is set, click "Add" to enter the file selection page. The file formats supported by the system are mseed, sac, npz, and it supports the selection of single, multiple files and folders, and the added files will be displayed in the form.
For the stand-alone system, the system will copy the files in the selected directory to the shared folder and wait for calculation. For the online version of the system, the system connects to the server, sends the files in the selected directory to the server folder, and waits for the next instruction of the system.
Result output:
When the user clicks "start", the system will send the corresponding control instructions and call docker to calculate all the files in the input folder. For stand-alone systems, the system will copy the output results to the output folder.
For the online version system, the system will connect to the server and download the results to the output folder.
Drawing result:
After the user completes the calculation, click on "Chart", and the system will display a picture of the calculation result in the window. The drawing of the picture is done by calling docker on the server side. For the stand-alone system, the system will copy the output picture to the output folder and retrieve the corresponding serial number and display it in the form.
For the online version system, the system will connect to the server and download the pictures corresponding to the serial number to the output folder and display them in the window

#### Software Architecture

According to the requirements of continuous seismic waveform processing, the Institute of Geophysics, China Earthquake Administration, based on the tensorflow platform and Intel’s OpenVINO™ tool suite, completed the optimization and inference engine construction of the U-net seismic phase automatic detection and time pickup model, and used docker containers. Technology for cloud or server-side deployment, and based on C# and .NET framework 4.0, a stand-alone version and a server version of Windows client interactive applications have been developed according to the needs of different users, allowing users to deploy docker deep learning services on their local computers at the same time And install the corresponding client application, you can also deploy the docker deep learning service on the cloud or another server with stronger computing power, and install a customer service application that can interact with the server and users locally.

#### Installation

Open the install directory.
Click Setup.msi or Setup.exe to install.
Note that the installation path should not be saved on the C drive.

1.  xxxx
2.  xxxx
3.  xxxx

#### Instructions

1.  xxxx
2.  xxxx
3.  xxxx

#### Contribution

1.  Fork the repository
2.  Create Feat_xxx branch
3.  Commit your code
4.  Create Pull Request


#### Gitee Feature

1.  You can use Readme\_XXX.md to support different languages, such as Readme\_en.md, Readme\_zh.md
2.  Gitee blog [blog.gitee.com](https://blog.gitee.com)
3.  Explore open source project [https://gitee.com/explore](https://gitee.com/explore)
4.  The most valuable open source project [GVP](https://gitee.com/gvp)
5.  The manual of Gitee [https://gitee.com/help](https://gitee.com/help)
6.  The most popular members  [https://gitee.com/gitee-stars/](https://gitee.com/gitee-stars/)
