using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFire : MonoBehaviour
{
   
public void ClickFire()
    {
        GlobeFire.fireCount += 1;
        Debug.Log("fire +"+1);
    }
}
