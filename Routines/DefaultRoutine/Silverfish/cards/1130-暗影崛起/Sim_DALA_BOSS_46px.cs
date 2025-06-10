namespace HREngine.Bots
{
	class Sim_DALA_BOSS_46px : SimTemplate //* 泡泡护盾 Protective Bubble
//<b>Hero Power</b>Give all your minions <b>Divine Shield</b>.
//<b>英雄技能</b>使你所有的随从获得<b>圣盾</b>。 
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