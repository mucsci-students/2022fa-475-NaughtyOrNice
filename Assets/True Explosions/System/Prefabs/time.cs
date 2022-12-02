using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
    public float Life = 6f;
    private float elapsedTime = 0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > Life)
        {   
            Destroy (gameObject);
	        elapsedTime = 0f;
        }
    }
}
