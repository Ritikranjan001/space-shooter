using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Gun gun;
    [SerializeField] Rigidbody rb;
    public float speed;
    float VerticalInput;
    float HorizontalInput;
    private Vector3 Movement;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

    }
    private void MovePlayer()
    {
        Movement = Vector3.forward * VerticalInput + Vector3.right * HorizontalInput;
        rb.velocity = Movement * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            gun.PowerUp();
            Destroy(other.gameObject);
        }
    }

}