using UnityEngine;

namespace Assets.Scripts
{
	public class Ball : MonoBehaviour
	{
		public float Speed;

		public void Start()
		{

		}

		public void Update ()
		{
			if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
			{
				Vector3 position = transform.position + new Vector3(-Speed*Time.deltaTime, 0, 0);
				transform.position = position;
			}
			else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
			{
				Vector3 position = transform.position + new Vector3(Speed * Time.deltaTime, 0, 0);
				transform.position = position;
			}
		}

	}
}
