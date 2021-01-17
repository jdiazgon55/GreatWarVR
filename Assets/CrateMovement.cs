using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateMovement : MonoBehaviour
{
    public float yMovement = 0;
    public float speed;

    private Vector3 newYPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        newYPos = new Vector3(transform.position.x, yMovement, transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, newYPos, step);

    }
}
