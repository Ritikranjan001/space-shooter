using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int Damage;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<Target>())
        {
            collision.transform.GetComponent<Target>().TakeDamage(Damage);
        }
        Destroy(this.gameObject);
    }
}
