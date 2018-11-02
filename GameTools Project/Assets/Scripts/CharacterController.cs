using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {


    private float turn;
    private float move;
    private bool examine;
    private bool acuse;
    private bool fall;

    private MoCapMan character;

    void Start()
    {
        character = GetComponent<MoCapMan>();
    }

    void FixedUpdate()
    {
        turn = Input.GetAxis("Horizontal");
        move = Input.GetAxis("Vertical");
        acuse = Input.GetButtonDown("Jump");
        examine = Input.GetKeyDown(KeyCode.E);
        fall = Input.GetKeyDown(KeyCode.F);

        character.Move(turn, move, examine, acuse, fall);
    }
}
