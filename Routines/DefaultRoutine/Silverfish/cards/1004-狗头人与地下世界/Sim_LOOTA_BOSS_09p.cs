namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_09p : SimTemplate //* 冻结 Freeze
//<b>Hero Power</b><b>Freeze</b> a minion.
//<b>英雄技能</b><b>冻结</b>一个随从。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}