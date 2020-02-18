using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowScript : MonoBehaviour
{
    Update()
    {
        if (IsTaskCompleted())
        {
            object.SetActive(true);
        }
    }
}
