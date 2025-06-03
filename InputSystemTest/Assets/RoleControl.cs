using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RoleControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        Debug.Log("Jump");
        if (ctx.phase == InputActionPhase.Started)
        {
            Debug.Log("Started");
        }
        else if (ctx.phase == InputActionPhase.Canceled)
        {
            Debug.Log("Canceled");
        }
        else if (ctx.phase == InputActionPhase.Disabled)
        {
            Debug.Log("Disabled");
        }
        else if (ctx.phase == InputActionPhase.Performed)
        {
            Debug.Log("Performed");
        }
        else if (ctx.phase == InputActionPhase.Waiting)
        {
            Debug.Log("Waiting");
        }
    }
}







