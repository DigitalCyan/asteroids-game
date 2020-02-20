using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField]
    private float speed;

    private Rigidbody r;
    private Vector3 dir;

    private void Awake(){
        r = GetComponent<Rigidbody>();
        dir = GameObject.Find("Player").transform.position - GameObject.Find("Root").transform.position;
    }

    private void Update()
    {
        r.velocity = dir * speed * Time.deltaTime;
    }
}
