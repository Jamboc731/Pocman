using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PC : MonoBehaviour
{

    [SerializeField] float moveSpeed;

    Rigidbody rb;

    Vector3 moveDir;

    public Node nod;

    float xIn, zIn;

    public static PC x;

    public void Start()
    {

        if (x == null) x = this;
        else Destroy(gameObject);

        gameObject.tag = "Player";
        rb = GetComponent<Rigidbody>();
    }

    public void SpeedIncrease()
    {
        moveSpeed += 0.5f;
        transform.localScale *= 1.1f;
    }

    public void Update()
    {
        xIn = Input.GetAxisRaw("Horizontal");
        zIn = Input.GetAxisRaw("Vertical");
    }

    public void FixedUpdate()
    {
        rb.MovePosition(transform.position + new Vector3(xIn, 0, zIn) * moveSpeed * Time.deltaTime);
    }

}
