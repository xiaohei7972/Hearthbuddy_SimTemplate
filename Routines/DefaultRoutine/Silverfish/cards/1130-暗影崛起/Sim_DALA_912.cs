namespace HREngine.Bots
{
	class Sim_DALA_912 : SimTemplate //* 生力军 Brood
//Fill the tavern with new minions.
//用新的随从占满全场。 
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