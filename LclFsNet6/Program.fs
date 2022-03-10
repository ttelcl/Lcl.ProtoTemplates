﻿// (c) $year$  $registeredorganization$ / $username$

open System

open CommonTools
open ExceptionTool
open Usage

let rec run arglist =
  // For subcommand based apps, split based on subcommand here
  match arglist with
  | "-v" :: rest ->
    verbose <- true
    rest |> run
  | "--help" :: _
  | "-h" :: _
  | [] ->
    usage verbose
    0
  | _ :: _ ->
    // TODO: actual processing based on command line arguments
    new NotImplementedException("$safeprojectname$.exe is not yet implemented") |> raise
    1

[<EntryPoint>]
let main args =
  try
    args |> Array.toList |> run
  with
  | ex ->
    ex |> fancyExceptionPrint verbose
    resetColor ()
    1



