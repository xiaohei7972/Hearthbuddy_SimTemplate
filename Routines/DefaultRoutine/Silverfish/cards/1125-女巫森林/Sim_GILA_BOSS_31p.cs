namespace HREngine.Bots
{
	class Sim_GILA_BOSS_31p : SimTemplate //* 分裂 Splinter
//<b>Hero Power</b>Take 2 damage.Summon a 2/2 Treant.
//<b>英雄技能</b>受到2点伤害。召唤一个2/2的树人。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}