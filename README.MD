# Ultimate Unity Project Structure

To keep your projects consistent and your life hassle-free, you should always organize your Unity projects in the same way.
To do that, i've created a folder structure which is easy and fast to understand, and can be nested infinitely*.

**Please don't nest things infinitely, it's not a good idea.*

Attached is a sample repo with a proposed .gitignore. Keep in mind that this is a *sample*, and not a bare repo to clone and start your project off of. You probably don't even need half of the folders that are there. Learn by practice ;)

This project has been created using Unity 2018.3.6f1.

### Guidelines:
- All of your content should be stored in a folder that is placed inside the Assets folder and is named with the project's codename **preceeded by an underscore**. This makes sure that your folder is always at the top of the folder structure, and you have easy and quick access to it. This folder will be now referred to as the *project root folder*.
(It also makes sure that no asset  store assets can screw up your folder structure and/or content, which can happen - asset store downloads are often hit or miss.)
- Generally, leave the root of the Assets folder blank aside from the project root folder, and other folders that have to be at the top of the structure, such as 'Streaming Assets' or 'Resources'
- Store assets in asset-specific folders. Materials should be in folders called 'Materials', Prefabs in 'Prefabs', Scripts in 'Scripts', and never elsewhere.
- For smaller projects (e.g. mobile games, 'single scene' games, demos etc.) the project should immediately have asset-specific folders in the root project folder.
- For larger projects and wherever needed the structure can be grouped into 'General' folder and content-specific folders (i.e. treat General as miscellaneous folders which have the content that does not fit into others, but when you start having 10's of weapons, all with different behaviour scripts and prefabs it may be time to create a 'Weapons' folder beside the 'General' with its own Prefabs, Scripts, Models etc.).
- Content-specific folders can repeat the asset-specific folder structure as long as possible (e.g. a Bow prefab can have a Materials, Textures, Scripts etc. folders).
- Decide on a single model import format *(I recommend FBX)*, and stick to it. Keep all other formats in their separate folders. That way you can keep names without annoying prefixes and suffixes when exporting, but also instantly know which format you're dragging onto the scene.
- Editor scripts should be placed in an Editor folder placed alongside the scripts it will regard.
- **Don't create folders you don't need.** This only creates confusion.
- Remember - these are only guidelines, and you should use them as such. Don't take them as a hard set of rules - they can, and should be adjusted to your specific use cases. 
*But please don't be messy*

### Sample project structure:

**Assets:**
- _project_name
  - Materials
  - Models
  - Prefabs
    - Bow
      - *Bow.prefab*
      - Models
        - *bow.fbx*
        - blend
          - *bow.blend*
      - Textures
      - Scripts
      - Variants
        - *Bow_Powerful.prefab*
        - *Bow_Weak.prefab*
    - Dummy 
  - Scenes
  - Scripts
  - Textures

You get the idea.

Contributions
----
Feel free to contribute, open pull requests, issues, etc.
I don't promise i  will check them often though.

License
----

MIT
