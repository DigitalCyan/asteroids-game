using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private float n_ang;
    private float ang;
    private float vel;

    private void Update(){
        if(Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
            n_ang = Mathf.Atan2(-Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * Mathf.Rad2Deg;
            ang = Mathf.SmoothDampAngle(ang, n_ang, ref vel, 0.1f);

        transform.rotation = Quaternion.Euler(0, 0, ang);
    }
}
