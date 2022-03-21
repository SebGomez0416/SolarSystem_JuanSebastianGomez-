using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField]float speed;
    
    void Update()
    {
        transform.Rotate(Vector3.down,speed);
    }
}
