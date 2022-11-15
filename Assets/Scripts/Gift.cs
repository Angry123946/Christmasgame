using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    [SerializeField] GameObject gift;
    public static int giftcount=10;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(giftcount);
            if (giftcount > 0)
            {
                Instantiate(gift, transform.position, Quaternion.identity);
                giftcount--;
            }
            else
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
            }

        }
    }

}
