using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGraphics : MonoBehaviour
{
    [SerializeField] CharacterMotor motor;
    public float range = .5f;
    public float freq = 3f;

    void Update()
    {
        if (motor.IsMoving()) {
            float offset = Mathf.Sin(Time.time * freq);
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y + range * offset, transform.position.z), .1f);
        }
        if (motor.GetMoveVector().x < 0)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(-1, 1, 1), .2f);
        }
        else if (motor.GetMoveVector().x > 0)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1, 1), .2f);
        }
    }


}
