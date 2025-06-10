namespace HREngine.Bots
{
	class Sim_TRLA_Druid_10 : SimTemplate //* 自然之怒 Nature's Wrath
//
// 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}