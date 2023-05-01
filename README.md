# PlayMaker-Match3

This is an old project of mine, showing how to create Match-3 game using Unity & Playmaker.

How to open:
Upon cloning, there will be a bunch of errors, this is because the project doesn't have Playmaker in it,
So just import the Playmaker asset, go to "PlayMaker/Editor/Install" folder, select one of the PM package
with the suitable version, install it.

After installing PM, the errors should gone, but if there are a bunch of errors when running the scene like below:
```
The referenced script on this Behaviour (Game Object 'Cube_Bounce') is missing!
```
Then try to inspect the game object, search for the missing component, and try to re-link it, 
by type "PlaymakerFSM" in the filter when re-linking the script and select the 
one with "Plugins/Playmaker/Playmaker.dll" as the path
