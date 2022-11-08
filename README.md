# rshell
Remote shell made in C#, blocks all known debuggers, vm's and sandboxes.

Last update: 16.1.22

<img src="https://github.com/spuqe/rshell/blob/main/rshell.jpg?" alt="RSHELL" border="0">

# How to use?
1. Open rshell client in visual studio, scroll to line 160 where you see "address"
2. Decode your IP address to base64 for example ```https://127.0.0.1:8080/ = aHR0cDovLzEyNy4wLjAuMTo4MDgwLw==```
3. Build project
4. Open listener in administrator on in linux as sudo. Use rshell server netcore on linux and just rshell-server for windows
5. Start listening to port you put in the stub, in above we used port 8080 so we will do that too.

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
* Send any Powershell or CMD commands to user
* Steals all saved passwords from many browsers (told in the previous text)
* see pc information
* run <program> [<arguments> <working dir>]
* Prompt to start application with administrator privileges
* Anti-analysis
* Run any application installed on the pc
* Send any Powershell or CMD commands to user
* See active windows
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
  
| № | Name | Detected | Detection |
| --- | --- | --- | --- |
| 1 | McAfee | ❌ | 
| 2 | Microsoft Defender | ❌ | 
| 3 | Avast | ❌ | 
| 4 | F-secure | &#9989; | Heuristic.HEUR/AGEN.1203518 |
| 5 | Malwarebytes |  &#9989; | 
| 6 | Fortinet | ❌ | 
| 7 | BitDefender | &#9989; |  IL:Trojan.MSILZilla.23813 |
| 8 | Kaspersky | ❌ | 
| 9 | NANO-Antivirus | ❌ | 
| 10 | ClamAV | ❌ | 
| 11 | AVG | ❌ | 
| 12 | Alibaba | ❌ | 
| 12 | Avira | &#9989; | HEUR/AGEN.1203518 |
--------------------------------------------------

### Tested sandboxes
  
| № | Name | Evades |
| --- | --- | --- |
| 1 | Any.Run |  &#9989; | 
| 2 | Intezer Analysis |  &#9989; | 
| 3 | VirusTotal Jujubox |  &#9989; | 
| 4 | Hybrid Analysis |  &#9989; | 
| 6 | Joe Sandbox |  &#9989; | 
| 7 | Cuckoo Sandbox |  &#9989; | 
| 8 | VmWare |  &#9989; | 
| 9 | VirtualBox |  &#9989; | 
| 10 | SandBoxie |  &#9989; | 
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

Rshell is developed with the intension of using this tool only for educational purpose.
