using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceOrientation : MonoBehaviour
{
    public ScreenOrientation orientation;

    private void Awake()
    {
        Screen.orientation = orientation;
    }


}
