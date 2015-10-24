using System;

namespace ScoreThisGame
{
	public class Dart
	{
		private int dartNumber; 
		private int numberHit;

		public Dart (int id, int value)
		{
			this.dartNumber = id; 
			this.numberHit = value;
		}
	}
}

