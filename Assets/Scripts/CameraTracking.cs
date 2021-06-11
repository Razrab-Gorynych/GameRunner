using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public GameObject player;
    private Vector3 set;

    void Start()
    {
        set = transform.position - player.transform.position;
    }


    void FixedUpdate()
    {
        transform.position = player.transform.position + set;
    }
}
