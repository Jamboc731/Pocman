using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    [SerializeField] Transform other;
    Collider c;

    public void Start()
    {
        c = GetComponent<Collider>();
    }

    public void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
            c.transform.position = other.position;
            other.GetComponent<BarrierScript>().holup();
        }
    }

    public void holup()
    {
        StartCoroutine(WAIT());
    }

    IEnumerator WAIT()
    {
        c.enabled = false;
        yield return new WaitForSeconds(0.5f);
        c.enabled = true;
    }

}
