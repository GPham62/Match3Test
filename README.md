# Match3Test
This is the Online Test for IEC.

For part 1:
1. 3 changes can improve game performances:
- Modify the update class in BoardController, so that it doesn't call GetMouseButtonUp unecessarily, and add GamePlayState so the code flow is more understandable.
- Add GameAssets class as a singleton prefabs. The purpose of this prefab is to work as a mediator between objects and resources. As i recall the game heavily depends on Resources.Load to render View. Resources.Load will load all assets to memory, sometimes cause performance overheat and the longer the project scales, the more weights it put on memories. So we use the mediator instead to call anywhere at runtime.
- At pooling spawn instead of Instantiate. This part is unfinished, due to some bugs caused on match 3 gameplay logic when the level reset, but the purpose of this is to avoid repeatedly create and destroy objects as we play. In long term, as the level duration get higher, this solution reduces GC from creating and destroying object unity functions.
2. Scriptable Object is implemented using MatchSkin class.
3. Restart function is implemented in GameManager class.
4. Edited FillGapsWithNewItems in Board class.

the project design is using Add and Destroy Level Component at runtime. Talking about advantages, it's quick to setup and implement match 3 logic, and not really causing much bugs for an 1-week prototype project with abstract level design. It's also easy to integrate new game features. But in long terms, without proper data cleaning, unity will stack up GC and the bigger level scales (from 50-100 levels), and the more complex a level can get, more data problems arise, thus lead to the downfall of maintainability. The ideal solution is to create a seperate scene, using unity OnDestroy function to get rid of all unused variables and references. This also reduces the amount of UI objects in canvas, lead to more compact UI design. We can also use prefabs for panel popup such as GameOver and Pause to avoid leaving unused resources in scene. We could also put all the managers class in preload scene using RuntimeInitializeOnLoadMethod to avoid unecessary race call in awake.
