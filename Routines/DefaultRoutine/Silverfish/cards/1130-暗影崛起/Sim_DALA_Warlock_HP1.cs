namespace HREngine.Bots
{
	class Sim_DALA_Warlock_HP1 : SimTemplate //* 痛苦分裂 Pain Split
//<b>Hero Power</b>Take $2 damage.Deal $2 damage.
//<b>英雄技能</b>受到$2点伤害。造成$2点伤害。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}