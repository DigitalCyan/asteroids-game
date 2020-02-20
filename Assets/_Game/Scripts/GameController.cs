using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [SerializeField]
    private Transform UIRoot;

    private void Update(){
        if(Input.GetButtonDown("Start")){
            SpawnSystem.instance.enabled = true;
            Destroy(UIRoot.gameObject);
        }
    }

    public void Reload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        StartCoroutine(RumbleHandler.Rumble(0, 0));
    }
}
