namespace HREngine.Bots
{
	class Sim_BOTA_317 : SimTemplate //* 天启四骑士 Four Horsemen
//Start Lethal Puzzle 2-7.
//Start Lethal Puzzle 2-7. 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}