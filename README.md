# rshell
Remote shell made in C#, blocks all known debuggers, vm's and sandboxes.
Last update: 16.1.22
<img src="https://github.com/spuqe/rshell/blob/main/rshell.jpg?" alt="RSHELL" border="0">

# Features
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

  
  # How to use?
  First of all you need to decide which version of rshell listener you're using, netcore version works with Linux and other one works on Windows.
  Open rshell client, find host IP which is encoded with base64, now you should add your own IP + port you will be listening at into it as base64 for example 
  http://127.0.0.1:1337/ = aHR0cDovLzEyNy4wLjAuMToxMzM3Lw==
  Now build the file and hope it works x)
