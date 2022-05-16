using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody), typeof(Animator))]
public class Player : MonoBehaviour 
{
	private Animator _anim;
	[SerializeField]
	private float speed;

	Rigidbody _myRigidBody;
	ForceMode _myForceMode = ForceMode.Impulse;
	[SerializeField]
	float _jumpForce;

	//private Vector3 moveDirection = Vector3.zero;

	void Start () 
	{
		_anim = gameObject.GetComponentInChildren<Animator>();
		_myRigidBody = gameObject.GetComponentInChildren<Rigidbody>();
	}

	void Update ()
	{
		/*if(Input.GetKey ("w")) {
			_anim.SetInteger ("AnimationPar", 1);
		}  else {
			_anim.SetInteger ("AnimationPar", 0);
		}*/
		PermaRunning();
	}

	void PermaRunning()
	{
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	public void Jump() //Jump que esté separado del railschanger
	{
		_myRigidBody.AddForce(Vector3.up * _jumpForce, _myForceMode);
	}
}
