using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ai : MonoBehaviour
{
    [SerializeField]
    private int nextMove;
    private Rigidbody2D rigid;
    
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();

        Invoke("Think", 8);
    }

    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(-1, rigid.velocity.y);
    }

    void Think()
    {
        nextMove = Random.Range(-1, 2);

        Invoke("Think", 8);
    }
}
