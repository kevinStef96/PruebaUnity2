﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main instance;
    public Web web;
    void Start(){
        instance=this;
        web=GetComponent<Web>();
    }
}
