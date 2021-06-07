using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    Animator animator;
    private Vector3 direction;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speed * Time.deltaTime * -1, 0, 0);
            direction = Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            direction = Vector3.right;
        }
       // animator.SetFloat("speed", Mathf.Abs(direction.x));
    }
}