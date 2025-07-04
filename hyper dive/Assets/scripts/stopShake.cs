﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopShake : MonoBehaviour
{

	Vector3 cameraInitialPosition;
	public float shakeMagnetude = 0f, shakeTime = 0f;
	public Camera mainCamera;

	public void Update()
	{
		//ShakeIt();
		StopCameraShaking();

	}
	public void ShakeIt()
	{
		cameraInitialPosition = mainCamera.transform.position;
		InvokeRepeating("StartCameraShaking", 0f, 0.005f);
		Invoke("StopCameraShaking", shakeTime);
	}

	void StartCameraShaking()
	{
		float cameraShakingOffsetX = Random.value * shakeMagnetude * 2 - shakeMagnetude;
		//float cameraShakingOffsetY = Random.value * shakeMagnetude * 2 - shakeMagnetude;
		Vector3 cameraIntermadiatePosition = mainCamera.transform.position;
		cameraIntermadiatePosition.x += cameraShakingOffsetX;
		//cameraIntermadiatePosition.y += cameraShakingOffsetY;
		mainCamera.transform.position = cameraIntermadiatePosition;
	}

	void StopCameraShaking()
	{
		CancelInvoke("StartCameraShaking");
		mainCamera.transform.position = cameraInitialPosition;
	}

}