namespace Client.Bindings.CkEditor

open Client.Bindings.CkEditor.ClassicEditor
open Client.Bindings.CkEditor.Core.Context
open Client.Bindings.CkEditor.Core.EditorConfig
open Fable.Core.JsInterop

module test =

    let testMethod () =
        let sourceElement = SourceElementOrData.SourceData "#editor"
        let config: EditorConfig = createEmpty<EditorConfig>
        config.context <- Some createEmpty<Context>
        config.language <- Some (Language.LanguageCode "en")
        config.licenseKey <- Some "123"

        let classicEditor = createEmpty<ClassicEditor>.Create (sourceElement, config)
        classicEditor


