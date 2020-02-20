using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;

    private void Update(){
        if(Input.GetButtonDown("Fire1")){
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
