namespace HREngine.Bots
{
	class Sim_ULD_178a2 : SimTemplate //* 希亚玛特之盾 Siamat's Shield
//Give Siamat<b>Divine Shield</b>.
//使希亚玛特获得<b>圣盾</b>。 
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