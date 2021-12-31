using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class foodColider : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        ScoreSystem.scoreValue += 10;
        Destroy(gameObject);
        Destroy(other.gameObject);    
    }
}
