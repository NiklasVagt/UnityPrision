using System;
using System.Collections;
using UnityEngine;

public class SwordSlash : MonoBehaviour
{
    public GameObject Sword;
    public IEnumerator Slash(Vector2 parentPosition)
    {
        Sword.GetComponent<Animator>().Play("SwordSlash");   
        yield return new WaitForSeconds(0.25f);
        Sword.GetComponent<Animator>().Play("New State");
    }
}
