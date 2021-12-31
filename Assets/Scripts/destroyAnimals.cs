using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class destroyAnimals : MonoBehaviour
{
    private float upperBound = 30;
    private float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
