using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float deadzone;

    private float n_ang;
    private float ang;
    private float vel;

    private void Update(){
        if(Mathf.Abs(Input.GetAxisRaw("Vertical")) > deadzone || Mathf.Abs(Input.GetAxisRaw("Horizontal")) > deadzone)
            n_ang = Mathf.Atan2(-Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * Mathf.Rad2Deg;
            ang = Mathf.SmoothDampAngle(ang, n_ang, ref vel, 0.1f);

        transform.rotation = Quaternion.Euler(0, 0, ang);
    }
}
