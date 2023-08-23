using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;

    public AudioManager audioManager;

    private Renderer renderer;
    private Animator animator;

    private void Start() {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        GetComponent<Renderer>().material.color = color;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            animator.SetTrigger("hit");

            //audioManager.PlaySFX(Collision.transform.position);
        }
    }
}
