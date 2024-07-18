using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {

        int n = arr.Count;
        int SumP = 0;
        int SumS = 0;

        for (int i = 0; i < n; i++)
        {
            SumP += arr[i][i];

            SumS += arr[i][n - 1 - i];
        }
        return Math.Abs(SumP - SumS);
    }
}
