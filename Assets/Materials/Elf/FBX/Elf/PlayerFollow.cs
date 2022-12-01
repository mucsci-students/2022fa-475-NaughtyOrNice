using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform Playerpos;
    UnityEngine.AI.NavMeshAgent agent;
     public float PlayerRange = 40.0f;
    int count = 0;
    float walkRadius = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
       agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Playerpos.transform.position);
        if(distance < PlayerRange) {
		    agent.destination = Playerpos.position; 
        } else {
            Vector3 randomDirection = Random.insideUnitSphere * walkRadius;
            randomDirection += transform.position;
            agent.destination = randomDirection;
        }      
    }

    void OnTriggerEnter (Collider collider) {
		GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag) {
			count++;
        }
        if(count > 20) {
            Destroy (gameObject);
			Destroy (collidedWith);
        }
    }
}
