using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] GameObject Bullet;
    [SerializeField] float Force;
    [SerializeField] Transform ShootPoint;
    public int Damage = 1;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody bullet = Instantiate(Bullet , ShootPoint).GetComponent<Rigidbody>();
            bullet.GetComponent<Bullet>().Damage = Damage;
            bullet.AddForce(ShootPoint.forward * Force, ForceMode.Impulse);
        }
    }
    public void PowerUp()
    {
        Damage = 3;
        Invoke(nameof(ResetPower), 20);
    }
    void ResetPower()
    {
        Damage = 1;
    }
}
