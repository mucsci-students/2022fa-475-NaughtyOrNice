using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class BodyHealth : MonoBehaviour
{
    public GameObject FPC;
    public Camera m_Camera;
    public float playerDistance;
    public Vector3 playerDirection;

    // Start is called before the first frame update
    void Start(){
        m_Camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(m_Camera.transform.position, gameObject.transform.position);
        playerDirection = m_Camera.transform.position - gameObject.transform.position;
        Vector3 zeroDirection = new Vector3(m_Camera.transform.position.x - gameObject.transform.position.x, 180, m_Camera.transform.position.z - gameObject.transform.position.z);
        Vector3 zeroCamera = new Vector3(m_Camera.transform.position.x, gameObject.transform.position.y, m_Camera.transform.position.z);    
        transform.LookAt(zeroCamera);
    }



    


}
