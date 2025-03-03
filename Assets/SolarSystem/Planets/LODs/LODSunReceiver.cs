﻿// Copyright Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

public class LODSunReceiver : MonoBehaviour
{
    public Transform Sun;
    public Material planetLod;

    private void Update()
    {
        if (Sun)
        {
            planetLod.SetVector("_SunPosition", Sun.position);
        }
    }
}
