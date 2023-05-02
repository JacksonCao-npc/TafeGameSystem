using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeFire : MonoBehaviour
{
    public static int fireCount;
    public int internalFire;

    public void Update()
    {
        internalFire = fireCount;
    }
}
