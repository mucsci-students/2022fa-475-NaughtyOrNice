using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject coal;
public GameObject present;
public GameObject sound;
    public GameObject fireEnd;
    private float elapsedTime = 0f;
    public float reloadTime = 0f;

	void Update()
    {
            elapsedTime += Time.deltaTime;
            if (Input.GetKey(KeyCode.Mouse0) && (elapsedTime > reloadTime) )
            {  
                GameObject bullet = Instantiate(coal, fireEnd.transform.position, transform.rotation); 
                Rigidbody b = bullet.GetComponent<Rigidbody>();
                elapsedTime = 0f;
                Instantiate(sound, fireEnd.transform.position, transform.rotation);
            }
	    if (Input.GetKey(KeyCode.Mouse1) && (elapsedTime > reloadTime) )
            {  
                GameObject presentbullet = Instantiate(present, fireEnd.transform.position, transform.rotation); 
                Rigidbody b = presentbullet.GetComponent<Rigidbody>();
                elapsedTime = 0f;
                Instantiate(sound, fireEnd.transform.position, transform.rotation);
            }
            
        }

}

