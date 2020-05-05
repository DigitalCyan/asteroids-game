using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private float ang;
    private float tAng;

    private void Update(){
        tAng -= Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        if (Input.GetMouseButtonDown(1))
        {
            tAng += 180;
        }

        ang = Mathf.Lerp(ang, tAng, Time.deltaTime * 20);
        transform.rotation = Quaternion.Euler(0, 0, ang);
    }
}
