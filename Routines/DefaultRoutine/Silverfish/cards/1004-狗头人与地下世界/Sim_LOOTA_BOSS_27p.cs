namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_27p : SimTemplate //* 硬化蜡像 Harden Sculpture
//<b>Hero Power</b>Summon a copy of a minion.
//<b>英雄技能</b>召唤一个随从的复制。 
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