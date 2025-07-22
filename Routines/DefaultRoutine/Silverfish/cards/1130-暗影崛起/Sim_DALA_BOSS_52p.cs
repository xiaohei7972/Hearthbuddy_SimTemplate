namespace HREngine.Bots
{
	class Sim_DALA_BOSS_52p : SimTemplate //* 守住大门 Hold the Gates!
//<b>Hero Power</b>Give a minion +2 Health and <b>Taunt</b>.
//<b>英雄技能</b>使一个随从获得+2生命值和<b>嘲讽</b>。 
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