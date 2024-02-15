namespace Client.Bindings.Feliz.MaterialUI

open System.ComponentModel
open Fable.Core
open Feliz
open Fable.Core.JsInterop


[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module MuiHelpers =
    open Fable.React

    let reactElement (el: ReactElementType) (props: 'a) : ReactElement =
        import "createElement" "react"

    let reactElementTag (tag: string) (props: 'a) : ReactElement =
        import "createElement" "react"

    let createElement (el: ReactElementType) (properties: IReactProperty seq) : ReactElement =
        reactElement el (!!properties |> Object.fromFlatEntries)

    let createElementTag (tag: string) (properties: IReactProperty seq) : ReactElement =
        reactElementTag tag (!!properties |> Object.fromFlatEntries)

[<Erase>]
type Mui =
    static member inline button props = createElement (import "Button" "@mui/material") props
    static member inline button (children: #seq<ReactElement>) = createElement (import "Button" "@mui/material") [ button.children (children :> seq<ReactElement>) ]

    static member inline buttonBase props = createElement (import "ButtonBase" "@mui/material") props
    static member inline buttonBase (children: #seq<ReactElement>) = createElement (import "ButtonBase" "@mui/material") [ buttonBase.children (children :> seq<ReactElement>) ]
    static member inline card props = createElement (import "Card" "@mui/material") props
    static member inline cardContent props = createElement (import "CardContent" "@mui/material") props
    static member inline cardActionArea props = createElement (import "CardActionArea" "@mui/material") props
    static member inline cardActionArea (children: #seq<ReactElement>) = createElement (import "CardActionArea" "@mui/material") [ cardActionArea.children (children :> seq<ReactElement>) ]
    static member inline cardActions props = createElement (import "CardActions" "@mui/material") props
    static member inline cardActions (children: #seq<ReactElement>) = createElement (import "CardActions" "@mui/material") [ cardActions.children (children :> seq<ReactElement>) ]
    static member inline collapse props = createElement (import "Collapse" "@mui/material") props
    static member inline collapse (children: #seq<ReactElement>) = createElement (import "Collapse" "@mui/material") [ collapse.children (children :> seq<ReactElement>) ]
    static member inline grid props = createElement (import "Grid" "@mui/material") props
    static member inline grid (children: #seq<ReactElement>) = createElement (import "Grid" "@mui/material") [ grid.children (children :> seq<ReactElement>) ]

module imports =
    let muiButton: obj = importDefault "@mui/material/Button"
    let muiList: obj = importDefault "@mui/material/List"
    let muiListItem: obj = importDefault "@mui/material/ListItem"
    let muiListItemText: obj = importDefault "@mui/material/ListItemText"
    let muiListItemButton: obj = importDefault "@mui/material/ListItemButton"
    let muiIconButton: obj = importDefault "@mui/material/IconButton"
    let muiDeleteIcon: obj = importDefault "@mui/icons-material/Delete"
    let muiExpandMore: obj = importDefault "@mui/icons-material/ExpandMore"
    let muiExpandLess: obj = importDefault "@mui/icons-material/ExpandLess"
    let muiCollapse: obj = importDefault "@mui/material/Collapse"
    let muiCard: obj = importDefault "@mui/material/Card"
    let muiCardContent: obj = importDefault "@mui/material/CardContent"
    let muiGrid: obj = importDefault "@mui/material/Grid"

type MuiProp =
    static member inline Variant (v: string) = Interop.mkAttr "variant" v
    static member inline Color (v: string) = Interop.mkAttr "color" v
    static member inline Size (v: string) = Interop.mkAttr "size" v

type MuiButton = private U of MuiProp with
    static member inline create props = Interop.reactApi.createElement (imports.muiButton, createObj !!props)

type MuiIconButton =
    static member inline edge (v: string) = Interop.mkAttr "edge" v
    static member inline create props = Interop.reactApi.createElement (imports.muiIconButton, createObj !!props)

type MuiDeleteIcon =
    static member inline create props = Interop.reactApi.createElement (imports.muiDeleteIcon, createObj !!props)

type MuiExpandMoreIcon =
    static member inline create props = Interop.reactApi.createElement (imports.muiExpandMore, createObj !!props)

type MuiExpandLessIcon =
    static member inline create props = Interop.reactApi.createElement (imports.muiExpandLess, createObj !!props)


type MuiList =
    static member inline sx (v: obj) = Interop.mkAttr "sx" v
    static member inline Dense (v: bool) = Interop.mkAttr "dense" v
    static member inline create props = Interop.reactApi.createElement (imports.muiList, createObj !!props)

type MuiListItem =
    static member inline create props = Interop.reactApi.createElement (imports.muiListItem, createObj !!props)

type MuiListItemText =
    static member inline Primary (v: string) = Interop.mkAttr "primary" v
    static member inline create props = Interop.reactApi.createElement (imports.muiListItemText, createObj !!props)

type MuiListItemButton =
    static member inline create props = Interop.reactApi.createElement (imports.muiListItemText, createObj !!props)

type MuiCollapse =
    static member inline In (v: bool) = Interop.mkAttr "in" v
    static member inline create props = Interop.reactApi.createElement (imports.muiCollapse, createObj !!props)

type MuiCard =
    static member inline create props = Interop.reactApi.createElement (imports.muiCard, createObj !!props)

type MuiCardContent =
    static member inline create props = Interop.reactApi.createElement (imports.muiCardContent, createObj !!props)

type MuiGrid =
    static member inline create props = Interop.reactApi.createElement (imports.muiGrid, createObj !!props)
    static member inline container (v: bool) = Interop.mkAttr "container" v
    static member inline item (v: bool) = Interop.mkAttr "item" v
    static member inline rowSpacing (v: int) = Interop.mkAttr "rowSpacing" v
    static member inline columnSpacing (v: int) = Interop.mkAttr "columnSpacing" v
    static member inline direction (direction: FlexDirection) = Interop.mkAttr "direction" direction
    static member inline xs (v: int) = Interop.mkAttr "xs" v
    static member inline sm (v: int) = Interop.mkAttr "sm" v
    static member inline md (v: int) = Interop.mkAttr "md" v