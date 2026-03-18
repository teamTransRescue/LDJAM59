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
    Vector3 currentMovement;
    bool isMovementPressed;
    float rotationFactorPerFrame = 1.0f;

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
        currentMovement.x = currentMovementInput.x;
        currentMovement.z = currentMovementInput.y;
        isMovementPressed = (currentMovementInput.x != 0 || currentMovementInput.y != 0);
        animator.SetBool(isWalkingHash, isMovementPressed);
    }

    void handleRotation()
    {
        Vector3 positionToLookAt;

        positionToLookAt.x = currentMovement.x;
        positionToLookAt.y = 0.0f;
        positionToLookAt.z = currentMovement.z;

        Quaternion currentRotation = transform.rotation;

        if (isMovementPressed)
        {
            Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
            transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, Time.deltaTime * 10);
        }
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
        characterController.Move(currentMovement * Time.deltaTime);
    }
}
