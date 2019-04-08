# WParameter
Parameter class which shifts address and negative states everytime the value changes. These classes are created to avoid being hacked.

# Samples
```C#
WFloat param = new WFloat();//Or new WFloat(12.3f);
param.Value = 15.3f;//Set
float a = param.Value;//Get
//WInt, WBool and WBigInt are all the same.
