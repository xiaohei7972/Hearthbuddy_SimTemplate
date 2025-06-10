namespace HREngine.Bots
{
	class Sim_DALA_BOSS_14px : SimTemplate //* 客人点单 Order Up!
//<b>Hero Power</b>Summon two 2/2 Kind Waitresses.
//<b>英雄技能</b>召唤两个2/2的友善的服务员。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_OR_ENEMY_HERO),
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}