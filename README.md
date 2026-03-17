# Starter Unity Game

This is a game starter for teamTransRescue.
**DO NOT MERGE ALL THE BRANCHES TO MAIN in the starter repo**

This is for Unity 6.3LTS

## Making A Game 

This is a flexible starter.  We have a branch for each feature. 
These are never merged back to main. Instead, main is a simple rolling ball game. To make a starter for a real game, you just merge in the branches you need. For example, if your game uses an animated character, merge in anim

To make a game:
 * check out with all branches, change the top directory from Starter to FooGameJam or whatever
 * make a new blank repo on github for teamTransRescue/FooGameJam
 * Give access to teamGameJam in settings->collaborators and teams
 * remove (Important!) the origin remote **git remote rm origin**
 * Add the new repo as origin   **git remote add origin <url>** using the url from the new repo
 * push all branches **git push --all origin main**
 * Make a branch realize
 * Decide which branches to use. Merge those branches to realize
 * If there are things broken, fix them.
 * merge realize back to main
 * push to origin main

## The Branches

### terrain
Adds a large terrain, starter for wandering around an 'outdoors'

### animchar
Adds a humanoid character ("Amy" from mixamo) with a simple RigidBody based controller and camera controller.




