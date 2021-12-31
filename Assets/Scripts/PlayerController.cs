using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{

    private float HorizontalInput;
    private float Verticalinput;
    public float speed = 20;
    public float xRange = 15;
    public float zRange = 9;
    public GameObject foodSpawn;

    PhotonView view;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    void LateUpdate()
    {
        if (view.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(foodSpawn, transform.position, foodSpawn.transform.rotation);
            }

            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
            else if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
            else if (transform.position.z > zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
            }
            else if (transform.position.z < -(zRange - 1))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -zRange + 1);
            }

            HorizontalInput = Input.GetAxis("Horizontal");
            Verticalinput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalInput);
            transform.Translate(Vector3.forward * Time.deltaTime * speed * Verticalinput);
        }
        
    }
}
