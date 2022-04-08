using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * (speed * Time.deltaTime));

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.down * (rotateSpeed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * (rotateSpeed * Time.deltaTime));
    }
}
