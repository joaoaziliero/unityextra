using Random = System.Random;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

public static class BasicUtil
{
    private static readonly Random _r = new();

    public static List<T> Randomize<T>(this List<T> list)
    {
        return list.OrderBy(element => _r.Next()).ToList();
    }

#if UNITY_EDITOR
    [MenuItem("Create/Cube")]
    private static void CreateCube()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
#endif
}
