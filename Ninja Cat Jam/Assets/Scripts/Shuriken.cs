using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class Shuriken : MonoBehaviour
{
    double timeElapsed = 0;

    public void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 1)
        {
            Destroy(this.gameObject);
        }
    }

}
