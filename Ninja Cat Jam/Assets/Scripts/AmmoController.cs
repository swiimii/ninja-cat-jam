using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shuriken1, shuriken2, shuriken3;
    public float reloadDelay;

    private int ammo = 3;
    private float timeElapsed;
    private GameObject[] shurikens = new GameObject[3];

    private void Start()
    {
        shurikens[0] = shuriken1;
        shurikens[1] = shuriken2;
        shurikens[2] = shuriken3;
    }
    void Update()
    {
        if (ammo < 3)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > reloadDelay)
            {
                IncrementAmmo();
            }
        }

        for(int i = 0; i < 3; i++)
        {
            if(i >= ammo)
            {
                shurikens[i].GetComponent<Image>().enabled = false ;
            }
            else
            {
                shurikens[i].GetComponent<Image>().enabled = true;

            }
        }
        
    }

    void IncrementAmmo()
    {
        timeElapsed -= reloadDelay;
        ammo++;
        if(ammo == 3)
        {
            timeElapsed = 0;
        }
    }

    public void ExpendAmmo()
    {
        ammo--;
    }

    public bool HasAmmo()
    {
        return ammo > 0;
    }


}
