using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class Shuriken : MonoBehaviour
{
    double timeElapsed = 0;

    public static Vector2 CalcVelocity(Vector2 originPosition)
    {
        double magnitude = 70;
        Vector2 mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        double theta = Math.Atan2(mousePosition.y - originPosition.y, mousePosition.x - originPosition.x);
        return new Vector2(Convert.ToSingle(Math.Cos(theta) * magnitude), Convert.ToSingle(Math.Sin(theta) * magnitude));
    }

    public void Update()
    {
        var trans = GetComponent<Transform>();
        trans.Rotate(new Vector3(0, 0, 15));
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 4)
        {
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(this.gameObject);
    }

}
