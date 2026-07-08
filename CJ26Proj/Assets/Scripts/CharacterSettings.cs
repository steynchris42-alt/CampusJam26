using UnityEngine;

 abstract public class CharacterSettings : MonoBehaviour
   {
    abstract protected Rigidbody Rigbod { get; }
    abstract protected float _MoveSpeed { get; }
     abstract protected float _MoveSpeed_Inc1 {  get; }
   abstract protected float _MoveSpeed_Inc2 {  get; }
    }
