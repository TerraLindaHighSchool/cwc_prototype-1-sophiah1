﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    void Update()
    {
        transform.position = player.transform.position + offset;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
