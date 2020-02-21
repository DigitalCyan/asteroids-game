using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour
{

    [SerializeField]
    private Transform UIRoot;

    static public GameController instance;

    [SerializeField]
    private GameObject planet;
    [SerializeField]
    private GameObject playerRoot;
    [SerializeField]
    private GameObject explosionPrefab;

    private void Awake(){
        instance = this;
        Cursor.visible = false;
    }

    private void Update(){
        if(Input.GetButtonDown("Start")){
            SpawnSystem.instance.enabled = true;
            Destroy(UIRoot.gameObject);
        }
    }

    public void GameOver(){
        Instantiate(explosionPrefab, GameObject.Find("Planet").transform.position, Quaternion.Euler(0,0,0));
        SpawnSystem.instance.enabled = false;
        foreach(GameObject a in GameObject.FindGameObjectsWithTag("Asteroid")){
            a.GetComponent<Asteroid>().BlowUp();
        }
        Destroy(planet);
        Destroy(playerRoot);
        StartCoroutine(EndgameTimer(5));
        StartCoroutine(RumbleHandler.Rumble(0, 0));
    }

    private IEnumerator EndgameTimer(float t){
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
