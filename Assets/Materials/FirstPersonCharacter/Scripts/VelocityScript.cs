using UnityEngine;
public class VelocityScript : MonoBehaviour
{
    Vector3 direction;
    public float speed = 10;
    public float bulletLife = 2f;
    private float elapsedTime = 0f;
    
	//Rigidbody rigidBody = GetComponent<Rigidbody>();
	//GetComponent<Rigidbody>().velocity = new Vector3 (startSpeed, 0, startSpeed);

    void Start()
    {
        direction = Camera.main.transform.forward;
	Rigidbody rigidBody = GetComponent<Rigidbody>();
	GetComponent<Rigidbody>().velocity = direction * speed;

    }

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
