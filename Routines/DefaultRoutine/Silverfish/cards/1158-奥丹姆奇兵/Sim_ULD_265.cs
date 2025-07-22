namespace HREngine.Bots
{
	class Sim_ULD_265 : SimTemplate //* 防腐仪式 Embalming Ritual
//Give a minion <b>Reborn</b>.
//使一个随从获得<b>复生</b>。 
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