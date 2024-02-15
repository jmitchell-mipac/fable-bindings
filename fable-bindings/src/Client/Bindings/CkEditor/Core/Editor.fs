namespace Client.Bindings.CkEditor.Core

open System
open Client.Bindings.CkEditor.Core.EditorConfig
open Client.Bindings.CkEditor.Core.Context
open Fable.Core
open Fable.Core.JS

module Editor =

    type Array<'T> = System.Collections.Generic.IList<'T>
    type Symbol = obj

    // type Config = @ckeditor_ckeditor5_utils.Config
    // type Locale = @ckeditor_ckeditor5_utils.Locale
    // type LocaleTranslate = @ckeditor_ckeditor5_utils.LocaleTranslate
    // type Conversion = @ckeditor_ckeditor5_engine.Conversion
    // type DataController = @ckeditor_ckeditor5_engine.DataController
    // type EditingController = @ckeditor_ckeditor5_engine.EditingController
    // type Model = @ckeditor_ckeditor5_engine.Model
    // type EditorUI = @ckeditor_ckeditor5_ui.EditorUI
    // type CommandsMap = ___commandcollection.CommandsMap
    // type LoadedPlugins = ___plugin.LoadedPlugins
    // type PluginConstructor = ___plugin.PluginConstructor
    // type EditorConfig = __editorconfig.EditorConfig

    [<Import("Editor_base","module")>]
    let Editor_base: {| Create: unit -> obj; prototype: obj |} = jsNative

    // type [<AllowNullLiteral>] IExports =
    //     abstract Editor: EditorStatic

    type [<AllowNullLiteral>] Editor =
        // inherit Editor_base
        // abstract commands: CommandCollection
        // abstract config: Config<EditorConfig>
        // abstract conversion: Conversion
        // abstract data: DataController
        // abstract editing: EditingController
        // abstract locale: Locale
        // abstract model: Model
        // abstract plugins: PluginCollection<Editor>
        // abstract keystrokes: EditingKeystrokeHandler
        // abstract t: LocaleTranslate
        // abstract id: string
        // abstract state: EditorState with get, set
        // abstract ui: EditorUI
        abstract _context: Context
        abstract _readOnlyLocks: Set<U2<Symbol, string>>
        abstract isReadOnly: bool with get, set
        abstract enableReadOnlyMode: lockId: U2<string, Symbol> -> unit
        abstract disableReadOnlyMode: lockId: U2<string, Symbol> -> unit
        // abstract initPlugins: unit -> Promise<LoadedPlugins>
        abstract destroy: unit -> Promise<obj>
        // abstract execute: commandName: 'TName * [<ParamArray>] commandParams: Parameters<obj> -> ReturnType<obj>
        abstract focus: unit -> unit

    type [<AllowNullLiteral>] EditorStatic =
        abstract defaultConfig: EditorConfig option with get, set
        // abstract builtinPlugins: Array<PluginConstructor<Editor>> option with get, set
        [<EmitConstructor>] abstract Create: ?config: EditorConfig -> Editor
        abstract create: [<ParamArray>] args: Array<obj> -> unit

    type [<AllowNullLiteral>] EditorReadyEvent =
        abstract name: string with get, set
        // abstract args: with get, set

    type [<AllowNullLiteral>] EditorDestroyEvent =
        abstract name: string with get, set
        // abstract args:  with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] EditorState =
        | Initializing
        | Ready
        | Destroyed