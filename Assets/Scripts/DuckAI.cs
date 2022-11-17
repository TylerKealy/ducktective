using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAI : MonoBehaviour
{
    [SerializeField] CharacterMotor motor;
    public float refreshRate = 1f;
    private float nextRefreshTime = 0f;
    private Vector2 moveVector;
    private Vector2 startPos;
    private void Start()
    {
        refreshRate = refreshRate + Random.Range(-.3f, .3f);
        startPos = transform.position;
    }

    public void GenerateMoveVector() {
        float dist = Vector2.Distance(transform.position, Vector2.zero);
        float rand = Random.Range(0, 100f);
        if (dist < 5f)
        {
            moveVector = Random.insideUnitCircle;
        }
        else {
            moveVector = startPos - (Vector2)(transform.position) + (1.5f * Random.insideUnitCircle);
            if (rand < 25)
            {
                moveVector = Vector2.zero;
            }
        }
        nextRefreshTime = Time.time + refreshRate;

    }

    private void Update()
    {
        if(Time.time > nextRefreshTime)
        {
            GenerateMoveVector();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        motor.SetMoveVector(moveVector.normalized);
    }
}
