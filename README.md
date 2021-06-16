# Select Case Generator
A program to assist building Visual Basic .Net code for a Select Case of resource files against reference string.
<br><br>
### UI
* **Directory** - Directory path to resource files.
* **Load** - Populate list with files in directory.
* **Save** - Generate Select Case and save to your clipboard. Enter a variable to use with select (eg Select Case variable).
* **List** - 'Resource' is the file name. 'Reference' is case string (eg Case "string"). Double click a row to check the 'Else' column to set that resource as the Else case (eg Case Else). Select a row to set its reference.
* **Edit** - You can edit the reference string in the 'Reference' text box. Press enter to set and move to next item.

Only resources that have been given a reference or checked in 'Else' column will be included in generation. Resources checked as 'Else' do not need a reference. You can drop a selection of files (only the files will be loaded), or a folder to load the containing files.

### Output Example

Files = Dir-N.png, Dir-E.png, Dir-S.png, Dir-W.png, Dir-None.png<br>
Select variable = direction
```vbnet
Select Case direction
  Case "North"
    Return My.Resources.Dir_N
  Case "East"
    Return My.Resources.Dir_E
  Case "South"
    Return My.Resources.Dir_S
  Case "West"
    Return My.Resources.Dir_W
  Case Else
    Return My.Resources.Dir_None
End Select
```
