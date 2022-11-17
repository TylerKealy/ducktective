using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour
{
    public bool myDuck = true;
    public float speed;
    private CharacterController controller;
    private Vector2 moveVector;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    private void FixedUpdate()
    {
        controller.Move(moveVector.normalized * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (!myDuck) return;
        moveVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) {
            moveVector += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveVector += Vector2.left;

        }
        if (Input.GetKey(KeyCode.S))
        {
            moveVector += Vector2.down;

        }
        if (Input.GetKey(KeyCode.D))
        {
            moveVector += Vector2.right;

        }
    }

    public void SetMoveVector(Vector2 moveVector) {
        this.moveVector = moveVector;
    }

    public bool IsMoving() {
        return Mathf.Abs(moveVector.x) > 0 || Mathf.Abs(moveVector.y) > 0;
    }

    public Vector2 GetMoveVector() {
        return moveVector;
    }
}
