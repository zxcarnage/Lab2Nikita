using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Computer : MonoBehaviour
{
    [SerializeField] private BallMover _ball;
    [SerializeField] private float _computerSpeed;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var movingVector =  new Vector3(transform.position.x, _ball.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, movingVector, _computerSpeed * Time.deltaTime);
    }
}
