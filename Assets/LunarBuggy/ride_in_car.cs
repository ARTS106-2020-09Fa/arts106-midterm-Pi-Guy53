﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ride_in_car : MonoBehaviour
{
    [SerializeField]
    GameObject Drive_Train;
    [SerializeField]
    GameObject FPS;
    [SerializeField]
    GameObject Video;

    private void OnTriggerStay(Collider Player)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Drive_Train.SetActive(true);
            Video.SetActive(true);
            FPS.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Drive_Train.SetActive(false);
            Video.SetActive(false);
            FPS.SetActive(true);
        }
    }

}
