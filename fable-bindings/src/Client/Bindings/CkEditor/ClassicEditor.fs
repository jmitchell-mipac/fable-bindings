namespace Client.Bindings.CkEditor

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types
open Client.Bindings.CkEditor.Core.EditorConfig

module ClassicEditor =
// type Editor = Ckeditor5_src_core.Editor
// type Context = Ckeditor5_src_core.Context
// type EditorConfig = Ckeditor5_src_core.EditorConfig
// type ContextWatchdog = Ckeditor5_src_watchdog.ContextWatchdog
// type EditorWatchdog = Ckeditor5_src_watchdog.EditorWatchdog


    let [<Import("ClassicEditor_base","module")>] ClassicEditor_base: obj = jsNative
    type SourceElementOrData =
        | SourceElement of HTMLElement
        | SourceData of string

    type [<AllowNullLiteral>] ClassicEditor =
        // inherit ClassicEditor_base
        // abstract ui: ClassicEditorUI
        abstract destroy: unit -> Promise<obj>
        [<EmitConstructor>]
        abstract Create: sourceElementOrData: SourceElementOrData * ?config: EditorConfig -> ClassicEditor
        abstract create: sourceElementOrData: SourceElementOrData * ?config: EditorConfig -> Promise<ClassicEditor>
        abstract Context: obj with get, set
        abstract EditorWatchdog: obj with get, set
        abstract ContextWatchdog: obj with get, set




