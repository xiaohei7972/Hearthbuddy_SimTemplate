namespace HREngine.Bots
{
	class Sim_DALA_BOSS_63px : SimTemplate //* 欺凌弱小 Bully
//<b>Hero Power</b>Deal $4 damage to a damaged minion.
//<b>英雄技能</b>对一个受伤的随从造成$4点伤害。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}