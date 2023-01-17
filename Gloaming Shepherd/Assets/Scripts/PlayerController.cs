using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Player Input Action Asset
    private PlayerInputs playerInputs;

    private void Awake()
    {
        playerInputs = new PlayerInputs();
    }

    private void OnEnable()
    {
        playerInputs.Default.Enable();
    }

    private void OnDisable()
    {
        playerInputs.Default.Disable();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    /*
    /// <summary>
    /// This function is used to test inputs from an Input Action Asset
    /// </summary>
    /// <param name="ctx"></param>
    private void InputTester(InputAction.CallbackContext ctx)
    {
        Debug.Log($"{ctx.action.name}");
    }
    */
}
