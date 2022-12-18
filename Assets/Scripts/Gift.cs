using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    [SerializeField] GameObject gift;
    public static int giftcount=10;
    Lose lose = new Lose();

    private void Update()
    {
        if (giftcount <= 0)
        {
            lose.Losee();
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(giftcount);
            if (giftcount > 0)
            {
                Instantiate(gift, transform.position, Quaternion.identity);
                giftcount--;
            }
            

        }
    }

}
