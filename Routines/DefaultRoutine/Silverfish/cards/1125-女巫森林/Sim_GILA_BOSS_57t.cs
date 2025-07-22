namespace HREngine.Bots
{
	class Sim_GILA_BOSS_57t : SimTemplate //* 开坟验尸 Shallow Graves
//Summon 7 random minions that died this_game.
//随机召唤七个在本局对战中死亡的随从。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_DIED_THIS_GAME),
            };
        }
	}
}