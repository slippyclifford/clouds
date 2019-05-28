using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public bool isfollowing = true;
    public Transform player;
    public Transform Camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isfollowing = true)
        {
            transform.position = new Vector3(player.position.x, Camera.position.y, Camera.position.z);
        }
    }
}
