using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCheck : MonoBehaviour
{
    public GameObject squirrelPrefab;
    public bool EventTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var position = GetComponent<Transform>().position;
        if (position.x > 120 && !EventTriggered)
        {
            EventTriggered = true;
            GameObject newSquirrel = Instantiate(squirrelPrefab);
            newSquirrel.GetComponent<Transform>().position = new Vector2(114, 20);
            newSquirrel.GetComponent<Transform>().Rotate(new Vector3(0, 180));
        }
    }
}
