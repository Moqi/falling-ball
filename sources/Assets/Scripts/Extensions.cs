using UnityEngine;

namespace Assets.Scripts
{
	public static class Extensions
	{
		#region Position

		public static void SetPosition(this Transform transform, float x, float y, float z)
		{
			transform.position = new Vector3(x, y, z);
		}

		public static void SetPosition(this Transform transform, float x, float y)
		{
			transform.position = new Vector3(x, y, transform.position.z);
		}

		public static void SetPosition(this Transform transform, Vector2 point, float z)
		{
			transform.position = new Vector3(point.x, point.y, z);
		}

		public static void SetPosition(this Transform transform, Vector2 point)
		{
			transform.position = new Vector3(point.x, point.y, transform.position.z);
		}

		public static Vector2 Position2(this Transform transform)
		{
			return transform.position;
		}

		public static void SetLocalX(this Transform transform, float x)
		{
			transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.y);
		}

		public static void SetY(this Transform transform, float y)
		{
			transform.position = new Vector3(transform.position.x, y, transform.position.z);
		}

		public static void SetZ(this Transform transform, float z)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, z);
		}

		public static void SetLocalZ(this Transform transform, float z)
		{
			transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
		}

		public static Vector2 MakePixelPerfect(this Vector2 position)
		{
			return new Vector2((int) position.x, (int) position.y);
		}

		#endregion

		#region Roatation

		public static Vector2 Rotate(this Vector2 vector, float angle)
		{
			return Quaternion.AngleAxis(angle, Vector3.forward) * vector;
		}

		public static void SetRotation(this Transform transform, float angle)
		{
			transform.rotation = new Quaternion();
			transform.Rotate(Vector3.forward, angle);
		}

		public static float Angle(this Vector2 direction)
		{
			return direction.y > 0
				       ? Vector2.Angle(new Vector2(1, 0), direction)
				       : -Vector2.Angle(new Vector2(1, 0), direction);
		}

		#endregion

		public static Color SetA(this Color color, float a)
		{
			return new Color(color.r, color.g, color.b, a);
		}

	}
}
