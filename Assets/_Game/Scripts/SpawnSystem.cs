using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField]
    private float spawnDelay;
    [SerializeField]
    private GameObject asteroidPrefab;
    [SerializeField]
    private float radius;

    private float delay;

    private void Awake(){
        delay = spawnDelay;
    }

    private void Update(){
        delay -= Time.deltaTime;
        if(delay <= 0){
            SpawnAsteroid();
            delay = spawnDelay;
        }
    }

    private void SpawnAsteroid(){
        float ang = Random.Range(0,360);
        float x = Mathf.Cos(ang);
        float y = Mathf.Sin(ang);
        Instantiate(asteroidPrefab, transform.position + radius * new Vector3(x, y, 0), Quaternion.Euler(0,0,0));
    }
}
