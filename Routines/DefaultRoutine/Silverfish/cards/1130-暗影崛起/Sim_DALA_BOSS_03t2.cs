namespace HREngine.Bots
{
	class Sim_DALA_BOSS_03t2 : SimTemplate //* 兔子戏法 Bunnifitronus
//Transform a random minion into a random critter.
//随机将一个随从变形成为小动物。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 1),
            };
        }
	}
}