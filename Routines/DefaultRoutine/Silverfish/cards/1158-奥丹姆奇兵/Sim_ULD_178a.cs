namespace HREngine.Bots
{
	class Sim_ULD_178a : SimTemplate //* 希亚玛特之风 Siamat's Wind
//Give Siamat <b>Windfury</b>.
//使希亚玛特获得<b>风怒</b>。 
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