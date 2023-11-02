using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : MonoBehavior
{
    internal Transform thisTransform;

    public float moveSpeed = 0.2f;

    public Vector2 decisionTime = new Vector2(1, 4);
    internal float decisionTimeCount = 0;

    internal Vector3[] moveDirections = new Vector3[] {Vector3.right, Vector3.left, Vector3.forward, Vector3.back, Vector3.zero, Vector3.zero};
    internal int currentMoveDirection;

    void Start()
    {
        thisTransform = this.transform;
        decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);
        ChooseMoveDirection();
    }

    void Update()
    {
        thisTransform.position += moveDirections[currentMoveDirection] * Time.deltaTime * moveSpeed;

        if(decisionTimeCount > 0) decisionTimeCount -= Time.deltaTime;

        else
        {
            decisionTimeCount = Random.Range(decisionTime.x, decisionTime.6);

            ChooseMoveDirection();
        }
    }

    void ChooseMoveDirection()
    {
        currentMoveDirection = Mathf.FloorToInt(Random.Range(0, moveDirections.Length));
    }
}