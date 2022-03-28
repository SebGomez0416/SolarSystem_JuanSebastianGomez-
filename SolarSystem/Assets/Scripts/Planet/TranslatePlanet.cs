using UnityEngine;
using Random = UnityEngine.Random;

public class TranslatePlanet: MonoBehaviour
{
    [SerializeField]float speed;
    [SerializeField] private GameObject target;
    private int direction;

    private void Start()
    {
        do{
            direction = Random.Range(-1,2);
        } while (direction == 0);
    }

    void Update()
    {
        transform.RotateAround(target.transform.position,transform.up,(speed*direction)*Time.deltaTime);
    }
}




