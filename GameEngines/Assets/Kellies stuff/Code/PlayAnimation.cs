using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
 public Animator anim;

 public void playAnimation()
 {
  anim.enabled = true;
  anim.Play("ButtonPress1");
 }

 public void stopAnimation()
 {
  anim.enabled = false;
 }
}
