using UnityEngine;

public class ViewTilt : MonoBehaviour
{

    [SerializeField]
    private float tilt;
    [SerializeField]
    private float smoothMulti;

    private Vector2 inp;

    private void Update(){
        inp = new Vector2(-Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"));
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(inp.x * tilt, inp.y * tilt, 0), Time.deltaTime * smoothMulti);
    }
}
