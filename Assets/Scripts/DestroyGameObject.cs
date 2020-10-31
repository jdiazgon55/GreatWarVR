using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{

    public GameObject gameObjectToDestroy;

    void destroyGameObject()
    {
        if (gameObjectToDestroy != null) {
            Destroy(gameObjectToDestroy);
        }
    }
}
