namespace HREngine.Bots
{
	class Sim_TRL_509t : SimTemplate //* 香蕉 Bananas
//Give a minion +1/+1.
//使一个随从获得+1/+1。 
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