<a name='assembly'></a>
# CAT Engine

## Contents

- [Axis](#T-CAT_Engine-Core-Input-Axis 'CAT_Engine.Core.Input.Axis')
  - [#ctor()](#M-CAT_Engine-Core-Input-Axis-#ctor 'CAT_Engine.Core.Input.Axis.#ctor')
  - [keybinds](#F-CAT_Engine-Core-Input-Axis-keybinds 'CAT_Engine.Core.Input.Axis.keybinds')
  - [scale](#P-CAT_Engine-Core-Input-Axis-scale 'CAT_Engine.Core.Input.Axis.scale')
- [ChunkNotFoundException](#T-CAT_Engine-Core-Tiles-Exceptions-ChunkNotFoundException 'CAT_Engine.Core.Tiles.Exceptions.ChunkNotFoundException')
- [ELogVerbosity](#T-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity')
  - [Display](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Display 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Display')
  - [Error](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Error 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Error')
  - [Fatal](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Fatal 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Fatal')
  - [Log](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Log 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Log')
  - [Verbose](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Verbose 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Verbose')
  - [VeryVerbose](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-VeryVerbose 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.VeryVerbose')
  - [Warning](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-Warning 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.Warning')
- [InputActionEvent](#T-CAT_Engine-Core-Input-InputActionEvent 'CAT_Engine.Core.Input.InputActionEvent')
  - [#ctor(actionName)](#M-CAT_Engine-Core-Input-InputActionEvent-#ctor-System-String- 'CAT_Engine.Core.Input.InputActionEvent.#ctor(System.String)')
  - [actionName](#P-CAT_Engine-Core-Input-InputActionEvent-actionName 'CAT_Engine.Core.Input.InputActionEvent.actionName')
  - [isConsumed](#P-CAT_Engine-Core-Input-InputActionEvent-isConsumed 'CAT_Engine.Core.Input.InputActionEvent.isConsumed')
  - [Consume()](#M-CAT_Engine-Core-Input-InputActionEvent-Consume 'CAT_Engine.Core.Input.InputActionEvent.Consume')
- [InputAxisEvent](#T-CAT_Engine-Core-Input-InputAxisEvent 'CAT_Engine.Core.Input.InputAxisEvent')
  - [#ctor(AxisName,axisValue)](#M-CAT_Engine-Core-Input-InputAxisEvent-#ctor-System-String,System-Single- 'CAT_Engine.Core.Input.InputAxisEvent.#ctor(System.String,System.Single)')
  - [axisName](#P-CAT_Engine-Core-Input-InputAxisEvent-axisName 'CAT_Engine.Core.Input.InputAxisEvent.axisName')
  - [isConsumed](#P-CAT_Engine-Core-Input-InputAxisEvent-isConsumed 'CAT_Engine.Core.Input.InputAxisEvent.isConsumed')
  - [value](#P-CAT_Engine-Core-Input-InputAxisEvent-value 'CAT_Engine.Core.Input.InputAxisEvent.value')
  - [Consume()](#M-CAT_Engine-Core-Input-InputAxisEvent-Consume 'CAT_Engine.Core.Input.InputAxisEvent.Consume')
- [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord')
  - [#ctor()](#M-CAT_Engine-Core-Input-InputChord-#ctor 'CAT_Engine.Core.Input.InputChord.#ctor')
  - [#ctor(key)](#M-CAT_Engine-Core-Input-InputChord-#ctor-Microsoft-Xna-Framework-Input-Keys- 'CAT_Engine.Core.Input.InputChord.#ctor(Microsoft.Xna.Framework.Input.Keys)')
  - [#ctor(key,mods)](#M-CAT_Engine-Core-Input-InputChord-#ctor-Microsoft-Xna-Framework-Input-Keys,CAT_Engine-Core-Input-Modifiers- 'CAT_Engine.Core.Input.InputChord.#ctor(Microsoft.Xna.Framework.Input.Keys,CAT_Engine.Core.Input.Modifiers)')
  - [Key](#P-CAT_Engine-Core-Input-InputChord-Key 'CAT_Engine.Core.Input.InputChord.Key')
  - [GetModifier(mod)](#M-CAT_Engine-Core-Input-InputChord-GetModifier-CAT_Engine-Core-Input-Modifiers- 'CAT_Engine.Core.Input.InputChord.GetModifier(CAT_Engine.Core.Input.Modifiers)')
  - [SetModifier(mod,value)](#M-CAT_Engine-Core-Input-InputChord-SetModifier-CAT_Engine-Core-Input-Modifiers,System-Boolean- 'CAT_Engine.Core.Input.InputChord.SetModifier(CAT_Engine.Core.Input.Modifiers,System.Boolean)')
- [InputManager](#T-CAT_Engine-Core-Input-InputManager 'CAT_Engine.Core.Input.InputManager')
  - [#ctor()](#M-CAT_Engine-Core-Input-InputManager-#ctor 'CAT_Engine.Core.Input.InputManager.#ctor')
  - [_actionPressedListeners](#F-CAT_Engine-Core-Input-InputManager-_actionPressedListeners 'CAT_Engine.Core.Input.InputManager._actionPressedListeners')
  - [_actionReleasedListeners](#F-CAT_Engine-Core-Input-InputManager-_actionReleasedListeners 'CAT_Engine.Core.Input.InputManager._actionReleasedListeners')
  - [_axisUpdatedListeners](#F-CAT_Engine-Core-Input-InputManager-_axisUpdatedListeners 'CAT_Engine.Core.Input.InputManager._axisUpdatedListeners')
  - [_currentState](#P-CAT_Engine-Core-Input-InputManager-_currentState 'CAT_Engine.Core.Input.InputManager._currentState')
  - [_previousState](#P-CAT_Engine-Core-Input-InputManager-_previousState 'CAT_Engine.Core.Input.InputManager._previousState')
  - [AddActionMapping(ActionName,ActionKeybind)](#M-CAT_Engine-Core-Input-InputManager-AddActionMapping-System-String,CAT_Engine-Core-Input-InputChord[]- 'CAT_Engine.Core.Input.InputManager.AddActionMapping(System.String,CAT_Engine.Core.Input.InputChord[])')
  - [AddAxisMapping(AxisName,AxisKeybind)](#M-CAT_Engine-Core-Input-InputManager-AddAxisMapping-System-String,CAT_Engine-Core-Input-Axis[]- 'CAT_Engine.Core.Input.InputManager.AddAxisMapping(System.String,CAT_Engine.Core.Input.Axis[])')
  - [GetActionMapping(ActionName)](#M-CAT_Engine-Core-Input-InputManager-GetActionMapping-System-String- 'CAT_Engine.Core.Input.InputManager.GetActionMapping(System.String)')
  - [GetAxisMapping(AxisName)](#M-CAT_Engine-Core-Input-InputManager-GetAxisMapping-System-String- 'CAT_Engine.Core.Input.InputManager.GetAxisMapping(System.String)')
  - [IsKeyHeld(key)](#M-CAT_Engine-Core-Input-InputManager-IsKeyHeld-Microsoft-Xna-Framework-Input-Keys- 'CAT_Engine.Core.Input.InputManager.IsKeyHeld(Microsoft.Xna.Framework.Input.Keys)')
  - [IsKeyPressed(key)](#M-CAT_Engine-Core-Input-InputManager-IsKeyPressed-Microsoft-Xna-Framework-Input-Keys- 'CAT_Engine.Core.Input.InputManager.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys)')
  - [IsKeyReleased(key)](#M-CAT_Engine-Core-Input-InputManager-IsKeyReleased-Microsoft-Xna-Framework-Input-Keys- 'CAT_Engine.Core.Input.InputManager.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys)')
  - [RebindActionMapping(ActionName,newKey,keyIndex)](#M-CAT_Engine-Core-Input-InputManager-RebindActionMapping-System-String,CAT_Engine-Core-Input-InputChord,System-Int32- 'CAT_Engine.Core.Input.InputManager.RebindActionMapping(System.String,CAT_Engine.Core.Input.InputChord,System.Int32)')
  - [RebindActionMapping(ActionName,newKeys)](#M-CAT_Engine-Core-Input-InputManager-RebindActionMapping-System-String,CAT_Engine-Core-Input-InputChord[]- 'CAT_Engine.Core.Input.InputManager.RebindActionMapping(System.String,CAT_Engine.Core.Input.InputChord[])')
  - [RebindAxisMapping(AxisName,newAxis,axisIndex)](#M-CAT_Engine-Core-Input-InputManager-RebindAxisMapping-System-String,CAT_Engine-Core-Input-Axis,System-Int32- 'CAT_Engine.Core.Input.InputManager.RebindAxisMapping(System.String,CAT_Engine.Core.Input.Axis,System.Int32)')
  - [RebindAxisMapping(AxisName,newAxises)](#M-CAT_Engine-Core-Input-InputManager-RebindAxisMapping-System-String,CAT_Engine-Core-Input-Axis[]- 'CAT_Engine.Core.Input.InputManager.RebindAxisMapping(System.String,CAT_Engine.Core.Input.Axis[])')
  - [RegisterActionPressed(priority,callback,actionName)](#M-CAT_Engine-Core-Input-InputManager-RegisterActionPressed-System-String,System-Int32,System-Action{CAT_Engine-Core-Input-InputActionEvent}- 'CAT_Engine.Core.Input.InputManager.RegisterActionPressed(System.String,System.Int32,System.Action{CAT_Engine.Core.Input.InputActionEvent})')
  - [RegisterActionReleased(actionName,priority,callback)](#M-CAT_Engine-Core-Input-InputManager-RegisterActionReleased-System-String,System-Int32,System-Action{CAT_Engine-Core-Input-InputActionEvent}- 'CAT_Engine.Core.Input.InputManager.RegisterActionReleased(System.String,System.Int32,System.Action{CAT_Engine.Core.Input.InputActionEvent})')
  - [RegisterAxisUpdated(actionName,priority,callback)](#M-CAT_Engine-Core-Input-InputManager-RegisterAxisUpdated-System-String,System-Int32,System-Action{CAT_Engine-Core-Input-InputAxisEvent}- 'CAT_Engine.Core.Input.InputManager.RegisterAxisUpdated(System.String,System.Int32,System.Action{CAT_Engine.Core.Input.InputAxisEvent})')
  - [RemoveActionMapping(ActionName)](#M-CAT_Engine-Core-Input-InputManager-RemoveActionMapping-System-String- 'CAT_Engine.Core.Input.InputManager.RemoveActionMapping(System.String)')
  - [RemoveAxisMapping(AxisName)](#M-CAT_Engine-Core-Input-InputManager-RemoveAxisMapping-System-String- 'CAT_Engine.Core.Input.InputManager.RemoveAxisMapping(System.String)')
  - [UnregisterActionPressed(actionName,callback)](#M-CAT_Engine-Core-Input-InputManager-UnregisterActionPressed-System-String,System-Action{CAT_Engine-Core-Input-InputActionEvent}- 'CAT_Engine.Core.Input.InputManager.UnregisterActionPressed(System.String,System.Action{CAT_Engine.Core.Input.InputActionEvent})')
  - [UnregisterActionReleased(actionName,callback)](#M-CAT_Engine-Core-Input-InputManager-UnregisterActionReleased-System-String,System-Action{CAT_Engine-Core-Input-InputActionEvent}- 'CAT_Engine.Core.Input.InputManager.UnregisterActionReleased(System.String,System.Action{CAT_Engine.Core.Input.InputActionEvent})')
  - [UnregisterAxisUpdated(actionName,callback)](#M-CAT_Engine-Core-Input-InputManager-UnregisterAxisUpdated-System-String,System-Action{CAT_Engine-Core-Input-InputActionEvent}- 'CAT_Engine.Core.Input.InputManager.UnregisterAxisUpdated(System.String,System.Action{CAT_Engine.Core.Input.InputActionEvent})')
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
  - [currentVerbosity](#F-CAT_Engine-Core-Debug-IsoLogger-currentVerbosity 'CAT_Engine.Core.Debug.IsoLogger.currentVerbosity')
  - [Assert(condition,format,callerMember,callerFile,callerLine,args)](#M-CAT_Engine-Core-Debug-IsoLogger-Assert-System-Boolean,System-String,System-String,System-String,System-Int32,System-Object[]- 'CAT_Engine.Core.Debug.IsoLogger.Assert(System.Boolean,System.String,System.String,System.String,System.Int32,System.Object[])')
  - [Except(format,args)](#M-CAT_Engine-Core-Debug-IsoLogger-Except-System-String,System-Object[]- 'CAT_Engine.Core.Debug.IsoLogger.Except(System.String,System.Object[])')
  - [Log(format,verbosity,args)](#M-CAT_Engine-Core-Debug-IsoLogger-Log-System-String,CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity,System-Object[]- 'CAT_Engine.Core.Debug.IsoLogger.Log(System.String,CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity,System.Object[])')
  - [Log()](#M-CAT_Engine-Core-Debug-IsoLogger-Log-System-String,System-Object[]- 'CAT_Engine.Core.Debug.IsoLogger.Log(System.String,System.Object[])')
  - [SetVerbosity(newVerbosity)](#M-CAT_Engine-Core-Debug-IsoLogger-SetVerbosity-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity- 'CAT_Engine.Core.Debug.IsoLogger.SetVerbosity(CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity)')
- [IsoProfileStat](#T-CAT_Engine-Core-Debug-Profiling-IsoProfileStat 'CAT_Engine.Core.Debug.Profiling.IsoProfileStat')
  - [calls](#F-CAT_Engine-Core-Debug-Profiling-IsoProfileStat-calls 'CAT_Engine.Core.Debug.Profiling.IsoProfileStat.calls')
  - [totalTime](#F-CAT_Engine-Core-Debug-Profiling-IsoProfileStat-totalTime 'CAT_Engine.Core.Debug.Profiling.IsoProfileStat.totalTime')
- [IsoProfiler](#T-CAT_Engine-Core-Debug-Profiling-IsoProfiler 'CAT_Engine.Core.Debug.Profiling.IsoProfiler')
  - [Dump()](#M-CAT_Engine-Core-Debug-Profiling-IsoProfiler-Dump 'CAT_Engine.Core.Debug.Profiling.IsoProfiler.Dump')
  - [Record(name,elapsed)](#M-CAT_Engine-Core-Debug-Profiling-IsoProfiler-Record-System-String,System-TimeSpan- 'CAT_Engine.Core.Debug.Profiling.IsoProfiler.Record(System.String,System.TimeSpan)')
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
  - [#ctor(name)](#M-CAT_Engine-Core-Debug-IsoScopeCycleStat-#ctor-System-String- 'CAT_Engine.Core.Debug.IsoScopeCycleStat.#ctor(System.String)')
  - [calls](#F-CAT_Engine-Core-Debug-IsoScopeCycleStat-calls 'CAT_Engine.Core.Debug.IsoScopeCycleStat.calls')
  - [Dispose()](#M-CAT_Engine-Core-Debug-IsoScopeCycleStat-Dispose 'CAT_Engine.Core.Debug.IsoScopeCycleStat.Dispose')
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
- [IsoUpdateableInterface](#T-CAT_Engine-Core-Interfaces-IsoUpdateableInterface 'CAT_Engine.Core.Interfaces.IsoUpdateableInterface')
  - [Update(delta)](#M-CAT_Engine-Core-Interfaces-IsoUpdateableInterface-Update-System-Single- 'CAT_Engine.Core.Interfaces.IsoUpdateableInterface.Update(System.Single)')
- [Modifiers](#T-CAT_Engine-Core-Input-Modifiers 'CAT_Engine.Core.Input.Modifiers')
  - [Alt](#F-CAT_Engine-Core-Input-Modifiers-Alt 'CAT_Engine.Core.Input.Modifiers.Alt')
  - [Control](#F-CAT_Engine-Core-Input-Modifiers-Control 'CAT_Engine.Core.Input.Modifiers.Control')
  - [None](#F-CAT_Engine-Core-Input-Modifiers-None 'CAT_Engine.Core.Input.Modifiers.None')
  - [Shift](#F-CAT_Engine-Core-Input-Modifiers-Shift 'CAT_Engine.Core.Input.Modifiers.Shift')
- [RenderUtility](#T-CAT_Engine-Core-Rendering-Utility-RenderUtility 'CAT_Engine.Core.Rendering.Utility.RenderUtility')
  - [IsoTransformToScreenRect(transform)](#M-CAT_Engine-Core-Rendering-Utility-RenderUtility-IsoTransformToScreenRect-CAT_Engine-Core-Utility-IsoTransform3- 'CAT_Engine.Core.Rendering.Utility.RenderUtility.IsoTransformToScreenRect(CAT_Engine.Core.Utility.IsoTransform3)')
  - [Vec3ToIso(vec3)](#M-CAT_Engine-Core-Rendering-Utility-RenderUtility-Vec3ToIso-Microsoft-Xna-Framework-Vector3- 'CAT_Engine.Core.Rendering.Utility.RenderUtility.Vec3ToIso(Microsoft.Xna.Framework.Vector3)')
- [SquareNotFoundException](#T-CAT_Engine-Core-Tiles-Exceptions-SquareNotFoundException 'CAT_Engine.Core.Tiles.Exceptions.SquareNotFoundException')
- [ZStackNotFoundException](#T-CAT_Engine-Core-Tiles-Exceptions-ZStackNotFoundException 'CAT_Engine.Core.Tiles.Exceptions.ZStackNotFoundException')

<a name='T-CAT_Engine-Core-Input-Axis'></a>
## Axis `type`

##### Namespace

CAT_Engine.Core.Input

##### Summary

Represents an axis with it's associated scale [-1.0, 1.0] and [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') (as keybind associated to the Axis trigger)

<a name='M-CAT_Engine-Core-Input-Axis-#ctor'></a>
### #ctor() `constructor`

##### Summary

The default axis constructor
- scale = 0.0f
- keybinds = null

##### Parameters

This constructor has no parameters.

<a name='F-CAT_Engine-Core-Input-Axis-keybinds'></a>
### keybinds `constants`

##### Summary

The keybinds associated with the axis

<a name='P-CAT_Engine-Core-Input-Axis-scale'></a>
### scale `property`

##### Summary

The scale of the axis

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

##### Summary

Logging Verbosity Levels

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

<a name='T-CAT_Engine-Core-Input-InputActionEvent'></a>
## InputActionEvent `type`

##### Namespace

CAT_Engine.Core.Input

##### Summary

Represents an Event related to an action input

<a name='M-CAT_Engine-Core-Input-InputActionEvent-#ctor-System-String-'></a>
### #ctor(actionName) `constructor`

##### Summary

Creates a new InputActionEvent with the action name

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action name linked to the event |

<a name='P-CAT_Engine-Core-Input-InputActionEvent-actionName'></a>
### actionName `property`

##### Summary

The action name linked to the InputActionEvent

<a name='P-CAT_Engine-Core-Input-InputActionEvent-isConsumed'></a>
### isConsumed `property`

##### Summary

Indicates wether the event has been consumed or not

<a name='M-CAT_Engine-Core-Input-InputActionEvent-Consume'></a>
### Consume() `method`

##### Summary

Consumes the targeted event

##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-Input-InputAxisEvent'></a>
## InputAxisEvent `type`

##### Namespace

CAT_Engine.Core.Input

##### Summary

Represents an Event related to an axis input

<a name='M-CAT_Engine-Core-Input-InputAxisEvent-#ctor-System-String,System-Single-'></a>
### #ctor(AxisName,axisValue) `constructor`

##### Summary

Default constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| AxisName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The axis name |
| axisValue | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | The axis value |

<a name='P-CAT_Engine-Core-Input-InputAxisEvent-axisName'></a>
### axisName `property`

##### Summary

The axis name linked to the InputAxisEvent

<a name='P-CAT_Engine-Core-Input-InputAxisEvent-isConsumed'></a>
### isConsumed `property`

##### Summary

Indicates wether the event has been consumed or not

<a name='P-CAT_Engine-Core-Input-InputAxisEvent-value'></a>
### value `property`

##### Summary

The value linked to the InputAxisEvent

<a name='M-CAT_Engine-Core-Input-InputAxisEvent-Consume'></a>
### Consume() `method`

##### Summary

Consumes the targeted event

##### Parameters

This method has no parameters.

<a name='T-CAT_Engine-Core-Input-InputChord'></a>
## InputChord `type`

##### Namespace

CAT_Engine.Core.Input

##### Summary

Representation of an input sequence (ex: CTRL + Z, with CTRL being a [modifiers](#F-CAT_Engine-Core-Input-InputChord-modifiers 'CAT_Engine.Core.Input.InputChord.modifiers'), and Z a [Keys](#T-Microsoft-Xna-Framework-Input-Keys 'Microsoft.Xna.Framework.Input.Keys'))

<a name='M-CAT_Engine-Core-Input-InputChord-#ctor'></a>
### #ctor() `constructor`

##### Summary

InputChord constructor

##### Parameters

This constructor has no parameters.

<a name='M-CAT_Engine-Core-Input-InputChord-#ctor-Microsoft-Xna-Framework-Input-Keys-'></a>
### #ctor(key) `constructor`

##### Summary

InputChord constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [Microsoft.Xna.Framework.Input.Keys](#T-Microsoft-Xna-Framework-Input-Keys 'Microsoft.Xna.Framework.Input.Keys') | The associated key of the inputChord |

<a name='M-CAT_Engine-Core-Input-InputChord-#ctor-Microsoft-Xna-Framework-Input-Keys,CAT_Engine-Core-Input-Modifiers-'></a>
### #ctor(key,mods) `constructor`

##### Summary

InputChord constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [Microsoft.Xna.Framework.Input.Keys](#T-Microsoft-Xna-Framework-Input-Keys 'Microsoft.Xna.Framework.Input.Keys') | The associated key of the inputChord |
| mods | [CAT_Engine.Core.Input.Modifiers](#T-CAT_Engine-Core-Input-Modifiers 'CAT_Engine.Core.Input.Modifiers') | The associated modifiers of the inputChord |

<a name='P-CAT_Engine-Core-Input-InputChord-Key'></a>
### Key `property`

##### Summary

The associated key

<a name='M-CAT_Engine-Core-Input-InputChord-GetModifier-CAT_Engine-Core-Input-Modifiers-'></a>
### GetModifier(mod) `method`

##### Summary

Obtains the specified modifier for an InputChord

##### Returns

the status of the modifier as a boolean

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod | [CAT_Engine.Core.Input.Modifiers](#T-CAT_Engine-Core-Input-Modifiers 'CAT_Engine.Core.Input.Modifiers') | the modifier to get |

<a name='M-CAT_Engine-Core-Input-InputChord-SetModifier-CAT_Engine-Core-Input-Modifiers,System-Boolean-'></a>
### SetModifier(mod,value) `method`

##### Summary

Sets the specified modifier (`mod`) to the specified `value`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod | [CAT_Engine.Core.Input.Modifiers](#T-CAT_Engine-Core-Input-Modifiers 'CAT_Engine.Core.Input.Modifiers') | the modifier to edit |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | the value to be set |

<a name='T-CAT_Engine-Core-Input-InputManager'></a>
## InputManager `type`

##### Namespace

CAT_Engine.Core.Input

##### Summary

Input Manager that handles input detection, then handles action and axis mappings and dispatches events corresponding to the hit keybind.

<a name='M-CAT_Engine-Core-Input-InputManager-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialises the InputManager

##### Parameters

This constructor has no parameters.

<a name='F-CAT_Engine-Core-Input-InputManager-_actionPressedListeners'></a>
### _actionPressedListeners `constants`

##### Summary

Priority list for action Pressed events. HIGHEST priority starts at 0, then lessens the higher the value

<a name='F-CAT_Engine-Core-Input-InputManager-_actionReleasedListeners'></a>
### _actionReleasedListeners `constants`

##### Summary

Priority list for action Released events. HIGHEST priority starts at 0, then lessens the higher the value.

<a name='F-CAT_Engine-Core-Input-InputManager-_axisUpdatedListeners'></a>
### _axisUpdatedListeners `constants`

##### Summary

Priority list for axisUpdated events. HIGHEST priority starts at 0, then lessens the higher the value.

<a name='P-CAT_Engine-Core-Input-InputManager-_currentState'></a>
### _currentState `property`

##### Summary

The current state of the keyboard

<a name='P-CAT_Engine-Core-Input-InputManager-_previousState'></a>
### _previousState `property`

##### Summary

The previous state of the keyboard

<a name='M-CAT_Engine-Core-Input-InputManager-AddActionMapping-System-String,CAT_Engine-Core-Input-InputChord[]-'></a>
### AddActionMapping(ActionName,ActionKeybind) `method`

##### Summary

Adds a list of [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') to the Action Mapping dictionary

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ActionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action name, ex: "Interact", "Menu"... |
| ActionKeybind | [CAT_Engine.Core.Input.InputChord[]](#T-CAT_Engine-Core-Input-InputChord[] 'CAT_Engine.Core.Input.InputChord[]') | The list of [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') that will trigger the Action |

<a name='M-CAT_Engine-Core-Input-InputManager-AddAxisMapping-System-String,CAT_Engine-Core-Input-Axis[]-'></a>
### AddAxisMapping(AxisName,AxisKeybind) `method`

##### Summary

Adds a list of [InputChord](#T-CAT_Engine-Core-Input-InputChord 'CAT_Engine.Core.Input.InputChord') to the Axis Mapping dictionary

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| AxisName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Axis name, ex: "Interact", "Menu"... |
| AxisKeybind | [CAT_Engine.Core.Input.Axis[]](#T-CAT_Engine-Core-Input-Axis[] 'CAT_Engine.Core.Input.Axis[]') | The Axis to be added |

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

<a name='M-CAT_Engine-Core-Input-InputManager-RebindAxisMapping-System-String,CAT_Engine-Core-Input-Axis,System-Int32-'></a>
### RebindAxisMapping(AxisName,newAxis,axisIndex) `method`

##### Summary

Rebinds a specific inputChord set for a given Axis

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| AxisName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Axis to edit |
| newAxis | [CAT_Engine.Core.Input.Axis](#T-CAT_Engine-Core-Input-Axis 'CAT_Engine.Core.Input.Axis') | The axis that will replace an existing axis |
| axisIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position of the axis in the Axis keybind list |

<a name='M-CAT_Engine-Core-Input-InputManager-RebindAxisMapping-System-String,CAT_Engine-Core-Input-Axis[]-'></a>
### RebindAxisMapping(AxisName,newAxises) `method`

##### Summary

Rebinds a whole inputChord (keybind) set for a given Axis

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| AxisName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The axis name to be rebound |
| newAxises | [CAT_Engine.Core.Input.Axis[]](#T-CAT_Engine-Core-Input-Axis[] 'CAT_Engine.Core.Input.Axis[]') | The list of new axises to be associated with the axis name |

<a name='M-CAT_Engine-Core-Input-InputManager-RegisterActionPressed-System-String,System-Int32,System-Action{CAT_Engine-Core-Input-InputActionEvent}-'></a>
### RegisterActionPressed(priority,callback,actionName) `method`

##### Summary

Subscribes an action to the priority list with it's subsequent priority
The list is also sorted in priority order during this step.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| priority | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The priority level. 0 is the HIGHEST priority, then it goes up. |
| callback | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The callback function when the action is pressed |
| actionName | [System.Action{CAT_Engine.Core.Input.InputActionEvent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{CAT_Engine.Core.Input.InputActionEvent}') | The action name |

<a name='M-CAT_Engine-Core-Input-InputManager-RegisterActionReleased-System-String,System-Int32,System-Action{CAT_Engine-Core-Input-InputActionEvent}-'></a>
### RegisterActionReleased(actionName,priority,callback) `method`

##### Summary

Subscribes an event to the action released priority list

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action Name |
| priority | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The priority level. 0 is the HITGHEST priority. |
| callback | [System.Action{CAT_Engine.Core.Input.InputActionEvent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{CAT_Engine.Core.Input.InputActionEvent}') | The callback |

<a name='M-CAT_Engine-Core-Input-InputManager-RegisterAxisUpdated-System-String,System-Int32,System-Action{CAT_Engine-Core-Input-InputAxisEvent}-'></a>
### RegisterAxisUpdated(actionName,priority,callback) `method`

##### Summary

Subscribed an event to the axis Updated priority list

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action name. |
| priority | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The priority. 0 is the HIGHEST priority. |
| callback | [System.Action{CAT_Engine.Core.Input.InputAxisEvent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{CAT_Engine.Core.Input.InputAxisEvent}') | the callback. |

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

<a name='M-CAT_Engine-Core-Input-InputManager-UnregisterActionPressed-System-String,System-Action{CAT_Engine-Core-Input-InputActionEvent}-'></a>
### UnregisterActionPressed(actionName,callback) `method`

##### Summary

Unsubscribes all actions with the same callback from the priority list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action name |
| callback | [System.Action{CAT_Engine.Core.Input.InputActionEvent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{CAT_Engine.Core.Input.InputActionEvent}') | The callback function associated in the priority list. |

<a name='M-CAT_Engine-Core-Input-InputManager-UnregisterActionReleased-System-String,System-Action{CAT_Engine-Core-Input-InputActionEvent}-'></a>
### UnregisterActionReleased(actionName,callback) `method`

##### Summary

Unsubscribes all events with the same callback from the action released priority list

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action name |
| callback | [System.Action{CAT_Engine.Core.Input.InputActionEvent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{CAT_Engine.Core.Input.InputActionEvent}') | The callback. |

<a name='M-CAT_Engine-Core-Input-InputManager-UnregisterAxisUpdated-System-String,System-Action{CAT_Engine-Core-Input-InputActionEvent}-'></a>
### UnregisterAxisUpdated(actionName,callback) `method`

##### Summary

Unsubscribes all events with the same callback from the axis updated priority list

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The action name |
| callback | [System.Action{CAT_Engine.Core.Input.InputActionEvent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{CAT_Engine.Core.Input.InputActionEvent}') | The callback. |

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

##### Summary

Provides a Logger with verbosity levels, asserts and

<a name='F-CAT_Engine-Core-Debug-IsoLogger-currentVerbosity'></a>
### currentVerbosity `constants`

##### Summary

Represents the currentVerbosity, default is [VeryVerbose](#F-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-VeryVerbose 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity.VeryVerbose').

<a name='M-CAT_Engine-Core-Debug-IsoLogger-Assert-System-Boolean,System-String,System-String,System-String,System-Int32,System-Object[]-'></a>
### Assert(condition,format,callerMember,callerFile,callerLine,args) `method`

##### Summary

Checks for a condition, if the condition is true then it will output the message and show a message box with the call stack.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| condition | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Shows a message box with the call stack when true |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The mesage formatting used |
| callerMember | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The calling function |
| callerFile | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file where the function is |
| callerLine | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line in the file |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | List of arguments. |

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

<a name='M-CAT_Engine-Core-Debug-IsoLogger-SetVerbosity-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity-'></a>
### SetVerbosity(newVerbosity) `method`

##### Summary

Sets the logging verbosity of the Logger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| newVerbosity | [CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity](#T-CAT_Engine-Core-Debug-IsoLogger-ELogVerbosity 'CAT_Engine.Core.Debug.IsoLogger.ELogVerbosity') | The log verbosity to be set |

<a name='T-CAT_Engine-Core-Debug-Profiling-IsoProfileStat'></a>
## IsoProfileStat `type`

##### Namespace

CAT_Engine.Core.Debug.Profiling

##### Summary

Holds profiling data for a named stat

<a name='F-CAT_Engine-Core-Debug-Profiling-IsoProfileStat-calls'></a>
### calls `constants`

##### Summary

Number of calls

<a name='F-CAT_Engine-Core-Debug-Profiling-IsoProfileStat-totalTime'></a>
### totalTime `constants`

##### Summary

Elapsed time

<a name='T-CAT_Engine-Core-Debug-Profiling-IsoProfiler'></a>
## IsoProfiler `type`

##### Namespace

CAT_Engine.Core.Debug.Profiling

##### Summary

Static profiler that accumulates timing data from [IsoScopeCycleStat](#T-CAT_Engine-Core-Debug-IsoScopeCycleStat 'CAT_Engine.Core.Debug.IsoScopeCycleStat') instances.
Call [Dump](#M-CAT_Engine-Core-Debug-Profiling-IsoProfiler-Dump 'CAT_Engine.Core.Debug.Profiling.IsoProfiler.Dump') to print all recorded stats.

<a name='M-CAT_Engine-Core-Debug-Profiling-IsoProfiler-Dump'></a>
### Dump() `method`

##### Summary

Dumps the profiler and logs it's stats

##### Parameters

This method has no parameters.

<a name='M-CAT_Engine-Core-Debug-Profiling-IsoProfiler-Record-System-String,System-TimeSpan-'></a>
### Record(name,elapsed) `method`

##### Summary

Records a new entry that associates a name with an elapsed time.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the stat to record |
| elapsed | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | The elapsed time to add. |

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

A disposable struct that times a scope and reports it to [IsoProfiler](#T-CAT_Engine-Core-Debug-Profiling-IsoProfiler 'CAT_Engine.Core.Debug.Profiling.IsoProfiler')
Use with a `using` statement to automatically record elapsed time on scope exit

```
using var _ = new ScopeStat("Class.Method");
```

<a name='M-CAT_Engine-Core-Debug-IsoScopeCycleStat-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Default constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The cycle name |

<a name='F-CAT_Engine-Core-Debug-IsoScopeCycleStat-calls'></a>
### calls `constants`

##### Summary

Number of calls done during a cycle.

<a name='M-CAT_Engine-Core-Debug-IsoScopeCycleStat-Dispose'></a>
### Dispose() `method`

##### Summary

Stops the timer and records the elapsed time.

##### Parameters

This method has no parameters.

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

<a name='T-CAT_Engine-Core-Interfaces-IsoUpdateableInterface'></a>
## IsoUpdateableInterface `type`

##### Namespace

CAT_Engine.Core.Interfaces

##### Summary

Interface for updateable components that have to provide update methods.

<a name='M-CAT_Engine-Core-Interfaces-IsoUpdateableInterface-Update-System-Single-'></a>
### Update(delta) `method`

##### Summary

Update function to allow for the component's update

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delta | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | Usualy time |

<a name='T-CAT_Engine-Core-Input-Modifiers'></a>
## Modifiers `type`

##### Namespace

CAT_Engine.Core.Input

##### Summary

InputChord modifier keys:
- None    - No      modifier key
- Shift
- Alt
- Control
These modifiers can be combined together to make for more advanced modifier keys, example: CTRL + SHIFT + Z

<a name='F-CAT_Engine-Core-Input-Modifiers-Alt'></a>
### Alt `constants`

##### Summary

Alt modifier key: ALT has to be pressed

<a name='F-CAT_Engine-Core-Input-Modifiers-Control'></a>
### Control `constants`

##### Summary

Control modifier key: CTRL has to be pressed

<a name='F-CAT_Engine-Core-Input-Modifiers-None'></a>
### None `constants`

##### Summary

None modifier key: no modifiers

<a name='F-CAT_Engine-Core-Input-Modifiers-Shift'></a>
### Shift `constants`

##### Summary

Shift modifier key: SHIFT has to be pressed

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
