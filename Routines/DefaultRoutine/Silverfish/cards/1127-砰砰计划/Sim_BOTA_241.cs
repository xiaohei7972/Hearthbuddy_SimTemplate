namespace HREngine.Bots
{
	class Sim_BOTA_241 : SimTemplate //* 生化污染 Contamination
//Give a minion <b>Poisonous</b>.
//使一个随从获得<b>剧毒</b>。 
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