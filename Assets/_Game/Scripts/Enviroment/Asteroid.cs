using UnityEngine;

public class Asteroid : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private GameObject explosion;

    private Vector3 dir;

    private Rigidbody r;

    private void Awake(){
        r = GetComponent<Rigidbody>();
        dir = GameObject.Find("Root").transform.position - transform.position;
    }

    private void Update(){
        transform.Translate(dir * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision col){
        if(col.transform.CompareTag("Projectile")){
            Destroy(col.gameObject);
            Instantiate(explosion,transform.position, transform.rotation);
            Destroy(gameObject);
        }else if(col.transform.CompareTag("Planet")){
            GameController.instance.GameOver();
        }
    }

    public void BlowUp(){
        Instantiate(explosion,transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
