using UnityEngine;

public class ConstantRotation : MonoBehaviour
{

    [SerializeField]
    private Vector3 rotation;

    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
}
