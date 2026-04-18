using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class AnimationAndMovementController : MonoBehaviour
{
    // Action Map for the player character
    PlayerInput playerInput;
    CharacterController characterController;
    Animator animator;
    int isWalkingHash = Animator.StringToHash("isWalking");

    Vector2 currentMovementInput;
    // -1 is backward, +1 is walk speed
    float currentSpeed = 0.0f;
    float goalSpeed = 0.0f;
    bool isMovementPressed;
    float rotationDegreesPerSecond = 180.0f;
    float walkSpeed = 1.0f;

    void Awake()
    {
        playerInput = new PlayerInput();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        playerInput.CharacterControls.Move.started += onMovementInput;
        playerInput.CharacterControls.Move.performed += onMovementInput;
        playerInput.CharacterControls.Move.canceled += onMovementInput;
    }

    void onMovementInput (InputAction.CallbackContext context)
    {
                // +y is forward, -y is backward, +x is right, -x is left
        currentMovementInput = context.ReadValue<Vector2>();

        goalSpeed = currentMovementInput.y;
        currentSpeed = goalSpeed;

        animator.SetBool(isWalkingHash, Mathf.Abs(currentSpeed) > 0.01f);
    }

    void handleRotation()
    {
        Vector3 currentEulerAngles = characterController.transform.localEulerAngles;
        characterController.transform.Rotate(0,
            currentMovementInput.x * rotationDegreesPerSecond * Time.deltaTime, 
            0,
            Space.Self);
    }

    void OnEnable()
    {
        playerInput.CharacterControls.Enable();
    }

    void OnDisable()
    {
        playerInput.CharacterControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        handleRotation();
        characterController.SimpleMove(transform.forward * currentSpeed * walkSpeed);
    }
}
