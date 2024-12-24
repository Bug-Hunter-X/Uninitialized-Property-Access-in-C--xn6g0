# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property before it has been assigned a value.  Uninitialized properties will have default values (0 for integers, null for reference types), which can lead to unexpected results or exceptions if not handled correctly.

## Problem

The `MyProperty` in `ExampleClass` is never explicitly set before being used in the `MyMethod`.  This can lead to unexpected behaviour depending on the context and the default values of your properties.

## Solution

Always initialize properties before using them, either in the constructor or when the object is created.  Consider adding checks to handle the cases where the value is not expected.