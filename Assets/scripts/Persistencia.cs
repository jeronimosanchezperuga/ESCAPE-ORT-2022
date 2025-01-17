﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Persistencia : MonoBehaviour
{
    public static Persistencia instance;
    public InventorySO inventario;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }

    }
    
}