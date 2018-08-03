$tempFolder = New-Guid
New-Item $tempFolder.ToString() -ItemType Directory
Set-Location $tempFolder.ToString()

git clone https://github.com/ChristianEder/merge-pdf.git

Set-Location merge-pdf

.merge-pdf $args

Set-Location ..
Set-Location ..

Remove-Item $tempFolder.ToString()