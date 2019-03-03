using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class Shuriken : MonoBehaviour
{
    double timeElapsed = 0;

    public static Vector2 CalcVelocity(Vector2 originPosition, float magnitude)
    {
        Vector2 mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

        print("origin x: " + originPosition.x);
        print("origin y: " + originPosition.y);
        print("mouse x: " + mousePosition.x);
        print("mouse y: " + mousePosition.y);

        double theta = Math.Atan2(mousePosition.y - originPosition.y, mousePosition.x - originPosition.x);
        print(theta);
        return new Vector2(Convert.ToSingle(Math.Cos(theta) * magnitude), Convert.ToSingle(Math.Sin(theta) * magnitude));
    }

    public void Update()
    {
        var trans = GetComponent<Transform>();
        var rb = GetComponent<Rigidbody2D>();
        trans.Rotate(new Vector3(0, 0, 15));
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 1)
        {
            Destroy(gameObject);
        }
    }

}
