module Client.Bindings.CkEditor

open Client.Bindings.CkEditor.ClassicEditor
open Fable.Core.JsInterop
open Feliz

let ckEditor: obj = import "CKEditor" "@ckeditor/ckeditor5-react"
let classicEditor: ClassicEditor = importDefault "@ckeditor/ckeditor5-build-classic"

[<ReactComponent>]

type CkEditor =
    static member inline editor (v: obj) = Interop.mkAttr "editor" v
    static member inline data (v: string) = Interop.mkAttr "data" v
    static member inline create props = Interop.reactApi.createElement (ckEditor, createObj !!props)
