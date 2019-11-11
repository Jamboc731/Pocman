using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutScript : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.x.GotNut();
        }
        else Debug.Log("Dummy thicholas is right");
    }

}
