﻿using UnityEngine;

namespace Assets.Scripts
{
	public abstract class MonoBehaviourBase : MonoBehaviour
	{

		private Transform _transform;
		public Transform Transform
		{
			get
			{
				if (_transform == null)
					_transform = transform;
				return _transform;
			}
		}

		private Camera _camera;
		public Camera Camera
		{
			get
			{
				if (_camera == null)
					_camera = camera;
				return _camera;
			}
		}

		protected T Instantiate<T>(Object obj) where T : Object
		{
			return (T)Instantiate(obj);
		}

		protected T Instantiate<T>(Object obj, Vector3 position) where T : Object
		{
			return (T) Instantiate(obj, position, new Quaternion());
		}

		protected T Instantiate<T>(Object obj, Vector3 position, Quaternion rotation) where T : Object
		{
			return (T) Instantiate(obj, position, rotation);
		}

	}
}
