# merge-pdf

This tool lets you merge multiple PDF files into a single file.

There are two ways to execute it:

* Clone this repo, open a PowerShell and call  .\merge.ps1 "path\to\source\pdfs" "path\to\output.pdf" 
* Open a PowerShell in the folder where your source PDFs are located, and call 
  ```
  . { iwr -useb https://raw.githubusercontent.com/ChristianEder/merge-pdf/master/merge-remote.ps1 -Headers @{"Cache-Control"="no-cache"} } | iex;
  ```
  * this will create a "output.pdf" file in the current directory
  * this requires Set-ExecutionPolicy -ExecutionPolicy Unrestricted

Currently, the tool will merge all the files in the given directory in alphabetical order. Pull requests that allow to pass in arguments to the script are welcome :-)
 
