namespace Client.Bindings.CkEditor.Core

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

module Context =

    type Array<'T> = System.Collections.Generic.IList<'T>

    // type Config = @ckeditor_ckeditor5_utils.Config
    // type Collection = @ckeditor_ckeditor5_utils.Collection
    // type Locale = @ckeditor_ckeditor5_utils.Locale
    // type LocaleTranslate = @ckeditor_ckeditor5_utils.LocaleTranslate
    // type LoadedPlugins = __plugin.LoadedPlugins
    // type PluginConstructor = __plugin.PluginConstructor
    // type EditorConfig = __editor_editorconfig.EditorConfig
    type [<AllowNullLiteral>] Context =
        // abstract config: Config<ContextConfig>
        // abstract plugins: PluginCollection<U2<Context, Editor>>
        // abstract locale: Locale
        // abstract t: LocaleTranslate
        // abstract editors: Collection<Editor>
        // abstract initPlugins: unit -> Promise<LoadedPlugins>
        abstract destroy: unit -> Promise<obj>
        // abstract _addEditor: editor: Editor * isContextOwner: bool -> unit
        // abstract _removeEditor: editor: Editor -> Promise<obj>
        abstract _getEditorConfig: unit -> obj

    type [<AllowNullLiteral>] ContextConfig =
        interface end

    type [<AllowNullLiteral>] ContextStatic =
        abstract defaultConfig: ContextConfig with get, set
        // abstract builtinPlugins: Array<PluginConstructor<U2<Context, Editor>>> with get, set
        [<EmitConstructor>] abstract Create: ?config: ContextConfig -> Context
        abstract create: ?config: ContextConfig -> Promise<Context>

    type [<AllowNullLiteral>] IExports =
        abstract Context: ContextStatic




