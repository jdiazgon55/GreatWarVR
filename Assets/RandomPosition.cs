using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{

    public float xMaxLimit = 0.0f;
    public float yMaxLimit = 0.0f;
    public float zMaxLimit = 0.0f;

    public float xMinLimit = 0.0f;
    public float yMinLimit = 0.0f;
    public float zMinLimit = 0.0f;

    private SphereCollider collider;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(xMinLimit, xMaxLimit), 
            Random.Range(yMinLimit, yMaxLimit), 
            Random.Range(zMinLimit, zMaxLimit));

        transform.localPosition  = position;
        
        if (transform.parent != null) {
            collider = transform.parent.GetComponent<SphereCollider>();
            if (collider != null) {
                collider.center = position;
            }
        }

    }
}
