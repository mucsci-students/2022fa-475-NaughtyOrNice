using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform Playerpos;
    UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
       agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        
          agent.destination = Playerpos.position;    
        
    }

    void OnTriggerEnter (Collider collider) {
		GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag) {
			Destroy (gameObject);
			Destroy (collidedWith);
        }
    }
}
