using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Generator
{
    public static void GenerateOffset(List<Transform> obj)
    {
        foreach (var ob in obj)
        {
            var offset = ob.localPosition;

            if (ob.localPosition.z < 0)
                ob.localPosition += new Vector3(0, 0, Random.Range(-0.5f,2.5f));
            else if (ob.localPosition.z > 0) ob.localPosition += new Vector3(0, 0, Random.Range(0.5f,-2.5f));
        }
    }
}
