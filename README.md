

# Dynamic File Indexer

A simple console program which adds an index number to all files in a folder with a specified token


### Installation

Compilation requires 

 - `Visual Studio`
 - `C#.net`
 - `Windows OS`

### Usage

This program can be ran in the console or as a normal executable. Once ran the user can direct it to a specific folder or simply hit enter to rename files in the current folder. Once ran it will look for `\n` in all files names in the given folder and replace it with a index number, i.e. `fileName\n.test\n` would become `fileName1.test1` if it was the only file in a folder. 
