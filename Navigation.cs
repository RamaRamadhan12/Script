﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pindahScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void keluar()
    {
        Application.Quit();
        Debug.Log("Metu");
    }
}
