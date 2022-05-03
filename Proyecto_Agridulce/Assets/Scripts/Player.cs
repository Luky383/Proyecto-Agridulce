using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour 
{
	private Animator _anim;
	[SerializeField]
	private float speed;
	//private Vector3 moveDirection = Vector3.zero;

	void Start () 
	{
		_anim = gameObject.GetComponentInChildren<Animator>();
	}

	void Update ()
	{
		/*if(Input.GetKey ("w")) {
			_anim.SetInteger ("AnimationPar", 1);
		}  else {
			_anim.SetInteger ("AnimationPar", 0);
		}*/
		transform.position += transform.forward * speed * Time.deltaTime;
	}
}
