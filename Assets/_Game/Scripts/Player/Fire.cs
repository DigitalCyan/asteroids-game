using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private float offset;

    private void Update(){
        if(Input.GetButtonDown("Fire1")){
            Instantiate(projectilePrefab, transform.position + transform.up * offset, transform.rotation);
            StartCoroutine(RumbleHandler.Rumble(0.1f, 0.5f));
        }
    }

}
