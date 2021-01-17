using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPositionOverCrate : MonoBehaviour
{
    public float yDisplacement = 1.0f; // The y displacement from the crate
    public GameObject crate;           // The crate to add y displacement

    private OVRGrabbable grabbable;

    // Start is called before the first frame update
    void Start()
    {
        grabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x, crate.transform.position.y + yDisplacement, transform.position.z);
        if (grabbable.isGrabbed)
        {
            Destroy(GetComponent<FixPositionOverCrate>());
        }
    }
}
