using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_Up : MonoBehaviour
{
    public float x;
    void Update()
    {
        transform.Translate(0, x, 0);
    }
}
