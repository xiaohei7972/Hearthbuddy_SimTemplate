namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_44p : SimTemplate //* 幼龙之息 Baby Breath
//<b>Hero Power</b>Deal 2 damage.
//<b>英雄技能</b>造成2点伤害。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}