using System.Collections;
using UnityEngine;

public class DestructionTimer : MonoBehaviour
{
    [SerializeField]
    private float time;

    private void Awake()
    {
        StartCoroutine(TriggerTimer(time));
    }

    private IEnumerator TriggerTimer(float t){
        yield return new WaitForSeconds(t);
        Destroy(gameObject);
    }

}
