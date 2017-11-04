using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.01f;

	private Animator animator;

	private void Awake() {
		animator = GetComponent<Animator>();
	}

	private void FixedUpdate () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			animator.SetTrigger("GoUp");
        	Move(new Vector2(0, 1));
    	} else if (Input.GetKey(KeyCode.DownArrow)) {
			animator.SetTrigger("GoDown");
        	Move (new Vector2(0, -1));
    	} else if (Input.GetKey(KeyCode.RightArrow)) {
			animator.SetTrigger("GoRight");
			Move (new Vector2(1, 0));
		} else if (Input.GetKey(KeyCode.LeftArrow)) {
			animator.SetTrigger("GoLeft");
			Move (new Vector2(-1, 0));
		}
	}

	private void Move(Vector2 direction) {
		transform.Translate (direction * speed);
	}
}
