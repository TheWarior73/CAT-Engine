<a name='assembly'></a>
# CAT Engine

## Contents

- [ChunkNotFoundException](#T-CAT_Engine-Core-Tiles-Exceptions-ChunkNotFoundException 'CAT_Engine.Core.Tiles.Exceptions.ChunkNotFoundException')
- [ELogVerbosity](#T-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity')
  - [Display](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Display 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Display')
  - [Error](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Error 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Error')
  - [Fatal](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Fatal 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Fatal')
  - [Log](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Log 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Log')
  - [Verbose](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Verbose 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Verbose')
  - [VeryVerbose](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-VeryVerbose 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.VeryVerbose')
  - [Warning](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Warning 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Warning')
- [InputManager](#T-CAT_Engine-Core-Input-InputManager 'CAT_Engine.Core.Input.InputManager')
  - [#ctor()](#M-CAT_Engine-Core-Input-InputManager-#ctor 'CAT_Engine.Core.Input.InputManager.#ctor')
  - [AddActionMapping(ActionName,ActionKeybind)](#M-CAT_Engine-Core-Input-InputManager-AddActionMapping-System-String,CAT_Engine-Core-Input-InputChord[]- 'CAT_Engine.Core.Input.InputManager.AddActionMapping(System.String,CAT_Engine.Core.Input.InputChord[])')
  - [AddAxisMapping(AxisName,AxisKeybind)](#M-CAT_Engine-Core-Input-InputManager-AddAxisMapping-System-String,CAT_Engine-Core-Input-Axis- 'CAT_Engine.Core.Input.InputManager.AddAxisMapping(System.String,CAT_Engine.Core.Input.Axis)')
  - [GetActionMapping(ActionName)](#M-CAT_Engine-Core-Input-InputManager-GetActionMapping-System-String- 'CAT_Engine.Core.Input.InputManager.GetActionMapping(System.String)')
  - [GetAxisMapping(AxisName)](#M-CAT_Engine-Core-Input-InputManager-GetAxisMapping-System-String- 'CAT_Engine.Core.Input.InputManager.GetAxisMapping(System.String)')
  - [IsKeyHeld(key)](#M-CAT_Engine-Core-Input-InputManager-IsKeyHeld-Microsoft-Xna-Framework-Input-Keys- 'CAT_Engine.Core.Input.InputManager.IsKeyHeld(Microsoft.Xna.Framework.Input.Keys)')
  - [IsKeyPressed(key)](#M-CAT_Engine-Core-Input-InputManager-IsKeyPressed-Microsoft-Xna-Framework-Input-Keys- 'CAT_Engine.Core.Input.InputManager.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys)')
  - [IsKeyReleased(key)](#M-CAT_Engine-Core-Input-InputManager-IsKeyReleased-Microsoft-Xna-Framework-Input-Keys- 'CAT_Engine.Core.Input.InputManager.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys)')
  - [RebindActionMapping(ActionName,newKey,keyIndex)](#M-CAT_Engine-Core-Input-InputManager-RebindActionMapping-System-String,CAT_Engine-Core-Input-InputChord,System-Int32- 'CAT_Engine.Core.Input.InputManager.RebindActionMapping(System.String,CAT_Engine.Core.Input.InputChord,System.Int32)')
  - [RebindActionMapping(ActionName,newKeys)](#M-CAT_Engine-Core-Input-InputManager-RebindActionMapping-System-String,CAT_Engine-Core-Input-InputChord[]- 'CAT_Engine.Core.Input.InputManager.RebindActionMapping(System.String,CAT_Engine.Core.Input.InputChord[])')
  - [RebindAxisMapping(AxisName,newKey,keyIndex)](#M-CAT_Engine-Core-Input-InputManager-RebindAxisMapping-System-String,CAT_Engine-Core-Input-InputChord,System-Int32- 'CAT_Engine.Core.Input.InputManager.RebindAxisMapping(System.String,CAT_Engine.Core.Input.InputChord,System.Int32)')
  - [RebindAxisMapping(AxisName,newKeys)](#M-CAT_Engine-Core-Input-InputManager-RebindAxisMapping-System-String,CAT_Engine-Core-Input-InputChord[]- 'CAT_Engine.Core.Input.InputManager.RebindAxisMapping(System.String,CAT_Engine.Core.Input.InputChord[])')
  - [RemoveActionMapping(ActionName)](#M-CAT_Engine-Core-Input-InputManager-RemoveActionMapping-System-String- 'CAT_Engine.Core.Input.InputManager.RemoveActionMapping(System.String)')
  - [RemoveAxisMapping(AxisName)](#M-CAT_Engine-Core-Input-InputManager-RemoveAxisMapping-System-String- 'CAT_Engine.Core.Input.InputManager.RemoveAxisMapping(System.String)')
  - [Update(delta)](#M-CAT_Engine-Core-Input-InputManager-Update-System-Single- 'CAT_Engine.Core.Input.InputManager.Update(System.Single)')
- [IntVector2](#T-CAT_Engine-Core-Utility-IntVector2 'CAT_Engine.Core.Utility.IntVector2')
  - [GetHashCode()](#M-CAT_Engine-Core-Utility-IntVector2-GetHashCode 'CAT_Engine.Core.Utility.IntVector2.GetHashCode')
  - [Zero()](#M-CAT_Engine-Core-Utility-IntVector2-Zero 'CAT_Engine.Core.Utility.IntVector2.Zero')
- [IntVector3](#T-CAT_Engine-Core-Utility-IntVector3 'CAT_Engine.Core.Utility.IntVector3')
  - [GetHashCode()](#M-CAT_Engine-Core-Utility-IntVector3-GetHashCode 'CAT_Engine.Core.Utility.IntVector3.GetHashCode')
  - [Zero()](#M-CAT_Engine-Core-Utility-IntVector3-Zero 'CAT_Engine.Core.Utility.IntVector3.Zero')
- [IsoCamera](#T-CAT_Engine-Core-Rendering-IsoCamera 'CAT_Engine.Core.Rendering.IsoCamera')
- [IsoGame](#T-CAT_Engine-IsoGame 'CAT_Engine.IsoGame')
  - [OnAssetManagerReady()](#M-CAT_Engine-IsoGame-OnAssetManagerReady 'CAT_Engine.IsoGame.OnAssetManagerReady')
  - [OnInitializeGame()](#M-CAT_Engine-IsoGame-OnInitializeGame 'CAT_Engine.IsoGame.OnInitializeGame')
  - [OnInitializeWindow(Window)](#M-CAT_Engine-IsoGame-OnInitializeWindow-Microsoft-Xna-Framework-GameWindow- 'CAT_Engine.IsoGame.OnInitializeWindow(Microsoft.Xna.Framework.GameWindow)')
  - [OnUpdate(delta)](#M-CAT_Engine-IsoGame-OnUpdate-System-Single- 'CAT_Engine.IsoGame.OnUpdate(System.Single)')
- [IsoLogger](#T-CAT_Engine-Core-Debug-IsoLogger 'CAT_Engine.Core.Debug.IsoLogger')
  - [Assert(condition,format,args)](#M-CAT_Engine-Core-Debug-IsoLogger-Assert-System-Boolean,System-String,System-String,System-String,System-Int32,System-Object[]- 'CAT_Engine.Core.Debug.IsoLogger.Assert(System.Boolean,System.String,System.String,System.String,System.Int32,System.Object[])')
  - [Except(format,args)](#M-CAT_Engine-Core-Debug-IsoLogger-Except-System-String,System-Object[]- 'CAT_Engine.Core.Debug.IsoLogger.Except(System.String,System.Object[])')
  - [Log(format,verbosity,args)](#M-CAT_Engine-Core-Debug-IsoLogger-Log-System-String,CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity,System-Object[]- 'CAT_Engine.Core.Debug.IsoLogger.Log(System.String,CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity,System.Object[])')
  - [Log()](#M-CAT_Engine-Core-Debug-IsoLogger-Log-System-String,System-Object[]- 'CAT_Engine.Core.Debug.IsoLogger.Log(System.String,System.Object[])')
- [IsoProfileStat](#T-CAT_Engine-Core-Debug-Profiling-IsoProfileStat 'CAT_Engine.Core.Debug.Profiling.IsoProfileStat')
- [IsoProfiler](#T-CAT_Engine-Core-Debug-Profiling-IsoProfiler 'CAT_Engine.Core.Debug.Profiling.IsoProfiler')
  - [Reset()](#M-CAT_Engine-Core-Debug-Profiling-IsoProfiler-Reset 'CAT_Engine.Core.Debug.Profiling.IsoProfiler.Reset')
- [IsoRenderContextBuilder](#T-CAT_Engine-Core-Rendering-IsoRenderContextBuilder 'CAT_Engine.Core.Rendering.IsoRenderContextBuilder')
  - [Build()](#M-CAT_Engine-Core-Rendering-IsoRenderContextBuilder-Build 'CAT_Engine.Core.Rendering.IsoRenderContextBuilder.Build')
- [IsoRenderableTileComponentInterface](#T-CAT_Engine-Core-Tiles-Interfaces-IsoRenderableTileComponentInterface 'CAT_Engine.Core.Tiles.Interfaces.IsoRenderableTileComponentInterface')
  - [GetTextureID()](#M-CAT_Engine-Core-Tiles-Interfaces-IsoRenderableTileComponentInterface-GetTextureID 'CAT_Engine.Core.Tiles.Interfaces.IsoRenderableTileComponentInterface.GetTextureID')
- [IsoScene](#T-CAT_Engine-Core-SceneBase-IsoScene 'CAT_Engine.Core.SceneBase.IsoScene')
  - [RegisterObject(o)](#M-CAT_Engine-Core-SceneBase-IsoScene-RegisterObject-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject- 'CAT_Engine.Core.SceneBase.IsoScene.RegisterObject(CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject)')
  - [SpawnEntity\`\`1()](#M-CAT_Engine-Core-SceneBase-IsoScene-SpawnEntity``1 'CAT_Engine.Core.SceneBase.IsoScene.SpawnEntity``1')
  - [UnregisterObject(o)](#M-CAT_Engine-Core-SceneBase-IsoScene-UnregisterObject-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject- 'CAT_Engine.Core.SceneBase.IsoScene.UnregisterObject(CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject)')
- [IsoSceneManager](#T-CAT_Engine-Core-SceneBase-IsoSceneManager 'CAT_Engine.Core.SceneBase.IsoSceneManager')
  - [activeRenderer](#P-CAT_Engine-Core-SceneBase-IsoSceneManager-activeRenderer 'CAT_Engine.Core.SceneBase.IsoSceneManager.activeRenderer')
  - [CreateScene\`\`1()](#M-CAT_Engine-Core-SceneBase-IsoSceneManager-CreateScene``1 'CAT_Engine.Core.SceneBase.IsoSceneManager.CreateScene``1')
- [IsoSceneObject](#T-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject 'CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject')
  - [Destroy()](#M-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject-Destroy 'CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject.Destroy')
  - [Dispose()](#M-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject-Dispose 'CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject.Dispose')
- [IsoScopeCycleStat](#T-CAT_Engine-Core-Debug-IsoScopeCycleStat 'CAT_Engine.Core.Debug.IsoScopeCycleStat')
- [IsoTileChunk](#T-CAT_Engine-Core-Tiles-IsoTileChunk 'CAT_Engine.Core.Tiles.IsoTileChunk')
  - [CalculateChunkCoords(globalPos)](#M-CAT_Engine-Core-Tiles-IsoTileChunk-CalculateChunkCoords-CAT_Engine-Core-Utility-IntVector3- 'CAT_Engine.Core.Tiles.IsoTileChunk.CalculateChunkCoords(CAT_Engine.Core.Utility.IntVector3)')
  - [ClearChunk()](#M-CAT_Engine-Core-Tiles-IsoTileChunk-ClearChunk 'CAT_Engine.Core.Tiles.IsoTileChunk.ClearChunk')
  - [IsEmpty()](#M-CAT_Engine-Core-Tiles-IsoTileChunk-IsEmpty 'CAT_Engine.Core.Tiles.IsoTileChunk.IsEmpty')
- [IsoTileComponent](#T-CAT_Engine-Core-Tiles-TileComponents-IsoTileComponent 'CAT_Engine.Core.Tiles.TileComponents.IsoTileComponent')
- [IsoTileComponentInterface](#T-CAT_Engine-Core-Tiles-Interfaces-IsoTileComponentInterface 'CAT_Engine.Core.Tiles.Interfaces.IsoTileComponentInterface')
- [IsoTileObject](#T-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject')
  - [GetComponent\`\`1()](#M-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject-GetComponent``1 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject.GetComponent``1')
  - [GetComponents\`\`1()](#M-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject-GetComponents``1 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject.GetComponents``1')
  - [OnAddedToSquare(square)](#M-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject-OnAddedToSquare-CAT_Engine-Core-Tiles-IsoTileSquare- 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject.OnAddedToSquare(CAT_Engine.Core.Tiles.IsoTileSquare)')
- [IsoTileSquare](#T-CAT_Engine-Core-Tiles-IsoTileSquare 'CAT_Engine.Core.Tiles.IsoTileSquare')
  - [ClearSquare()](#M-CAT_Engine-Core-Tiles-IsoTileSquare-ClearSquare 'CAT_Engine.Core.Tiles.IsoTileSquare.ClearSquare')
  - [CreateTileObject()](#M-CAT_Engine-Core-Tiles-IsoTileSquare-CreateTileObject 'CAT_Engine.Core.Tiles.IsoTileSquare.CreateTileObject')
  - [IsEmpty()](#M-CAT_Engine-Core-Tiles-IsoTileSquare-IsEmpty 'CAT_Engine.Core.Tiles.IsoTileSquare.IsEmpty')
  - [RemoveTileObject(obj)](#M-CAT_Engine-Core-Tiles-IsoTileSquare-RemoveTileObject-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject- 'CAT_Engine.Core.Tiles.IsoTileSquare.RemoveTileObject(CAT_Engine.Core.Tiles.TileObjects.IsoTileObject)')
- [IsoTileZStack](#T-CAT_Engine-Core-Tiles-IsoTileZStack 'CAT_Engine.Core.Tiles.IsoTileZStack')
  - [CalculateSquareCoordinatesInZstack(globalPos)](#M-CAT_Engine-Core-Tiles-IsoTileZStack-CalculateSquareCoordinatesInZstack-CAT_Engine-Core-Utility-IntVector3- 'CAT_Engine.Core.Tiles.IsoTileZStack.CalculateSquareCoordinatesInZstack(CAT_Engine.Core.Utility.IntVector3)')
  - [ClearStack()](#M-CAT_Engine-Core-Tiles-IsoTileZStack-ClearStack 'CAT_Engine.Core.Tiles.IsoTileZStack.ClearStack')
  - [CreateTileSquare(globalPos)](#M-CAT_Engine-Core-Tiles-IsoTileZStack-CreateTileSquare-CAT_Engine-Core-Utility-IntVector3- 'CAT_Engine.Core.Tiles.IsoTileZStack.CreateTileSquare(CAT_Engine.Core.Utility.IntVector3)')
  - [IsEmpty()](#M-CAT_Engine-Core-Tiles-IsoTileZStack-IsEmpty 'CAT_Engine.Core.Tiles.IsoTileZStack.IsEmpty')
  - [RemoveTileSquare(globalPos)](#M-CAT_Engine-Core-Tiles-IsoTileZStack-RemoveTileSquare-CAT_Engine-Core-Utility-IntVector3- 'CAT_Engine.Core.Tiles.IsoTileZStack.RemoveTileSquare(CAT_Engine.Core.Utility.IntVector3)')
- [IsoTilemap](#T-CAT_Engine-Core-Tiles-IsoTilemap 'CAT_Engine.Core.Tiles.IsoTilemap')
  - [AddObject(obj,globalPos)](#M-CAT_Engine-Core-Tiles-IsoTilemap-AddObject-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject,CAT_Engine-Core-Utility-IntVector3- 'CAT_Engine.Core.Tiles.IsoTilemap.AddObject(CAT_Engine.Core.Tiles.TileObjects.IsoTileObject,CAT_Engine.Core.Utility.IntVector3)')
  - [CreateChunk(ChunkPosition)](#M-CAT_Engine-Core-Tiles-IsoTilemap-CreateChunk-CAT_Engine-Core-Utility-IntVector2- 'CAT_Engine.Core.Tiles.IsoTilemap.CreateChunk(CAT_Engine.Core.Utility.IntVector2)')
  - [RemoveObject(obj,globalPos)](#M-CAT_Engine-Core-Tiles-IsoTilemap-RemoveObject-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject,CAT_Engine-Core-Utility-IntVector3- 'CAT_Engine.Core.Tiles.IsoTilemap.RemoveObject(CAT_Engine.Core.Tiles.TileObjects.IsoTileObject,CAT_Engine.Core.Utility.IntVector3)')
- [IsoTransform2](#T-CAT_Engine-Core-Utility-IsoTransform2 'CAT_Engine.Core.Utility.IsoTransform2')
  - [rotation](#F-CAT_Engine-Core-Utility-IsoTransform2-rotation 'CAT_Engine.Core.Utility.IsoTransform2.rotation')
- [IsoTransform3](#T-CAT_Engine-Core-Utility-IsoTransform3 'CAT_Engine.Core.Utility.IsoTransform3')
  - [rotation](#F-CAT_Engine-Core-Utility-IsoTransform3-rotation 'CAT_Engine.Core.Utility.IsoTransform3.rotation')
- [RenderUtility](#T-CAT_Engine-Core-Rendering-Utility-RenderUtility 'CAT_Engine.Core.Rendering.Utility.RenderUtility')
  - [IsoTransformToScreenRect(transform)](#M-CAT_Engine-Core-Rendering-Utility-RenderUtility-IsoTransformToScreenRect-CAT_Engine-Core-Utility-IsoTransform3- 'CAT_Engine.Core.Rendering.Utility.RenderUtility.IsoTransformToScreenRect(CAT_Engine.Core.Utility.IsoTransform3)')
  - [Vec3ToIso(vec3)](#M-CAT_Engine-Core-Rendering-Utility-RenderUtility-Vec3ToIso-Microsoft-Xna-Framework-Vector3- 'CAT_Engine.Core.Rendering.Utility.RenderUtility.Vec3ToIso(Microsoft.Xna.Framework.Vector3)')
- [SquareNotFoundException](#T-CAT_Engine-Core-Tiles-Exceptions-SquareNotFoundException 'CAT_Engine.Core.Tiles.Exceptions.SquareNotFoundException')
- [ZStackNotFoundException](#T-CAT_Engine-Core-Tiles-Exceptions-ZStackNotFoundException 'CAT_Engine.Core.Tiles.Exceptions.ZStackNotFoundException')

<a name='T-CAT_Engine-Core-Tiles-Exceptions-ChunkNotFoundException'></a>
## ChunkNotFoundException `type`

##### Namespace

CAT_Engine.Core.Tiles.Exceptions

##### Summary

Raises an exception because a chunk couldn't be found by the executable.

<a name='T-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity'></a>
## ELogVerbosity `type`

##### Namespace

CAT_Engine.Core.Debug.IsoLogger

<a name='F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Display'></a>
### Display `constants`

##### Summary

Info intended to be seen during normal play. Use for game events like level load, player actions.

<a name='F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Error'></a>
### Error `constants`

##### Summary

Something went wrong but the game can continue. Use for missing assets, bad state etc.

<a name='F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Fatal'></a>
### Fatal `constants`

##### Summary

Always prints and triggers a debug assertion. Use for unrecoverable errors.

<a name='F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Log'></a>
### Log `constants`

##### Summary

General info about what the engine is doing. Use for system events like init, shutdown.

<a name='F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Verbose'></a>
### Verbose `constants`

##### Summary

Detailed info for debugging specific systems. Noisy, disable unless investigating.

<a name='F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-VeryVerbose'></a>
### VeryVerbose `constants`

##### Summary

Extremely detailed, per-frame level info. Only enable when hunting a VERY specific bug.

<a name='F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Warning'></a>
### Warning `constants`

##### Summary

Something unexpected happened but it's not breaking. Use for fallbacks and edge cases.

<a name='T-CAT_Engine-Core-Input-InputManager'></a>
## InputManager `type`

##### Namespace

CAT_Engine.Core.Input

<a name='M-CAT_Engine-Core-Input-InputManager-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialises the InputManager

##### Parameters

This constructor has no parameters.

<a name='M-CAT_Engine-Core-Input-InputManager-AddActionMapping-System-String,CAT_Engine-Core-Input-InputChord[]-'></a>
### AddActionMapping(ActionName,ActionKeybind) `method`

##### Summary

Adds a list of [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') to the Action Mapping dictionary

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ActionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action name, ex: "Interact", "Menu"... |
| ActionKeybind | [CAT_Engine.Core.Input.InputChord[]](#T-CAT_Engine-Core-Input-InputChord[] 'CAT_Engine.Core.Input.InputChord[]') | The list of [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') that will trigger the Action |

<a name='M-CAT_Engine-Core-Input-InputManager-AddAxisMapping-System-String,CAT_Engine-Core-Input-Axis-'></a>
### AddAxisMapping(AxisName,AxisKeybind) `method`

##### Summary

Adds a list of [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') to the Axis Mapping dictionary

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| AxisName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Axis name, ex: "Interact", "Menu"... |
| AxisKeybind | [CAT_Engine.Core.Input.Axis](#T-CAT_Engine-Core-Input-Axis 'CAT_Engine.Core.Input.Axis') | The Axis to be added |

<a name='M-CAT_Engine-Core-Input-InputManager-GetActionMapping-System-String-'></a>
### GetActionMapping(ActionName) `method`

##### Summary

Retrieves the [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') list associated with the given name

##### Returns

The [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') list if found, null otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ActionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Action Name in the dictionary |

<a name='M-CAT_Engine-Core-Input-InputManager-GetAxisMapping-System-String-'></a>
### GetAxisMapping(AxisName) `method`

##### Summary

Retrieves the [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') (keybind) list associated with the given name

##### Returns

The [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') list if found, null otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| AxisName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Axis Name in the dictionary |

<a name='M-CAT_Engine-Core-Input-InputManager-IsKeyHeld-Microsoft-Xna-Framework-Input-Keys-'></a>
### IsKeyHeld(key) `method`

##### Summary

Checks if a key if being held

##### Returns

true if current state of the key is pressed, otherwise false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [Microsoft.Xna.Framework.Input.Keys](#T-Microsoft-Xna-Framework-Input-Keys 'Microsoft.Xna.Framework.Input.Keys') | the key to evaluate |

<a name='M-CAT_Engine-Core-Input-InputManager-IsKeyPressed-Microsoft-Xna-Framework-Input-Keys-'></a>
### IsKeyPressed(key) `method`

##### Summary

Checks if a key is newly pressed.

##### Returns

true if keydown now and not before, otherwise false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [Microsoft.Xna.Framework.Input.Keys](#T-Microsoft-Xna-Framework-Input-Keys 'Microsoft.Xna.Framework.Input.Keys') | the key to evaluate |

<a name='M-CAT_Engine-Core-Input-InputManager-IsKeyReleased-Microsoft-Xna-Framework-Input-Keys-'></a>
### IsKeyReleased(key) `method`

##### Summary

Checks if a key is being released

##### Returns

true if the current key is up and the previous key is down, otherwise false

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [Microsoft.Xna.Framework.Input.Keys](#T-Microsoft-Xna-Framework-Input-Keys 'Microsoft.Xna.Framework.Input.Keys') | the key to evaluate |

<a name='M-CAT_Engine-Core-Input-InputManager-RebindActionMapping-System-String,CAT_Engine-Core-Input-InputChord,System-Int32-'></a>
### RebindActionMapping(ActionName,newKey,keyIndex) `method`

##### Summary

Rebinds a specific inputChord set for a given action

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ActionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action to edit |
| newKey | [CAT_Engine.Core.Input.InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') | The key that will replace an existing key |
| keyIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position of the key in the action InputChord list |

<a name='M-CAT_Engine-Core-Input-InputManager-RebindActionMapping-System-String,CAT_Engine-Core-Input-InputChord[]-'></a>
### RebindActionMapping(ActionName,newKeys) `method`

##### Summary

Rebinds a whole inputChord set for a given action

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ActionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| newKeys | [CAT_Engine.Core.Input.InputChord[]](#T-CAT_Engine-Core-Input-InputChord[] 'CAT_Engine.Core.Input.InputChord[]') |  |

<a name='M-CAT_Engine-Core-Input-InputManager-RebindAxisMapping-System-String,CAT_Engine-Core-Input-InputChord,System-Int32-'></a>
### RebindAxisMapping(AxisName,newKey,keyIndex) `method`

##### Summary

Rebinds a specific inputChord set for a given Axis

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| AxisName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Axis to edit |
| newKey | [CAT_Engine.Core.Input.InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') | The key that will replace an existing key |
| keyIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position of the key in the Axis keybind list |

<a name='M-CAT_Engine-Core-Input-InputManager-RebindAxisMapping-System-String,CAT_Engine-Core-Input-InputChord[]-'></a>
### RebindAxisMapping(AxisName,newKeys) `method`

##### Summary

Rebinds a whole inputChord (keybind) set for a given Axis

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| AxisName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| newKeys | [CAT_Engine.Core.Input.InputChord[]](#T-CAT_Engine-Core-Input-InputChord[] 'CAT_Engine.Core.Input.InputChord[]') |  |

<a name='M-CAT_Engine-Core-Input-InputManager-RemoveActionMapping-System-String-'></a>
### RemoveActionMapping(ActionName) `method`

##### Summary

Removes an action from the ActionMapping dictionary completely.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ActionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action name in the Dictionary |

<a name='M-CAT_Engine-Core-Input-InputManager-RemoveAxisMapping-System-String-'></a>
### RemoveAxisMapping(AxisName) `method`

##### Summary

Removes an Axis from the AxisMapping dictionary completely.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| AxisName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Axis name in the Dictionary |

<a name='M-CAT_Engine-Core-Input-InputManager-Update-System-Single-'></a>
### Update(delta) `method`

##### Summary

Fired whenever the InputManager needs to update itself
Will fire events depending on the registered action and axis mappings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delta | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='T-CAT_Engine-Core-Utility-IntVector2'></a>
## IntVector2 `type`

##### Namespace

CAT_Engine.Core.Utility

##### Summary

Represents a Vector with 2 dimentions: x and y.
Basic comparision operations can be performed, such as == and !=

<a name='M-CAT_Engine-Core-Utility-IntVector2-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Represents the Identity Vector2: (1, 1)

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-Utility-IntVector2-Zero'></a>
### Zero() `method`

##### Summary

Represents the zero Vector2: (0, 0)

##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-Utility-IntVector3'></a>
## IntVector3 `type`

##### Namespace

CAT_Engine.Core.Utility

##### Summary

Represents a Vector with 3 dimentions: x, y and z.
Basic comparision operations can be performed, such as == and !=

<a name='M-CAT_Engine-Core-Utility-IntVector3-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Represents the Identity Vector3: (1, 1, 1)

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-Utility-IntVector3-Zero'></a>
### Zero() `method`

##### Summary

Represents the Zero Vector3: (0, 0, 0)

##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-Rendering-IsoCamera'></a>
## IsoCamera `type`

##### Namespace

CAT_Engine.Core.Rendering

<a name='T-CAT_Engine-IsoGame'></a>
## IsoGame `type`

##### Namespace

CAT_Engine

<a name='M-CAT_Engine-IsoGame-OnAssetManagerReady'></a>
### OnAssetManagerReady() `method`

##### Summary

Called when the Asset Manager is ready for use. Runs after Game Init

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-IsoGame-OnInitializeGame'></a>
### OnInitializeGame() `method`

##### Summary

Called when the Game is ready to initialize. Runs before Asset Manager

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-IsoGame-OnInitializeWindow-Microsoft-Xna-Framework-GameWindow-'></a>
### OnInitializeWindow(Window) `method`

##### Summary

Called after the Engine sets up the Window and lets control to the user. Setup stuff here like [IsMouseVisible](#P-Microsoft-Xna-Framework-Game-IsMouseVisible 'Microsoft.Xna.Framework.Game.IsMouseVisible') or [AllowUserResizing](#P-Microsoft-Xna-Framework-GameWindow-AllowUserResizing 'Microsoft.Xna.Framework.GameWindow.AllowUserResizing')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Window | [Microsoft.Xna.Framework.GameWindow](#T-Microsoft-Xna-Framework-GameWindow 'Microsoft.Xna.Framework.GameWindow') |  |

<a name='M-CAT_Engine-IsoGame-OnUpdate-System-Single-'></a>
### OnUpdate(delta) `method`

##### Summary

Called when the engine updates.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delta | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='T-CAT_Engine-Core-Debug-IsoLogger'></a>
## IsoLogger `type`

##### Namespace

CAT_Engine.Core.Debug

<a name='M-CAT_Engine-Core-Debug-IsoLogger-Assert-System-Boolean,System-String,System-String,System-String,System-Int32,System-Object[]-'></a>
### Assert(condition,format,args) `method`

##### Summary

Checks for a condition, if the condition is [](#!-false 'false') then it will output the message and show a message box with the call stack.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| args | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-CAT_Engine-Core-Debug-IsoLogger-Except-System-String,System-Object[]-'></a>
### Except(format,args) `method`

##### Summary

Logs with no verbosity and throws an exception.
Stripped in non-debug builds

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Format for message |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | message objects |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | throws an exception with the formatted message |

<a name='M-CAT_Engine-Core-Debug-IsoLogger-Log-System-String,CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity,System-Object[]-'></a>
### Log(format,verbosity,args) `method`

##### Summary

Logs to the logger in debug builds and in release will log to a log file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Format of the message |
| verbosity | [CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity](#T-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity') | Verbosity, will not show up if [currentVerbosity](#F-CAT_Engine-Core-Debug-IsoLogger-currentVerbosity 'CAT_Engine.Core.Debug.IsoLogger.currentVerbosity') is at a lower level than the input verbosity |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') |  |

<a name='M-CAT_Engine-Core-Debug-IsoLogger-Log-System-String,System-Object[]-'></a>
### Log() `method`

##### Summary



##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-Debug-Profiling-IsoProfileStat'></a>
## IsoProfileStat `type`

##### Namespace

CAT_Engine.Core.Debug.Profiling

##### Summary

Holds profiling data for a named stat

<a name='T-CAT_Engine-Core-Debug-Profiling-IsoProfiler'></a>
## IsoProfiler `type`

##### Namespace

CAT_Engine.Core.Debug.Profiling

##### Summary

Static profiler that accumulates timing data from [IsoScopeCycleStat](#T-CAT_Engine-Core-Debug-IsoScopeCycleStat 'CAT_Engine.Core.Debug.IsoScopeCycleStat') instances.
Call [Dump](#M-CAT_Engine-Core-Debug-Profiling-IsoProfiler-Dump 'CAT_Engine.Core.Debug.Profiling.IsoProfiler.Dump') to print all recorded stats.

<a name='M-CAT_Engine-Core-Debug-Profiling-IsoProfiler-Reset'></a>
### Reset() `method`

##### Summary

Clears all stored stats.

##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-Rendering-IsoRenderContextBuilder'></a>
## IsoRenderContextBuilder `type`

##### Namespace

CAT_Engine.Core.Rendering

<a name='M-CAT_Engine-Core-Rendering-IsoRenderContextBuilder-Build'></a>
### Build() `method`

##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-Tiles-Interfaces-IsoRenderableTileComponentInterface'></a>
## IsoRenderableTileComponentInterface `type`

##### Namespace

CAT_Engine.Core.Tiles.Interfaces

##### Summary

Interface for the [](#!-IsoRenderableTileComponent 'IsoRenderableTileComponent')

<a name='M-CAT_Engine-Core-Tiles-Interfaces-IsoRenderableTileComponentInterface-GetTextureID'></a>
### GetTextureID() `method`

##### Summary

Should retrieve the texture of the current tile component

##### Returns

The current tile component's texture

##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-SceneBase-IsoScene'></a>
## IsoScene `type`

##### Namespace

CAT_Engine.Core.SceneBase

<a name='M-CAT_Engine-Core-SceneBase-IsoScene-RegisterObject-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject-'></a>
### RegisterObject(o) `method`

##### Summary

Registers a [IsoSceneObject](#T-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject 'CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject') to the scene.

Will register the object to [sceneObjects](#F-CAT_Engine-Core-SceneBase-IsoScene-sceneObjects 'CAT_Engine.Core.SceneBase.IsoScene.sceneObjects') and [renderableObjects](#F-CAT_Engine-Core-SceneBase-IsoScene-renderableObjects 'CAT_Engine.Core.SceneBase.IsoScene.renderableObjects')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| o | [CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject](#T-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject 'CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject') | Object to register |

<a name='M-CAT_Engine-Core-SceneBase-IsoScene-SpawnEntity``1'></a>
### SpawnEntity\`\`1() `method`

##### Summary

Spawns an Entity of type and adds it to the scene [](#!-T 'T')

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The Entity's Type |

<a name='M-CAT_Engine-Core-SceneBase-IsoScene-UnregisterObject-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject-'></a>
### UnregisterObject(o) `method`

##### Summary

Unregisters a [IsoSceneObject](#T-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject 'CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject') from the scene.

Will not remove it from memory if any reference is held to it.

For complete object destruction, see [Destroy](#M-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject-Destroy 'CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject.Destroy')
Will unregister the object from [sceneObjects](#F-CAT_Engine-Core-SceneBase-IsoScene-sceneObjects 'CAT_Engine.Core.SceneBase.IsoScene.sceneObjects') and [renderableObjects](#F-CAT_Engine-Core-SceneBase-IsoScene-renderableObjects 'CAT_Engine.Core.SceneBase.IsoScene.renderableObjects')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| o | [CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject](#T-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject 'CAT_Engine.Core.SceneBase.SceneObjects.IsoSceneObject') | Object to unregister. |

<a name='T-CAT_Engine-Core-SceneBase-IsoSceneManager'></a>
## IsoSceneManager `type`

##### Namespace

CAT_Engine.Core.SceneBase

<a name='P-CAT_Engine-Core-SceneBase-IsoSceneManager-activeRenderer'></a>
### activeRenderer `property`

##### Summary

Current Render Interface, reason we are using the interface is because the Scene Manager should not care if this is 
IsoRenderer or IsoDebugRenderer or IsoVulkanRenderer or anything. It just needs to know "this has a render function"

<a name='M-CAT_Engine-Core-SceneBase-IsoSceneManager-CreateScene``1'></a>
### CreateScene\`\`1() `method`

##### Summary

Creates a scene but does not load it yet.

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject'></a>
## IsoSceneObject `type`

##### Namespace

CAT_Engine.Core.SceneBase.SceneObjects

<a name='M-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject-Destroy'></a>
### Destroy() `method`

##### Summary

Destroys the object and removes it from the scene.

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-SceneBase-SceneObjects-IsoSceneObject-Dispose'></a>
### Dispose() `method`

##### Summary

Override to dispose any unmanaged resources, (Textures, RenderTarget's, etc...)

##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-Debug-IsoScopeCycleStat'></a>
## IsoScopeCycleStat `type`

##### Namespace

CAT_Engine.Core.Debug

##### Summary

A disposable struct that times a scope and reports it to [](#!-Profiler 'Profiler')
Use with a `using` statement to automatically record elapsed time on scope exit

```
using var _ = new ScopeStat("Class.Method");
```

<a name='T-CAT_Engine-Core-Tiles-IsoTileChunk'></a>
## IsoTileChunk `type`

##### Namespace

CAT_Engine.Core.Tiles

##### Summary

Represents an Isometric Tile Chunk
A Chunk contains a List of [IsoTileSquare](#T-CAT_Engine-Core-Tiles-IsoTileSquare 'CAT_Engine.Core.Tiles.IsoTileSquare')'s

<a name='M-CAT_Engine-Core-Tiles-IsoTileChunk-CalculateChunkCoords-CAT_Engine-Core-Utility-IntVector3-'></a>
### CalculateChunkCoords(globalPos) `method`

##### Summary

Calculates the chunk coordinates in the world relative to a global position

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| globalPos | [CAT_Engine.Core.Utility.IntVector3](#T-CAT_Engine-Core-Utility-IntVector3 'CAT_Engine.Core.Utility.IntVector3') |  |

<a name='M-CAT_Engine-Core-Tiles-IsoTileChunk-ClearChunk'></a>
### ClearChunk() `method`

##### Summary

Clears the chunk Stacks

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-Tiles-IsoTileChunk-IsEmpty'></a>
### IsEmpty() `method`

##### Summary

Checks if the chunk is empty

##### Returns

The check result (True if empty, False otherwise)

##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-Tiles-TileComponents-IsoTileComponent'></a>
## IsoTileComponent `type`

##### Namespace

CAT_Engine.Core.Tiles.TileComponents

##### Summary

Base Class for tile components, will define Tile Object State, Behaviour and Visual

<a name='T-CAT_Engine-Core-Tiles-Interfaces-IsoTileComponentInterface'></a>
## IsoTileComponentInterface `type`

##### Namespace

CAT_Engine.Core.Tiles.Interfaces

##### Summary

Interface that include anything that every TileComponent needs

<a name='T-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject'></a>
## IsoTileObject `type`

##### Namespace

CAT_Engine.Core.Tiles.TileObjects

##### Summary

Represents an Isometric Tile
A Tile Object contains a list of [IsoTileComponent](#T-CAT_Engine-Core-Tiles-TileComponents-IsoTileComponent 'CAT_Engine.Core.Tiles.TileComponents.IsoTileComponent')'s

<a name='M-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject-GetComponent``1'></a>
### GetComponent\`\`1() `method`

##### Summary

Gets a component of a certain type attached to this [IsoTileObject](#T-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject')

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject-GetComponents``1'></a>
### GetComponents\`\`1() `method`

##### Summary

Gets all components of a certain type attached to this [IsoTileObject](#T-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject')

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject-OnAddedToSquare-CAT_Engine-Core-Tiles-IsoTileSquare-'></a>
### OnAddedToSquare(square) `method`

##### Summary

Called when this tile object gets added to a square. By default updates parent square

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| square | [CAT_Engine.Core.Tiles.IsoTileSquare](#T-CAT_Engine-Core-Tiles-IsoTileSquare 'CAT_Engine.Core.Tiles.IsoTileSquare') |  |

<a name='T-CAT_Engine-Core-Tiles-IsoTileSquare'></a>
## IsoTileSquare `type`

##### Namespace

CAT_Engine.Core.Tiles

##### Summary

Represents an Isometric Tile Square
A Square contains a List of [IsoTileObject](#T-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject')

<a name='M-CAT_Engine-Core-Tiles-IsoTileSquare-ClearSquare'></a>
### ClearSquare() `method`

##### Summary

Clears the square from it's objects

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-Tiles-IsoTileSquare-CreateTileObject'></a>
### CreateTileObject() `method`

##### Summary

Creates and adds a new Tile Object to a Tile Square

##### Returns



##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-Tiles-IsoTileSquare-IsEmpty'></a>
### IsEmpty() `method`

##### Summary

Checks if the Square is empty

##### Returns

The check result (True if empty, False otherwise)

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-Tiles-IsoTileSquare-RemoveTileObject-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject-'></a>
### RemoveTileObject(obj) `method`

##### Summary

Removes a specified Tile Object from a square

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [CAT_Engine.Core.Tiles.TileObjects.IsoTileObject](#T-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject') | The object to be removed from the square |

<a name='T-CAT_Engine-Core-Tiles-IsoTileZStack'></a>
## IsoTileZStack `type`

##### Namespace

CAT_Engine.Core.Tiles

##### Summary

Represents an Isometric Chunk Layer

<a name='M-CAT_Engine-Core-Tiles-IsoTileZStack-CalculateSquareCoordinatesInZstack-CAT_Engine-Core-Utility-IntVector3-'></a>
### CalculateSquareCoordinatesInZstack(globalPos) `method`

##### Summary

Converts the global coordinates of a square to a local chunk coordinate

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| globalPos | [CAT_Engine.Core.Utility.IntVector3](#T-CAT_Engine-Core-Utility-IntVector3 'CAT_Engine.Core.Utility.IntVector3') | The global position of the square |

<a name='M-CAT_Engine-Core-Tiles-IsoTileZStack-ClearStack'></a>
### ClearStack() `method`

##### Summary

Clears the ZStack's square list.

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-Tiles-IsoTileZStack-CreateTileSquare-CAT_Engine-Core-Utility-IntVector3-'></a>
### CreateTileSquare(globalPos) `method`

##### Summary

Creates and adds a new [IsoTileSquare](#T-CAT_Engine-Core-Tiles-IsoTileSquare 'CAT_Engine.Core.Tiles.IsoTileSquare') to a [IsoTileZStack](#T-CAT_Engine-Core-Tiles-IsoTileZStack 'CAT_Engine.Core.Tiles.IsoTileZStack')

##### Returns

The newly created square

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| globalPos | [CAT_Engine.Core.Utility.IntVector3](#T-CAT_Engine-Core-Utility-IntVector3 'CAT_Engine.Core.Utility.IntVector3') | The global position of the square to be created |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |

<a name='M-CAT_Engine-Core-Tiles-IsoTileZStack-IsEmpty'></a>
### IsEmpty() `method`

##### Summary

Checks if the ZStack is empty

##### Returns

The check result (True if empty, False otherwise)

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-Tiles-IsoTileZStack-RemoveTileSquare-CAT_Engine-Core-Utility-IntVector3-'></a>
### RemoveTileSquare(globalPos) `method`

##### Summary

Removes a [IsoTileSquare](#T-CAT_Engine-Core-Tiles-IsoTileSquare 'CAT_Engine.Core.Tiles.IsoTileSquare') from a [IsoTileZStack](#T-CAT_Engine-Core-Tiles-IsoTileZStack 'CAT_Engine.Core.Tiles.IsoTileZStack')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| globalPos | [CAT_Engine.Core.Utility.IntVector3](#T-CAT_Engine-Core-Utility-IntVector3 'CAT_Engine.Core.Utility.IntVector3') | The global position of the square to be removed |

<a name='T-CAT_Engine-Core-Tiles-IsoTilemap'></a>
## IsoTilemap `type`

##### Namespace

CAT_Engine.Core.Tiles

##### Summary

Represents an Isometric Tile Map made of Tile Chunks

<a name='M-CAT_Engine-Core-Tiles-IsoTilemap-AddObject-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject,CAT_Engine-Core-Utility-IntVector3-'></a>
### AddObject(obj,globalPos) `method`

##### Summary

Adds an object to the Tile Map

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [CAT_Engine.Core.Tiles.TileObjects.IsoTileObject](#T-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject') | The TileObject to be added to the map |
| globalPos | [CAT_Engine.Core.Utility.IntVector3](#T-CAT_Engine-Core-Utility-IntVector3 'CAT_Engine.Core.Utility.IntVector3') | The Global Position of the object to be added |

<a name='M-CAT_Engine-Core-Tiles-IsoTilemap-CreateChunk-CAT_Engine-Core-Utility-IntVector2-'></a>
### CreateChunk(ChunkPosition) `method`

##### Summary

Creates a chunk on the TileMap to the given coordinates and returns it

##### Returns

The newly created Chunk

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ChunkPosition | [CAT_Engine.Core.Utility.IntVector2](#T-CAT_Engine-Core-Utility-IntVector2 'CAT_Engine.Core.Utility.IntVector2') | The chunk's x and y position |

<a name='M-CAT_Engine-Core-Tiles-IsoTilemap-RemoveObject-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject,CAT_Engine-Core-Utility-IntVector3-'></a>
### RemoveObject(obj,globalPos) `method`

##### Summary

Removes an object from the Tile Map

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [CAT_Engine.Core.Tiles.TileObjects.IsoTileObject](#T-CAT_Engine-Core-Tiles-TileObjects-IsoTileObject 'CAT_Engine.Core.Tiles.TileObjects.IsoTileObject') | The TileObject to be removed from the map |
| globalPos | [CAT_Engine.Core.Utility.IntVector3](#T-CAT_Engine-Core-Utility-IntVector3 'CAT_Engine.Core.Utility.IntVector3') | The Global Position of the object to be removed |

<a name='T-CAT_Engine-Core-Utility-IsoTransform2'></a>
## IsoTransform2 `type`

##### Namespace

CAT_Engine.Core.Utility

##### Summary

Represents a 2D Transform

<a name='F-CAT_Engine-Core-Utility-IsoTransform2-rotation'></a>
### rotation `constants`

##### Summary

rotation in degrees, not radiants

<a name='T-CAT_Engine-Core-Utility-IsoTransform3'></a>
## IsoTransform3 `type`

##### Namespace

CAT_Engine.Core.Utility

##### Summary

Represents a 3D Transform

<a name='F-CAT_Engine-Core-Utility-IsoTransform3-rotation'></a>
### rotation `constants`

##### Summary

rotation in degrees, not radiants

<a name='T-CAT_Engine-Core-Rendering-Utility-RenderUtility'></a>
## RenderUtility `type`

##### Namespace

CAT_Engine.Core.Rendering.Utility

<a name='M-CAT_Engine-Core-Rendering-Utility-RenderUtility-IsoTransformToScreenRect-CAT_Engine-Core-Utility-IsoTransform3-'></a>
### IsoTransformToScreenRect(transform) `method`

##### Summary

converts a [IsoTransform3](#T-CAT_Engine-Core-Utility-IsoTransform3 'CAT_Engine.Core.Utility.IsoTransform3') into a screen space Rectangle for rendering or screen space bounds checks

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| transform | [CAT_Engine.Core.Utility.IsoTransform3](#T-CAT_Engine-Core-Utility-IsoTransform3 'CAT_Engine.Core.Utility.IsoTransform3') |  |

<a name='M-CAT_Engine-Core-Rendering-Utility-RenderUtility-Vec3ToIso-Microsoft-Xna-Framework-Vector3-'></a>
### Vec3ToIso(vec3) `method`

##### Summary

Turns a [Vector3](#T-Microsoft-Xna-Framework-Vector3 'Microsoft.Xna.Framework.Vector3') world position into a [Vector2](#T-Microsoft-Xna-Framework-Vector2 'Microsoft.Xna.Framework.Vector2') screen position

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| vec3 | [Microsoft.Xna.Framework.Vector3](#T-Microsoft-Xna-Framework-Vector3 'Microsoft.Xna.Framework.Vector3') |  |

<a name='T-CAT_Engine-Core-Tiles-Exceptions-SquareNotFoundException'></a>
## SquareNotFoundException `type`

##### Namespace

CAT_Engine.Core.Tiles.Exceptions

##### Summary

Raises an exception because a Square couldn't be found by the executable.

<a name='T-CAT_Engine-Core-Tiles-Exceptions-ZStackNotFoundException'></a>
## ZStackNotFoundException `type`

##### Namespace

CAT_Engine.Core.Tiles.Exceptions

##### Summary

Raises an exception because a ZStack couldn't be found by the executable.
