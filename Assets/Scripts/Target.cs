using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float Speed;
    [SerializeField] int Health;
    void FixedUpdate()
    {
        rb.velocity = -transform.forward*Speed;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if(Health<= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Damager") || collision.transform.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
