using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementFianl : MonoBehaviour
{
    float speed = 0.5f;
    private int count = 0;
    Vector3 pos;
    public GameObject zop;

    private void Start() {
        pos = transform.position;
    }
    void Update() {

        if(transform.position.y < 1.5f) {
            float newY = Time.time * speed + pos.y;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        } else if(count <= 3600) {
            count++; 
            zop.transform.Rotate(0, -0.05f, 0);
            pos = transform.position;
        } else if(count >= 3600 && transform.position.z < -6.5f) {

            float newZ = Time.time * 0.1f + pos.z;
            transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
        } else {
            SceneManager.LoadScene("MainMenu");
        }
    } 

}
