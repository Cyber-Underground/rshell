# rshell
Rshell is an advanced red team tool used for simulating real attacks. Rshell helps security researchers to overcome the risk of external attacks. Rshell is used by multiple major red team hacking companies to build safer and brighter future. Rshell is also used for education purposes, and is created for educational purposes only. Rshell is and should not be used for real life attacks without permission. 

<img src="https://github.com/spuqe/rshell/blob/main/rshell.jpg?" alt="RSHELL" border="0">

# How to use?
1. Open rshell client in visual studio, scroll to line 160 where you'll see "address"
2. Encode your IP address to base64 for example ```http://127.0.0.1:8080/ = aHR0cDovLzEyNy4wLjAuMTo4MDgwLw==``` MAKE SURE TO USE HTTP NOT HTTPS!
3. Build project
4. Open listener in administrator in linux using sudo or as an administrator in Windows. Use rshell-server-netcore on linux and just rshell-server for windows
5. Start listening to the port you put in the stub, in above we used port 8080 so we'll do that too.

# Features
Rshell is an open-source post-exploitation software for students, researchers, red teamers and developers. It includes features such as:


Completely evades at least the following automated malware analysis environments:
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
* Copy program to current user's Startup folder where it will be opened when Windows reboots: This command will copy the Rshell program to the Windows startup folder for the current user, so that it will automatically run when the computer is started up.

* Prompt to start application with administrator privileges: This command will prompt the user to start the Rshell program with administrator privileges, which can be necessary for some actions that require elevated privileges.

* Customize drop path for items that are dropped to disk (including downloads): This command allows the user to specify a custom location where any downloaded or dropped files will be saved on the disk.

* Optional message that appears once the application is executed: This command allows the user to set an optional message that will be displayed to the user after the Rshell program is executed.

* Send any Powershell or CMD commands to user: This command allows the user to send commands to the user's computer via Powershell or CMD, allowing for remote control of the system.

* Steals all saved passwords from many browsers (told in the previous text): This command will attempt to steal any saved passwords from the user's web browsers, which could include sensitive information such as login credentials.

* See pc information: This command will display information about the user's computer, including the operating system, hardware specs, and other details.

* Run <program> [<arguments> <working dir>]: This command allows the user to run any program on the user's computer, with optional arguments and a custom working directory.

* Anti-analysis: This command includes various features designed to evade analysis by malware analysis tools and sandboxes.

* Run any application installed on the pc: This command allows the user to run any application installed on the user's computer, without needing to know the exact path to the executable.

* See active windows: This command will display information about the currently active windows on the user's computer, including the window titles and handles.

* Download files from outside sources: This command allows the user to download files from external sources, potentially including malware or other malicious content.

* Upload files: This command allows the user to upload files from their computer to a remote server.

* Kill processes: This command allows the user to terminate any running processes on the user's computer.

* Watch network traffic: This command allows the user to monitor network traffic on the user's computer, potentially including sensitive information such as passwords or other data.

* See files in current folder: This command will display a list of files in the current directory.

* List all services: This command will display a list of all services running on the user's computer.

* Search for services: This command allows the user to search for specific services running on the user's computer.

* See installation location: This command will display the installation location of the Rshell program.

* Decrypt and Encrypt all files: This command allows the user to encrypt or decrypt any files on the user's computer.

* Take screenshots of one or both screens: This command allows the user to capture screenshots of the user's computer, either of a single screen or both screens.
--------------------------------------------------

### Tested anti malware providers:
  
| № | Name | Detected | Detection |
| --- | --- | --- | --- |
| 1 | McAfee | ❌ | 
| 2 | Microsoft Defender | ❌ | 
| 3 | Avast | ❌ | 
| 4 | F-secure | &#9989; | Heuristic.HEUR/AGEN.1203518 |
| 5 | Malwarebytes | ❌ | 
| 6 | Fortinet | ❌ | 
| 7 | BitDefender | &#9989; |  IL:Trojan.MSILZilla.23813 |
| 8 | Kaspersky | &#9989; | HEUR:Backdoor.MSIL.Agent.gen |
| 9 | NANO-Antivirus | ❌ | 
| 10 | ClamAV | ❌ | 
| 11 | AVG | ❌ | 
| 12 | Alibaba | ❌ | 
| 13 | Avira | &#9989; | HEUR/AGEN.1203518 |
| 14 | Baidu | ❌ | 
| 15 | Kingsoft | ❌ | 
| 16 | Webroot | ❌ | 
| 17 | TrendMicro | ❌ | 
| 18 | Arcabit | &#9989; | IL:Trojan.MSILZilla.D5D05 |
| 19 | Yandex | ❌ |
| 20 | NANO | ❌ | 
--------------------------------------------------

### Tested sandboxes:
  
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
| 11 | Windows Sandbox | &#9989; | 

--------------------------------------------------

### Tested browsers:

| № | Browser Name | Passwords | Cookies | History | Bookmarks |
| --- | --- | --- | --- | --- | --- |
| 1 | Chrome | &#9989; | &#9989; | &#9989; | &#9989; |
| 2 | Microsoft Edge | &#9989; | &#9989; | &#9989; | &#9989; |
| 3 | Chromium | &#9989; | &#9989; | &#9989; | &#9989; |
| 4 | Brave - Browser | &#9989; | &#9989; | &#8987; | &#8987; |
| 5 | Firefox | &#9989; | &#9989; | &#9989; | &#9989; |
| 6 | Waterfox | &#9989; | &#9989; | &#8987; | &#8987; |
| 7 | Cyberfox | &#9989; | &#9989; | &#8987; | &#8987; |
--------------------------------------------------

# Disclaimer
Rshell is a tool intended for legal and ethical purposes only, including penetration testing, red teaming, education, malware analysis, and remote system management. Any malicious use of Rshell or any other hacking tool is strictly prohibited and may result in criminal prosecution. The developer of Rshell is not responsible for any damages, losses, or legal repercussions that may result from the misuse of this tool. By using Rshell, you agree to use it only for the aforementioned purposes and assume full responsibility for your actions.

Rshell can and should only be used for:

* Penetration testing: Rshell can be used by security professionals to test the security of their own systems and identify potential vulnerabilities that could be exploited by attackers.

* Red teaming: Rshell can be used by red teams to simulate attacks on an organization's systems and identify weaknesses that need to be addressed.

* Education: Rshell can be used for educational purposes to teach students about cybersecurity and penetration testing.

* Malware analysis: Rshell can be used to test the effectiveness of malware analysis tools and techniques, by attempting to evade detection.

* Remote access: Rshell can be used by system administrators to remotely access and manage systems.
