using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("User's Input is: W");
            inputVector += Vector2.up;
        }
        if(Input.GetKey(KeyCode.S))
        {
            Debug.Log("User's Input is: S");
            inputVector += Vector2.down;
        }
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("User's Input is: A");
            inputVector += Vector2.left;
        }
        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("User's Input is: D");
            inputVector += Vector2.right;
        }

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
