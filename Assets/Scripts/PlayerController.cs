using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Movement tuning
    public float speed = 20;
    public float turnSpeed = 100;
    
    //Input System
    public InputAction moveAction;

    //Current Move Input (x,y)
    private Vector2 moveInput;

    private void OnEnable()
    {
        //Enable the Move Action
        moveAction.Enable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x * moveInput.y);
    }
}
