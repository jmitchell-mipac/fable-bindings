module Index

open Client.Bindings.Feliz
open Client
open Client.Bindings.Feliz.MaterialUI

open Elmish
open Fable.Remoting.Client
open Shared
open Feliz
open Fable.Core.JsInterop


type Model = { Todos: Todo list; Input: string }

type Msg =
    | GotTodos of Todo list
    | SetInput of string
    | AddTodo
    | AddedTodo of Todo

let todosApi =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.buildProxy<ITodosApi>

let init () =
    let model = { Todos = []; Input = "" }
    model, Cmd.none

let update msg model =
    model, Cmd.none

let private card (title: string) =
    Mui.card [
        prop.style [
            style.backgroundColor "#ff9999"
            // style.boxShadow (1, 1, 10, 1, "rgba(0, 0, 0, 0.2)")
        ]
        prop.children [
            Mui.cardContent [
                prop.children [
                    Mui.grid [
                        MuiGrid.container true
                        prop.children [
                            MuiGrid.create [
                                MuiGrid.item true
                                MuiGrid.xs 10
                                prop.children [
                                    Html.h1 [
                                        prop.text title
                                    ]
                                ]

                            ]
                            Mui.grid [
                                MuiGrid.item true
                                MuiGrid.xs 2
                                prop.children [
                                    MuiDeleteIcon.create [
                                    ]
                                ]

                            ]

                        ]

                    ]

                ]
            ]
        ]
    ]

let view model dispatch =
    Html.section [
        prop.className "h-screen w-screen"

        prop.children [
            Html.a [
                prop.href "https://safe-stack.github.io/"
                prop.className "absolute block ml-12 h-12 w-12 bg-teal-300 hover:cursor-pointer hover:bg-teal-400"
                prop.children [ Html.img [ prop.src "/favicon.png"; prop.alt "Logo" ] ]
            ]

            Html.div [
                prop.className "flex items-center justify-center h-full"
                prop.style [
                    style.width 1500
                ]
                prop.children [
                    Html.h1 [
                        prop.className "text-center text-5xl font-bold text-white mb-3 rounded-md p-4"
                        prop.text "Feliz.Mui"
                    ]
                    MuiGrid.create [
                        MuiGrid.container true
                        MuiGrid.rowSpacing 2
                        MuiGrid.columnSpacing 3
                        MuiGrid.direction FlexDirection.Row

                        prop.children [

                            MuiGrid.create [
                                MuiGrid.item true
                                MuiGrid.xs 3
                                prop.style [
                                    style.rowGap 3
                                ]
                                prop.children [
                                    card "Monthly Fire Extinguisher and E-Light Checks"
                                ]

                            ]
                            MuiGrid.create [
                                MuiGrid.item true
                                MuiGrid.xs 3
                                prop.style [
                                    style.rowGap 3
                                ]
                                prop.children [
                                    card "RECORD FLOTATION LEVELS - BANK & TANK CELL"
                                ]

                            ]
                            MuiGrid.create [
                                MuiGrid.item true
                                MuiGrid.xs 3
                                prop.style [
                                    style.rowGap 3
                                ]
                                prop.children [
                                    card "GAS DETECTOR CHECK"
                                ]
                            ]
                            MuiGrid.create [
                                MuiGrid.item true
                                MuiGrid.xs 3
                                prop.style [
                                    style.rowGap 3
                                ]
                                prop.children [
                                    card "BEGINING OF ROSTER - REPLENISHMENT OF STOCKS - PPE"
                                ]
                            ]
                            MuiGrid.create [
                                MuiGrid.item true
                                MuiGrid.xs 3
                                prop.children [
                                    card "REPLENISHMENT OF STOCKS - PPE"
                                ]
                            ]

                            MuiGrid.create [
                                MuiGrid.item true
                                MuiGrid.xs 3
                                prop.children [
                                    card "DAILY CONVEYOR CHECKS"
                                ]
                            ]
                        ]
                    ]
                ]
            ]




        ]
    ]