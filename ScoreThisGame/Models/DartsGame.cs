using System;

namespace ScoreThisGame
{
	public class DartsGame
	{
		private int gameID; 
		private string gameType;
		private string winner; 

		public DartsGame ()
		{
			this.gameID = 0;
			this.gameType = null;
			this.winner = string.Empty;
		}

		public DartsGame (int id, string type)
		{
			this.gameID = id; 
			this.gameType = type;
			this.winner = ""; 
		}
	}
}

