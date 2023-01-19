using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Player Stats
    [SerializeField, Tooltip("How fast the player walks.")]
    private float moveSpeed = 1f;

    // Components - These are attached in the Inspector
    private Rigidbody rb;

    // Player Input Action Asset
    private PlayerInputs playerInputs;

    // Used to move the player from movement input action
    private Vector3 moveVector;

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
        // When the player is moving, update the move vector
        playerInputs.Default.Walk.performed += ctx => { moveVector = new Vector3(ctx.ReadValue<Vector2>().x, 0f, ctx.ReadValue<Vector2>().y); };
        playerInputs.Default.Walk.canceled += ctx => { moveVector = Vector3.zero; };

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.AddForce(moveVector * moveSpeed, ForceMode.Impulse);
    }

    /// <summary>
    /// This function is used to test inputs from an Input Action Asset.
    /// Gets InputAction Callback Context and displays input action name.
    /// </summary>
    /// <param name="ctx"></param>
    private void InputTester(InputAction.CallbackContext ctx)
    {
        Debug.Log($"{ctx.action.name}");
    }
}
