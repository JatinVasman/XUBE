using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce=2000f;
    public float sidewaysforce=500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is create

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }    
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y<-1f)
        {
          FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
