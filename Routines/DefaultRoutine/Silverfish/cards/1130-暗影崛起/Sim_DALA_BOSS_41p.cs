namespace HREngine.Bots
{
	class Sim_DALA_BOSS_41p : SimTemplate //* 召唤伙伴 Summon Companion
//<b>Hero Power</b>Summon a randomAnimal Companion.
//<b>英雄技能</b>随机召唤一个动物伙伴。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_OR_ENEMY_HERO),
            };
        }
	}
}