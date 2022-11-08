# rshell
Remote shell made in C#, blocks all known debuggers, vm's and sandboxes.

Last update: 16.1.22

<img src="https://github.com/spuqe/rshell/blob/main/rshell.jpg?" alt="RSHELL" border="0">

# How to use?
First of all you need to decide which version of rshell listener you're using, netcore version works with Linux and other one works on Windows.
Open rshell client, find host IP which is encoded with base64, now you should add your own IP + port you will be listening at into it as base64 for example 
http://127.0.0.1:1337/ = aHR0cDovLzEyNy4wLjAuMToxMzM3Lw==
Now build the file and hope it works x)

# ToDo:
* Improve anti-vm and anti-debug systems.
* Make command handling faster.
* Add better encrypting to data transfer


# Features
Completely evades at least the following automated malware analysis environments
* Any.Run
* Intezer Analysis
* VirusTotal Jujubox
* Hybrid Analysis
* Cuckoo Sandbox
* Joe Sandbox
Can evade more and probably completely evade a lot of sites we haven't tested yet.

Completely evades other virtual machines and
sandboxing software such as:
* VMware Workstation
* Oracle VirtualBox
* Sandboxie

All other features:
* Add program to Windows startup (you can choose the key name in registry)
* Copy program to current user's Startup folder where it will be opened when Windows reboots.
* Prompt to start application with administrator privileges
* Customize drop path for items that are dropped to disk (including downloads)
* Optional message that appears once the application is executed
* Anti-analysis
* Send any Powershell or CMD commands to user
* See active windows
* Steals all saved passwords from many browsers (told in the previous text)
* see pc information
* run <program> [<arguments> <working dir>]
* Prompt to start application with administrator privileges
* Anti-analysis
* Run any application installed on the pc
* Send any Powershell or CMD commands to user
* See active windows
* Steals all saved passwords from browsers
* see pc information
* run <program> [<arguments> <working dir>]
* Sets it's self to startup
* Download files from out side sources
* Upload files
* kill processes
* Watch network traffic
* See files in current folder
* List all services
* Search for services
* See installation location
  
--------------------------------------------------

### Tested anti malware providers:
  
| № | Name | Detected |
| --- | --- | --- |
| 1 | McAfee | ❌ | 
| 2 | Microsoft Defender | ❌ | 
| 3 | Avast | ❌ | 
| 4 | F-secure | ❌ | 
| 5 | Malwarebytes | ❌ | 
| 6 | Fortinet | ❌ | 
| 7 | BitDefender | ❌ | 
| 8 | Kaspersky | ❌ | 
| 9 | NANO-Antivirus | ❌ | 
| 10 | ClamAV | ❌ | 
| 11 | AVG | ❌ | 
| 12 | Alibaba | ❌ | 
--------------------------------------------------

### Tested sandboxes
  
| № | Name | Evades |
| --- | --- | --- |
| 1 | Any.Run |  &#9989; | 
| 2 | Intezer Analysis |  &#9989; | 
| 3 | VirusTotal Jujubox |  &#9989; | 
| 4 | Hubrid Analysis |  &#9989; | 
| 6 | Joe Sandbox |  &#9989; | 
| 7 | Cuckoo Sandbox |  &#9989; | 

--------------------------------------------------

### Tested browsers:

