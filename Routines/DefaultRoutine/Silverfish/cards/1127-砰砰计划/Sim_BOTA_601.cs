namespace HREngine.Bots
{
	class Sim_BOTA_601 : SimTemplate //* 相位传送门 Phasing Portal
//Choose a minion.Put it on the bottom of your deck.
//选择一个随从。将该随从置入你的牌库底。 
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