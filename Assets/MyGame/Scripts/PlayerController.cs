using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float Speed = 100f;
    [SerializeField]
    private float Turn = 100f;
    [SerializeField]
    private float Break = 50f;
    [SerializeField]
    private GameObject BreakEffect;
    private float inputUpDown;
    private float inputLeftRight;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        inputUpDown = Input.GetAxis("Vertical");
        inputLeftRight = Input.GetAxis("Horizontal");
        CarMove();
        CarTurn();
        if(inputUpDown > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            CarBreak();
        }
    }
    public void CarMove()
    {
        rb.AddRelativeForce(Vector3.forward*inputUpDown*Speed);
        BreakEffect.SetActive(false);
    }
    public void CarTurn()
    {
        Quaternion re= Quaternion.Euler(Vector3.up*inputLeftRight*Turn*Time.deltaTime);
        rb.MoveRotation(rb.rotation * re);
    }
    public void CarBreak()
    {
        if(rb.velocity.z!=0)
        {
            rb.AddRelativeForce(-Vector3.forward * Break);
            BreakEffect.SetActive(true);
        }
    }
}
