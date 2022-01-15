# rshell
Remote shell made in C#, blocks all known debuggers, vm's and sandboxes.

<img src="https://github.com/spuqe/rshell/blob/main/rshell.jpg?" alt="RSHELL" border="0">

# Features
Updated: 24.12.2020
Not all commands are listed here!
* Prompt to start application with administrator privileges
* Anti-analysis
* Run any application on pc
* Send any Powershell or CMD commands to user
* See active windows
* Steals all saved passwords from many browsers
* see pc information
* run <program> [<arguments> <working dir>]
* Sets it's self to startup
  # How to use?
  Requirements: some knowledge is always good + visual studio
  
  
  # How to use?
  First of all you need to decide which version of rshell listener you're using, netcore version works with Linux and other one works on Windows.
  Open rshell client, find host IP which is encoded with base64, now you should add your own IP + port you will be listening at into it as base64 for example 
  http://127.0.0.1:1337/ = aHR0cDovLzEyNy4wLjAuMToxMzM3Lw==
  Now build the file and hope it works x)
