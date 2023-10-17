using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector2 temp = transform.position;
        temp.x = player.position.x;
        temp.y = player.position.y + 2.39f;

        transform.position = temp;
    }
}
