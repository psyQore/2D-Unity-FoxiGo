﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Transform farBackground, middleBackground;

    public float lastXPos;
        

    // Start is called before the first frame update
    void Start()
    {
        lastXPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);

        float ammountToMoveX = transform.position.x - lastXPos;

        farBackground.position = farBackground.position + new Vector3(ammountToMoveX, 0f, 0f);
        middleBackground.position += new Vector3(ammountToMoveX * .5f, 0f, 0f);

        lastXPos = transform.position.x;

    }
}
