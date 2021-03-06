﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBoxController : MonoBehaviour
{
    GameObject director;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "blue")
        {
            Debug.Log("blue");
            this.director.GetComponent<GameDirector>().BlueBoxGetBlue();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "red")
        {
            Debug.Log("red");
            this.director.GetComponent<GameDirector>().BlueBoxGetRed();
            Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
