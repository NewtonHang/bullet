using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public float life = 3;

   void Awake()
   {
        Destroy(gameObject, life);
   }

   void OnCollisionEnter(Collision collision)
   {
    Destroy(collision.gameObject);
    Destroy(gameObject);
   }
      void Start()
   {
      Destroy(gameObject, 10f);
   }
   public void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         other.GetComponent<PlayerStats>().TakeDamage(damage);
         Destroy(gameObject);
      }
   }

}
