using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{
    Rigidbody reigid;

    void Start()
    {
        reigid = GetComponent<Rigidbody>();
        //reigid.velocity = new Vector3(2, 4, -1);
        //reigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        /*reigid.velocity = new Vector3(2, 4, -1);

        if(Input.GetButton("Junmp"))
        {
            reigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log(reigid.velocity);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizonte"), 0, Input.GetAxisRaw("Vertical"));

        reigid.AddForce(vec, ForceMode.Impulse);
        

        reigid.AddTorque(Vector3.up);
        */

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        reigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            reigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {
        reigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
