using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f; 
    [SerializeField] private float jumpForce = 5f;

    public void MoveBall(Vector2 input){
        Vector3 inputXZPlane = new (input.x,0,input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
    //Bonus Jump Feature
    public void BallJump(){
        sphereRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
