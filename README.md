# F# Mutable Variable Swap Issue

This repository demonstrates an unexpected behavior related to mutable variables in F#.  The `swap` function, intended to swap the values of two mutable variables, doesn't behave as one might expect from languages like C# or Java. This is due to F#'s functional nature and the way it handles mutable variables. The solution showcases a correct approach for swapping mutable variable values in F#.

## Bug Description

The original `swap` function attempts to swap the values of two mutable integer variables using a temporary variable. However, because F# values are immutable, the assignment operations within the `swap` function modify copies of the parameters, rather than the original variables passed into the function. Therefore, the swap operation appears to fail. 

## Solution

The solution demonstrates the correct way to swap mutable variables in F#.  This is done by explicitly passing the variables by reference using the `&` operator.  The use of `&` enables modifications to the original variables passed to the function, which resolves the issue.
