using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZopMove : MonoBehaviour
{
    private float spin = 30f;
    private float spin2 = 90;
    private float elapsedTime = 0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spin)
        {
            while (spin2 > elapsedTime - 30)
            {
                transform.Rotate(0, 2, 0);
            }
        }
    } 
}
