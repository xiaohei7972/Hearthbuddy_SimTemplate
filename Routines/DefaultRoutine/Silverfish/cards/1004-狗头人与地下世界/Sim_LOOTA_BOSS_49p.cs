namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_49p : SimTemplate //* 黑暗侵蚀 Encroaching Darkness
//<b>Hero Power</b>Summon a 5/5 Darkspawn.
//<b>英雄技能</b>召唤一个5/5的黑暗之子。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}