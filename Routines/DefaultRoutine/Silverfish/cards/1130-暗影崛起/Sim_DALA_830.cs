namespace HREngine.Bots
{
	class Sim_DALA_830 : SimTemplate //* 情节：终局 Twist - The Finale
//This run has four additional powerful bosses.
//本次冒险中会有四个额外的强大首领。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}