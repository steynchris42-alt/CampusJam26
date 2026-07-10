using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : CharacterSettings
{
    public Keyboard keyboard;
  
   protected void Start()
    {
        keyboard = Keyboard.current;     
    }
    protected override bool IsMoving()
    {
        if (keyboard.anyKey.isPressed )
        {
            return true;
        }
         return false; 
    }     
    protected override void Moving()
    {
        if (IsMoving() == true)
        {
            if (keyboard.wKey.isPressed) MoveDir = transform.forward;
            if (keyboard.aKey.isPressed) MoveDir = -transform.right;
            if (keyboard.sKey.isPressed) MoveDir = -transform.forward;
            if (keyboard.dKey.isPressed) MoveDir = transform.right;
        }
        else
        {
            MoveDir = Vector3.zero;
            return;
        }
    }
    public void Update()
    {
       
        Moving();
  
    }
    public void FixedUpdate()
    {
        MoveForce = MoveDir * _MoveSpeed;
        Rigbod.AddForce(MoveForce, ForceMode.Force);   
    }
}

/*
 *    if (keyboard.wKey.isPressed || keyboard.aKey.isPressed || keyboard.sKey.isPressed || keyboard.dKey.isPressed)
            {
                Debug.Log(keyboard.wKey.isPressed + ("W"));
                Debug.Log(keyboard.aKey.isPressed + ("a"));
                Debug.Log(keyboard.sKey.isPressed + ("s"));
                Debug.Log(keyboard.dKey.isPressed + ("d"));
            }
*/