using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class waller : MonoBehaviour
{
    float count = 2.0f;
    public GameObject expl;
    public GameObject erase;
    void OnTriggerEnter (Collider collider) {
		GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag) {
			count--;
        }
        if(count <= 1) {
            Instantiate(expl, gameObject.transform.position, transform.rotation);
            Destroy (erase);
			Destroy (collidedWith);
        }
    }
}
