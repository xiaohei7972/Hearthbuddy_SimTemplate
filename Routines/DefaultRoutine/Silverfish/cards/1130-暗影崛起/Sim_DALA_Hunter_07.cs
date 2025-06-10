namespace HREngine.Bots
{
	class Sim_DALA_Hunter_07 : SimTemplate //* 力量强化 Empowering
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