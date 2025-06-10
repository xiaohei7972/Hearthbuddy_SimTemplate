namespace HREngine.Bots
{
	class Sim_GILA_BOSS_27t : SimTemplate //* 融合 Amalgamate
//Destroy all minions. Summon an Amalgamation with the combinedAttack and Health.
//消灭所有随从。召唤一个融合怪，其攻击力与生命值是所有消灭随从的总和。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 1),
            };
        }
	}
}