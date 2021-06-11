using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrack : MonoBehaviour
{
    CharacterController controller;
    public Vector3 dir;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        controller.Move(dir * Time.fixedDeltaTime);
    }
}
