# Team Trans Rescue Ludum Dare 59 Entry Game

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
 
## Credits
 
 "Amy" character and some animations courtesy Mixamo, (c) Adobe Inc.
 
 Palm trees modified from tree by chrisrossx on Sketchfab.
 
 Pseudo-Arabic fonts from dafonts.com

## The Branches

### terrain
Adds a large terrain, starter for wandering around an 'outdoors'

### animchar
Adds a humanoid character ("Amy" from mixamo) with a simple RigidBody based controller and camera controller.

### morocco
Adds a set of assets suitable for a cartoony version of Morocco.

Style guide - 
 * Make each character by composing multiples of a single shape. Eg. if you choose spheres, all spheres.
 * Triangular or tetrahedral characters are "dangerous" or "edgy" - the femme fatale, the conventional villain, the wild animal
 * trapezoid characters are authority figures - the Pasha, the priest, the woman in charge of the house. Round off the edges. If the aspect ratio is extreme, the character is an outsider - a trans person, a heretic.
 * Square characters are "solid" - grandma, Omar the cattle driver.  Round off the edges.
 * Spherical characters are friendly or loving or cute. The goofy joking talking camel, Abbas the loveable sidekick, Khadija the friendly veggie seller.
 * Prolate spheres and tall thin characters are sad sacks, peasants, the masses, or doofy characters.

Characters are Arabs, Berbers, or Turks. This is a distortion/simplification.
* Arab males wear a cartoonishly large turban and plain colored Djellaba
* Berber males wear a patterned, often blue w/white trim djebella. In town they wear a brimless cylindrical cap with 'tails' in the back, gold (use warm yellow). In the desert they wear a head covering that just shows eyes and has a large turban. 
* Turk males wear a different shaped robe (TBD) and a fez.

* Female characters wear a skirt and a patterned close fitting upper body covering in a matching color and have a drape down the back, similar to a saree - the traditional dress is too complex for a character.
Female characters wear a head covering that doesn't completely cover hair.

Prefer solid colors over image textures. 

Use very simple forms

Apply a lattice modifier to buildings, carts, etc for a cartoony look

Use an earth tones palette.

Buildings are milk chocolate. Walls have a very rough texture. Apply a white noise normal map. Round the corners of walls.  Floor plans are often square and small buildings are more often multi-story than in Europe.
Buildings are often built on the roof creating 'pile of boxes'. Buildings have a cube module. Walls have a slight but noticable batter.

Windows are simple portrait aspect 'holes', small frameless windows. Many doors and some windows are set into a stepped 'arab' alcove. There are sometimes a series of alcoves under the eaves or occupying the entire side of the building. Some walls have a grid of vent/firing holes at about 2 meter intervals

Eaves are small and there is rarely a parapet. Sometimes instead there may be regularly spaced chimney pots. If there's a parapet, a wooden trough extends a meter or so out from scuppers to channel runoff. Roofs are flat. 

Doors are panel construction, or a plain rectangle the aspect of the opening. If a door has a handle, the building has an interior and can be entered by the player. Prefabs should handle door motion unless needed by game play. Doors should have an origin at bottom on the hinge side. Openable doors should be rigidbody and rotate on a Unity Hinge joint with a spring to  close them. There should be a script that controls if the door is locked, which should interact with Unity Behavior Trees.

Stairs should have a ramp collision object.


## Exporting characters from blender

Build character on mixamo skeleton








