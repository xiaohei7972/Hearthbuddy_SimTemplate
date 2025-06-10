namespace HREngine.Bots
{
	class Sim_DALA_BOSS_14p : SimTemplate //* 客人点单 Order Up!
//<b>Hero Power</b>Summon a 2/2 Kind Waitress.
//<b>英雄技能</b>召唤一个2/2的友善的服务员。 
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