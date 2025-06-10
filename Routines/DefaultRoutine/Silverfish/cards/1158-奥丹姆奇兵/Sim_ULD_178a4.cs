namespace HREngine.Bots
{
	class Sim_ULD_178a4 : SimTemplate //* 希亚玛特之速 Siamat's Speed
//Give Siamat <b>Rush</b>.
//使希亚玛特获得<b>突袭</b>。 
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