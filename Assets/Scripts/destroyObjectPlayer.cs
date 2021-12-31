using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObjectPlayer : MonoBehaviour
{
    public float objPosition = 40;
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > objPosition)
        {
            Destroy(gameObject);
        }
    }
}
