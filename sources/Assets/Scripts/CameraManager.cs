using UnityEngine;

namespace Assets.Scripts
{
	public class CameraManager : MonoBehaviourBase
	{
		public float Speed;

		public void Update()
		{
			Vector3 position = transform.position + new Vector3(0, -Speed*Time.deltaTime, 0);
			transform.position = position;
		}
	}
}
