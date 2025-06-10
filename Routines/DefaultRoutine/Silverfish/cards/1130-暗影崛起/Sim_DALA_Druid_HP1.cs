namespace HREngine.Bots
{
	class Sim_DALA_Druid_HP1 : SimTemplate //* 生命绽放 Lifebloom
//<b>Hero Power</b>Restore a minion to full Health.
//<b>英雄技能</b>为一个随从恢复所有生命值。 
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