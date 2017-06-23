using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interaction : MonoBehaviour
{
//   public abstract void OnUse(); //Think of how this can be realized in various interactions (door e.t.c)
   public   Animator animOnUse;
   public BoxCollider2D SimpleCollider;
   public CapsuleCollider2D InteractionZoneTrigger;

}
