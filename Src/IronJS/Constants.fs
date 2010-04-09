﻿module IronJS.Constants

let maxTypedArgs  = 125

let clrDynamic = typeof<obj>
let clrDynamicHashCode = clrDynamic.GetHashCode()

let clrDouble = typeof<double>
let clrDoubleHashCode = clrDouble.GetHashCode()

let clrString = typeof<string>
let clrStringHashCode = clrString.GetHashCode()

let clrVoid = typeof<System.Void>
let clrVoidHashCode = clrVoid.GetHashCode()

let clrDelegate = typeof<System.Delegate>
let clrDelegateHashCode = clrDelegate.GetHashCode()

let strongBoxTypeDef = typedefof<System.Runtime.CompilerServices.StrongBox<_>>