using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void Reload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
