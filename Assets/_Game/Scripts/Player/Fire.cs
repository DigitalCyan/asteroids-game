using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private float offset;

    private AudioSource audio;

    private void Awake(){
        audio = GetComponent<AudioSource>();
    }

    private void Update(){
        if(Input.GetButtonDown("Fire1")){
            audio.PlayOneShot(audio.clip);
            Instantiate(projectilePrefab, transform.position + transform.up * offset, transform.rotation);
            StartCoroutine(RumbleHandler.Rumble(0.1f, 0.5f));
        }
    }

}
