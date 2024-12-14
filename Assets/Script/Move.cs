using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;

    [SerializeField] private float speed;

    private float xAxis;
    private float zAxis;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(xAxis,0, zAxis);
        characterController.Move(move*Time.deltaTime*speed);
    }
}
