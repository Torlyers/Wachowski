﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : Player
{

    private void Awake()
    {
        Instance = this;
    }
}
