﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafolow : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 temp = transform.position;
            temp.x = player.position.x;
            temp.y = player.position.y;
            transform.position = temp;
        }
    }
}
