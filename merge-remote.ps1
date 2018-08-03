$tempFolder = New-Guid
$ignore = New-Item $tempFolder.ToString() -ItemType Directory
$ignore = Set-Location $tempFolder.ToString()

$ignore = git clone https://github.com/ChristianEder/merge-pdf.git -q

$ignore = Set-Location merge-pdf

.\merge.ps1 "..\.." "..\..\out.pdf" 

$ignore = Set-Location ..
$ignore = Set-Location ..

$ignore = Remove-Item $tempFolder.ToString() -Recurse -Force