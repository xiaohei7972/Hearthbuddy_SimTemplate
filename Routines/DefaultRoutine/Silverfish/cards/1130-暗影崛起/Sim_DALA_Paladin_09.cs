namespace HREngine.Bots
{
	class Sim_DALA_Paladin_09 : SimTemplate //* 白银之手 The Silver Hand
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