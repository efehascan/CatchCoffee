using System;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float Speed = 6.0f;
    
    float horizontalInput;
    float verticalInput;
    
    public Transform transform;
    public Transform transformG;

    private void Awake()
    {
        Debug.Log("PlayerMovement Awake");
        
        transformG = GetComponent<Transform>();
    }

    private void OnEnable()
    {
        Debug.Log("PlayerMovement OnEnable");
    }

    void Start()
    {
        Debug.Log("PlayerMovement Start");
    }
    
    void Update()
    {
        MovePlayer();
        
    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transformG.position += new Vector3(horizontalInput * Speed * Time.deltaTime, 0, verticalInput * Speed * Time.deltaTime);
        
    }
}
