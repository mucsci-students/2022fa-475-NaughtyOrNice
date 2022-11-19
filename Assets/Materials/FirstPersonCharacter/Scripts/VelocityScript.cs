using UnityEngine;
public class VelocityScript : MonoBehaviour
{
    Vector3 direction;
    public float speed = 10;
    public float bulletLife = 2f;
    private float elapsedTime = 0f;
    

    void Start()
    {
        direction = Camera.main.transform.forward;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        transform.position += direction * Time.deltaTime * speed;
        if (elapsedTime > bulletLife)
        {   
            Destroy (gameObject);
	        elapsedTime = 0f;
        }
    }

}
