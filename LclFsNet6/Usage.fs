// (c) $year$  $registeredorganization$ / $username$
module Usage

open CommonTools
open PrintUtils

let usage detailed =
  py "General description"
  pn ""
  py "$safeprojectname$ <arguments>"
  pn "   (DESCRIPTION)"
  p2 "-v               Verbose mode"



