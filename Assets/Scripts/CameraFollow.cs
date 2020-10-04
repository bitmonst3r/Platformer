using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player == null)
        {
            player = GameObject.Find("Ethan");
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
