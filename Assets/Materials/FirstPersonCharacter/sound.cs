using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{

    private float bulletLife = 2f;
    private float elapsedTime = 0f;
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > bulletLife)
        {   
            Destroy (gameObject);
	        elapsedTime = 0f;
        }
    }
}
