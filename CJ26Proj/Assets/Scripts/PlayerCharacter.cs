using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter : CharacterSettings
{
    public Keyboard keyboard;
    public bool Is_Player_Moving;
    public bool Is_Player_Sprinting;

    [SerializeField] private Coroutine Sprinting_Cor;
    IEnumerator ISprinting()
    {
        
        _MoveSpeed = x_MoveSpeed;
        Is_Player_Sprinting = true;
        yield return new WaitForSeconds(5);
        _MoveSpeed = Base_MoveSpeed;
        Is_Player_Sprinting = false;
        yield return new WaitForSeconds(5);
        Sprinting_Cor = null;
    }
   protected void Start()
    {
        keyboard = Keyboard.current;     
    }
    protected override bool IsMoving()
    {
        if (keyboard.anyKey.isPressed )
        {
            Is_Player_Moving = true;
            return true;
        }
        Is_Player_Moving = false;
        return false; 
    }
    protected override bool IsSprinting()
    {
       return Is_Player_Sprinting;
    }
    protected override void Moving()
    {
  
        if (IsMoving() == true)
        {
            if (keyboard.wKey.isPressed) MoveDir = transform.forward;
            if (keyboard.shiftKey.isPressed && keyboard.wKey.isPressed && Sprinting_Cor == null)
            {
                Sprinting_Cor = StartCoroutine(ISprinting());
            }
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
   protected override void Die()
    {
        Time.timeScale = 0.0f;
    }

    public void Update()
    {
       
        Moving();
       // Sprinting();

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