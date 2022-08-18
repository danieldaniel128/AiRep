using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    public float SwichDirectionTime;
    [SerializeField] private float _obstacleSpeed;
    private float _swichDirectionTime;
    private int direction=1;//-1 or 1
    Vector3 moveVector;
    void Start()
    {
        _swichDirectionTime = SwichDirectionTime;
        moveVector = transform.TransformDirection(Vector3.left * direction);
    }

    // Update is called once per frame
    void Update()
    {
        MoveObstacle();
    }


    void MoveObstacle() 
    {
        _swichDirectionTime -= Time.deltaTime;
        if (_swichDirectionTime <= 0)
        {
            _swichDirectionTime = SwichDirectionTime;
            direction *= (-1);
            moveVector = transform.TransformDirection(Vector3.left * direction);
        }
        transform.position += moveVector * _obstacleSpeed * Time.deltaTime;
        
        
    
    }

}
