namespace Client.Bindings.CkEditor.Core

open System
open Client.Bindings.CkEditor.Core.Context
open Fable.Core
open Fable.Core.JS

module EditorConfig =

    type Array<'T> = System.Collections.Generic.IList<'T>

    // type PluginConstructor = ___plugin.PluginConstructor

    type [<StringEnum>] [<RequireQualifiedAccess>] PoweredByConfigPosition =
        | Inside
        | Border

    type [<StringEnum>] [<RequireQualifiedAccess>] PoweredByConfigSide =
        | Left
        | Right

    type [<AllowNullLiteral>] LanguageConfig =
        abstract ui: string option with get, set
        abstract content: string option with get, set

    type [<AllowNullLiteral>] ToolbarConfigItemCase2 =
        // abstract items: Array<ToolbarConfigItem> with get, set
        abstract label: string with get, set
        abstract icon: string option with get, set
        abstract withText: bool option with get, set
        abstract tooltip: U3<bool, string, (string -> string option -> string)> option with get, set

    // type ToolbarConfigItem = Item of string

    type ToolbarConfig =
        | Items of Array<string>
        | Record of {| items: Array<string> option; removeItems: Array<string> option; shouldNotGroupWhenFull: bool option; icon: string option |}

    /// The “Powered by CKEditor” logo configuration options.
    type [<AllowNullLiteral>] PoweredByConfig =
        abstract position: PoweredByConfigPosition with get, set
        abstract side: PoweredByConfigSide with get, set
        abstract label: string option with get, set
        abstract verticalOffset: float with get, set
        abstract horizontalOffset: float with get, set
        abstract forceVisible: bool option with get, set

    /// The offset (in pixels) of the viewport from every direction used when positioning a sticky toolbar or other
    /// absolutely positioned UI elements.
    type [<AllowNullLiteral>] ViewportOffsetConfig =
        /// The bottom offset in pixels.
        abstract bottom: float option with get, set
        /// The left offset in pixels.
        abstract left: float option with get, set
        /// The right offset in pixels.
        abstract right: float option with get, set
        /// The top offset in pixels.
        abstract top: float option with get, set

    type [<AllowNullLiteral>] UiConfig =
        abstract viewportOffset: ViewportOffsetConfig option with get, set
        abstract poweredBy: PoweredByConfig option with get, set

    type Language =
        | LanguageCode of string
        | Config of LanguageConfig

    type [<AllowNullLiteral>] EditorConfig =
        abstract context: Context option with get, set
        // abstract extraPlugins: Array<PluginConstructor<Editor>> option with get, set
        // abstract initialData: U2<string, Record<string, string>> option with get, set
        abstract language: Language option with get, set
        // abstract placeholder: U2<string, Record<string, string>> option with get, set
        // abstract plugins: Array<U2<PluginConstructor<Editor>, string>> option with get, set
        // abstract removePlugins: Array<U2<PluginConstructor<Editor>, string>> option with get, set
        // abstract substitutePlugins: Array<PluginConstructor<Editor>> option with get, set
        abstract toolbar: ToolbarConfig option with get, set
        abstract ui: UiConfig option with get, set
        abstract updateSourceElementOnDestroy: bool option with get, set
        abstract licenseKey: string option with get, set