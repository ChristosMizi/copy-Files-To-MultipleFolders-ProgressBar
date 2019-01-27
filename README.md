# copy-Files-To-MultipleFolders-ProgressBar

The logic of the Tool

1) It copies the files from the Sorce folder to the subfolder called "....\Customization" of all clients and turns them Read Only.

Conditions:

1) It searches for Clients that the name of the Client starts A-Z or a-Z and the second char is ((A-Z or a-z) and (not a Number or underscore "_ "or "-") )

2) Afterward searches if these clients have a subfolder "1.Latest Client Content Folder"

3) Then searches if there is a sub folder "Answers Data" and then if there is a subfolder "Customization"

4) If all 3 previous conditions are validated then Checks if the file to be copied exists. If exists it is replaced and turned RO if not a CSV file with info is created to the user's desktop

5) The path of the destination folder should fulfill the below condition

Destination Folder path (Validation)

server\.......\CF\AllClientContentFolders

For Example for Sweden

\\Server\Company\Folder\Folder\....\AllClientContentFolders

If you try to copy files to directory(s) that not validate the  Destination Folder path Warning Message will pop up (The path is not Valid, Enter a valid path)

2) If the file to be copied was not found to the below path for example
\\Server\.....\Heineken\1. Latest Client Content Folder\My Nielsen Answers - Heineken_2018.01.08\Answers Data\Customization

A file .csv will be created that provides you with helpful info,
 - The name of the file that wasn't copied
 - Name of the Client that wasn't copied
 - The path directory that wasn't copied
3)The tool returns info in which folders (s) called  "1. Latest Client Content Folder "was found a zip file.
Because there are Clients that have a "My Nielsen Answers" zip file to the "1.Latest Client Content Folder"