| № | Browser Name | Passwords | Cookies | History | Bookmarks |
| --- | --- | --- | --- | --- | --- |
| 1 | Chrome | &#9989; | &#9989; | &#9989; | &#9989; |
| 2 | Microsoft Edge | &#9989; | &#9989; | &#9989; | &#9989; |
| 3 | Chromium | &#9989; | &#9989; | &#9989; | &#9989; |
| 4 | Brave - Browser | &#9989; | &#9989; | &#8987; | &#8987; |
| 5 | Epic Privacy Browser | &#9989; | &#9989; | &#8987; | &#8987; |
| 6 | Amigo | &#9989; | &#9989; | &#8987; | &#8987; |
| 7 | Vivaldi | &#9989; | &#9989; | &#8987; | &#8987; |
| 8 | Orbitum | &#9989; | &#9989; | &#8987; | &#8987; |
| 9 | Atom | &#9989; | &#9989; | &#8987; | &#8987; |
| 10 | Kometa | &#9989; | &#9989; | &#8987; | &#8987; |
| 11 | Comodo Dragon | &#9989; | &#9989; | &#8987; | &#8987; |
| 12 | Torch | &#9989; | &#9989; | &#8987; | &#8987; |
| 13 | Slimjet | &#9989; | &#9989; | &#8987; | &#8987; |
| 14 | 360Browser | &#9989; | &#9989; | &#8987; | &#8987; |
| 15 | Maxthon3 | &#9989; | &#9989; | &#8987; | &#8987; |
| 16 | K - Melon | &#9989; | &#9989; | &#8987; | &#8987; |
| 17 | Sputnik | &#9989; | &#9989; | &#8987; | &#8987; |
| 18 | Nichrome | &#9989; | &#9989; | &#8987; | &#8987; |
| 19 | CocCoc Browser | &#9989; | &#9989; | &#8987; | &#8987; |
| 20 | Uran | &#9989; | &#9989; | &#8987; | &#8987; |
| 21 | Chromodo | &#9989; | &#9989; | &#8987; | &#8987; |
| 22 | Yandex(old) | &#9989; | &#9989; | &#8987; | &#8987; |
| 23 | Firefox | &#9989; | &#9989; | &#9989; | &#9989; |
| 24 | Waterfox | &#9989; | &#9989; | &#8987; | &#8987; |
| 25 | Cyberfox | &#9989; | &#9989; | &#8987; | &#8987; |
| 26 | K - Meleon | &#9989; | &#9989; | &#8987; | &#8987; |
| 27 | Thunderbird | &#9989; | &#9989; | &#8987; | &#8987; |
| 28 | IceDragon | &#9989; | &#9989; | &#8987; | &#8987; |
| 29 | BlackHaw | &#9989; | &#9989; | &#8987; | &#8987; |
| 30 | Pale Moon | &#9989; | &#9989; | &#8987; | &#8987; |
--------------------------------------------------


# Rshell
Project Rshell is a remote control malware. For legal reasons that was a joke and it’s a remote administrator tool for private usage. Not for malicious usage x) Rshell can be used for many purposes! Not everyone is evil! Well anyways.. This docs was made to share our speed of progress and more details of the progress to education purposes later. Everything we think is important is bolded!We have also tried to add links to sources with information about stuff we talk about.

# How does it work?
So you are wondering how it works? Let me tell you!
Rshell is a remote control program. Basically you can control a computer over the internet from another computer or server.
Rshell uses many kinds of encryption to hide it’s traffic from unwanted people like Anti-virus companies. Rshell uses HTTP requests to send and receive data to do that it uses basic GET and POST requests.
Rshell only works on windows platforms but it’s listener is supported on both windows and linux. On linux you will need dotnet core and dotnet runtime installed to run it but on windows you don't need anything really. We prefer using the listener on linux based servers than on windows computer as it will be easily traceable if it’s listening on a machine you own yourself. 
The listener basicly is waiting for connections from infected machines and the listener is used to send and receive data for example commands between the server and infected computer. 
Our Anti virtual machine mechanism is actually quite simple. It’s custom and private and that’s why it doesn’t trigger Anti virus programs. We call it “Variksenpelätin” and it’s english translation is Scarecrow. We think that Variksenpelätin must be the best name for our method as it scares away everything we don’t want our program to. 
Why wouldn’t someone want their file to be runned in a virtual machine? Well good question! Virtual machines are often used to analyse malwares which usually leads to the point where the analyser reports the malware to many anti virus companies and that’s when the malware becomes detected. Well to the point! How does our anti virtual machine method work? Well it’s too hard to explain and we really don’t want to share all our secrets to the world :) but we can tell how our anti analysis mechanic works! It basically “kills” the software when a certain application is started. Our system uses XOR encryption to prevent anti virus seeing what applications our system is trying to see. Our system basically is checking every 15 seconds if an black listed application is running. For example you're using some kind of debugger application that we have black listed it will instantly kill the malware and our application starts to act like an normal software on the background. Right after the debugger is closed it will connect back to our listener again.
