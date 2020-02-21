using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private float offset;

    private AudioSource a;

    private void Awake(){
        a = GetComponent<AudioSource>();
    }

    private void Update(){
        if(Input.GetButtonDown("Fire1")){
            a.PlayOneShot(a.clip);
            Instantiate(projectilePrefab, transform.position + transform.up * offset, transform.rotation);
            StartCoroutine(RumbleHandler.Rumble(0.1f, 0.5f));
        }
    }

}
