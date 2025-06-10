namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_25p : SimTemplate //* 甲虫奔踏 Beetle Stampede
//[x]<b>Hero Power</b>Summon aPlated Beetle.
//<b>英雄技能</b>召唤一只硬壳甲虫。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}