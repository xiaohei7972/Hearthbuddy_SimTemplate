namespace HREngine.Bots
{
	class Sim_LOOTA_Paladin_14 : SimTemplate //* 白银之手 Silver Hand
//
// 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}