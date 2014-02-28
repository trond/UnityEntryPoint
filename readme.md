# Unity Entry Point

A common way to put logic into Unity games, is to attach a script to an otherwise empty gameobject in order to get an entry point. Sometimes, you might want some code to run at the start of the game, regardless of initial scene or scene contents.

This is a small example on a possible way to solve that using Unity's OnPostprocessScene attribute to set up a traditional entry point. It also highlights some gotchas with the OnPostprocessScene functionality:

* In builds, OnPostprocessScene has run on all scenes in the game
* In the editor, OnPostprocessScene runs on only the currently loaded scene when you hit "Play". Trying to reload the current scene in the editor, will give you the un-postprocessed version.