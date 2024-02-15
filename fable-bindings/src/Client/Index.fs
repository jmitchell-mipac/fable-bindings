module Index

open Client.Bindings.CkEditor.ClassicEditor
open Client.Bindings.CkEditor.Core.Context
open Client.Bindings.CkEditor.Core.EditorConfig
open Client.Bindings.CkEditor
open Elmish
open Fable.Remoting.Client
open Shared
open Fable.Core.JsInterop



type Model = { Todos: Todo list; Input: string }

let init () =
    let model = { Todos = []; Input = "" }
    model, Cmd.none

let update msg model =
    model, Cmd.none

open Feliz

let sourceElement = SourceElementOrData.SourceData "#editor"
let config: EditorConfig = createEmpty<EditorConfig>
config.context <- Some createEmpty<Context>
config.language <- Some (Language.LanguageCode "en")
config.licenseKey <- Some "123"



let editor = classicEditor


let view model dispatch =
    Html.section [
        prop.children [
            Html.h1 [
                prop.text "CkEditor 5 Fable Bindings"
            ]
            Html.div [
                prop.id "editor"
            ]

            CkEditor.create [
                CkEditor.editor editor
            ]
        ]

    ]