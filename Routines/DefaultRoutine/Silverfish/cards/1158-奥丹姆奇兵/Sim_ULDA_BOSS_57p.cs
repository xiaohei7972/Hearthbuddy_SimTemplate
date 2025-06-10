namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_57p : SimTemplate //* 泰坦守护兽 Titan's Beast
//[x]<b>Hero Power</b>Set a minion's Attackand Health to 3.
//<b>英雄技能</b>将一个随从的攻击力和生命值变为3。 
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