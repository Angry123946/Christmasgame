using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    [SerializeField] GameObject gift;
    public static int giftcount=10;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (giftcount >= 0)
            {
                Instantiate(gift, transform.position, Quaternion.identity);
                giftcount--;
            }
            else { 
            Application.Quit();
            }
        }
    }

}
