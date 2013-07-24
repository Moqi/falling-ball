using UnityEngine;

namespace Assets.Scripts
{
	public class BarsGenerator : MonoBehaviourBase
	{
		private float _lastY;
		private TimeEvent _nextBarLineTime;

		public float Distance;
		public Transform[] BarPrefabs;
		public float NextBarLineDelay;

		public void Start ()
		{
			_nextBarLineTime = new TimeEvent(NextBarLineDelay);
			GenerateNextLine();
			GenerateNextLine();
			GenerateNextLine();
			GenerateNextLine();
			GenerateNextLine();
			GenerateNextLine();
			GenerateNextLine();
		}
	
		public void Update () 
		{
			if(_nextBarLineTime.PopIsOccurred())
				GenerateNextLine();
		}

		private void GenerateNextLine()
		{
			Transform bar = Instantiate<Transform>(GameRandom.NextItem(BarPrefabs));
			_lastY -= Distance;
			bar.SetY(_lastY);
			bar.parent = Transform;
		}
	}
}
