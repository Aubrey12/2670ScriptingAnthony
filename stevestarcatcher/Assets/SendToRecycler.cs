﻿using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour
{

    bool canRecycle;
    public static Action<SendToRecycler> SendThis;

    // Use this for initialization
    void Start()
    {
        if (canRecycle && SendThis != null)
            SendThis(this);

    }

}