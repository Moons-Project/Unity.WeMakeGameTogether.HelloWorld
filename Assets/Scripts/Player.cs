using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  public float x = 0;
  public float speed = 0.01f;
  private Animator animator;
  private Rigidbody2D body;

  // Start is called before the first frame update
  void Start() {
    animator = this.GetComponent<Animator>();
    body = this.GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update() {
    x = Input.GetAxis("Horizontal");
    animator.SetFloat("x", x);

    var possiton = this.transform.position;
    possiton.x += x * speed;
    this.transform.position = possiton;
    // body.AddForce(new Vector2(x * speed, 0));
  }
}