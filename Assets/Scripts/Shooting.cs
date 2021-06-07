using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    void Update()
    {
      
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);

        
        if(hit && hit.collider.gameObject.CompareTag("Enemy"))
        {
            Destroy(hit.collider.gameObject);
            Debug.Log("убил!");
        }
        
    }
}
