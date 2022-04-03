using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSetup : MonoBehaviour
{
    Vector2 diffBallAndPedal;
    PedalControl pedalControl = new PedalControl();
    private bool stateMouse = false;
    void Start()
    {
        diffBallAndPedal = transform.position - pedalControl.transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !stateMouse){
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 15f);
            stateMouse = true;
        }

        if (!stateMouse){
            StabilizeBallPedala(out var pedalPosition);
        }
    }

    private void StabilizeBallPedala(out Vector2 pedalPosition)
    {
        pedalPosition = new Vector2(pedalControl.transform.position.x, pedalControl.transform.position.y);
        transform.position = pedalPosition + diffBallAndPedal;
    }

}
