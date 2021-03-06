﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSoldier : BattleSprite {
	public Animator mAnimation;
//	public Camera mCamera;
	private KeyCode curKey;
	private Vector3 curSpeed;
	private FightProperty fightProperty;
	void Start(){
		Init();
	}
	public void Init(){
		fightProperty = new FightProperty();
		fightProperty.hp = 1000;
		fightProperty.attack = 10;
		fightProperty.speed = 10;
	}
	public void Move(Vector3 dir){
		mAnimation.Play ("Run");
//		mAnimation.SetBool ("Grounded_b",true); 
//		mAnimation.SetFloat ("Speed_f",0.5f); 
		curSpeed = dir.normalized * fightProperty.speed;
	}
	public void Stop(){
//		mAnimation.SetFloat ("Speed_f",0); 
		mAnimation.CrossFade("Idle",0.2f);
		curSpeed = Vector3.zero;
	}
	public void OnGUI(){
//		if (GUI.Button (new Rect (100, 100, 100, 100), "Move")) {
//			Move();
//		}
	}
	void FixedUpdate(){
		if (Input.GetKeyDown (KeyCode.W)) {
			transform.forward = Vector3.forward;
			curKey = KeyCode.W;
			Move(transform.forward);
		}else if (Input.GetKeyDown (KeyCode.A)) {
			transform.forward = Vector3.left;
			curKey = KeyCode.A;
			Move(transform.forward);
		}else if (Input.GetKeyDown (KeyCode.S)) {
			transform.forward = Vector3.back;
			curKey = KeyCode.S;
			Move(transform.forward);
		}else if (Input.GetKeyDown (KeyCode.D)) {
			transform.forward = Vector3.right;
			curKey = KeyCode.D;
			Move(transform.forward);
		}
		if (Input.GetKeyUp (KeyCode.W)) {
			UpdateMove();
		}else if (Input.GetKeyUp (KeyCode.A)) {
			UpdateMove();
		}else if (Input.GetKeyUp (KeyCode.S)) {
			UpdateMove();
		}else if (Input.GetKeyUp (KeyCode.D)) {
			UpdateMove();
		}
		if (!curSpeed.Equals(Vector3.zero)) {
			transform.position = transform.position + curSpeed * Time.deltaTime;
		}
	}
	public void UpdateMove(){
		if(!(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))){
			Stop();
		}else{
			if (Input.GetKey (KeyCode.W)) {
				transform.forward = Vector3.forward;
				curKey = KeyCode.W;
				Move(transform.forward);
			}else if (Input.GetKey (KeyCode.A)) {
				transform.forward = Vector3.left;
				curKey = KeyCode.A;
				Move(transform.forward);
			}else if (Input.GetKey (KeyCode.S)) {
				transform.forward = Vector3.back;
				curKey = KeyCode.S;
				Move(transform.forward);
			}else if (Input.GetKey (KeyCode.D)) {
				transform.forward = Vector3.right;
				curKey = KeyCode.D;
				Move(transform.forward);
			}
		}
	}
}
