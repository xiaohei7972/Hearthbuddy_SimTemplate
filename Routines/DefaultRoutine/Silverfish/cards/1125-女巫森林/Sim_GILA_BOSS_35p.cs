namespace HREngine.Bots
{
	class Sim_GILA_BOSS_35p : SimTemplate //* 嗜血渴望 Bloodthirst
//<b>Hero Power</b>Give a friendly minion <b>Lifesteal</b>.
//<b>英雄技能</b>使一个友方随从获得<b>吸血</b>。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}