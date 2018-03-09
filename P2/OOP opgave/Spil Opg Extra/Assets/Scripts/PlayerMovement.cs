using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float ForwardForce = 2000f;
    public float sidewaysForce = 500f;

    //Denne metode gør så spilleren rykker sig frem, ventsre og højre ud fra om a eller d er presset
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime, ForceMode.Force);	

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
