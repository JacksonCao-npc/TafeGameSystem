using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeBlood : MonoBehaviour
{
    public static int bloodCount;
    public int internalBlood;


    private void Update()
    {
        internalBlood = bloodCount;
    }
}
