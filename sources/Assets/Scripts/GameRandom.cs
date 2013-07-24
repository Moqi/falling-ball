using UnityEngine;

namespace Assets.Scripts
{
	public static class GameRandom
	{
		public static Vector2 NextDirection()
		{
			return Quaternion.Euler(0, 0, Random.Range(0, 360))*new Vector2(0, 1);
		}

		public static bool NextBool()
		{
			return Random.Range(0, 2) == 1;
		}

		public static int NextInd(int lenght)
		{
			return Random.Range(0, lenght);
		}

		public static T NextItem<T>(T[] array)
		{
			return array[NextInd(array.Length)];
		}

		public static Vector3 NextVector3(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			return new Vector3(
				Random.Range(minX, maxX + 1),
				Random.Range(minY, maxY + 1),
				Random.Range(minZ, maxZ + 1));
		}

		#region Probability

		public static bool NextProbability(float percent)
		{
			return NextProbabilityInPercent() < percent;
		}

		public static float NextProbability()
		{
			return Random.Range(0.0f, 1.0f);
		}

		public static float NextProbabilityInPercent()
		{
			return Random.Range(0.0f, 100.0f);
		}

		public static float NextNormal2()
		{
			return (NextProbability() + NextProbability())/2.0f;
		}

		#endregion

		#region Border

		private static Vector2 RandomFromLine(Vector2 startPoint, Vector2 finishPoint)
		{
			float n = NextNormal2();
			return Vector2.Lerp(startPoint, finishPoint, n);
		}

		private static Vector2 RandomFromLine(Vector2 startPoint, Vector2 middlePoint, Vector2 finishPoint)
		{
			float len1 = Vector2.Distance(startPoint, middlePoint);
			float len2 = Vector2.Distance(middlePoint, finishPoint);
			float m = len1/(len1 + len2);
			float p = NextNormal2();
			return p <= m
				       ? Vector2.Lerp(startPoint, middlePoint, p/m)
				       : Vector2.Lerp(middlePoint, finishPoint, (p - m)/(1 - m));
		}

		#endregion

	}
}
