namespace HREngine.Bots
{
	class Sim_GILA_821c : SimTemplate //* 疯狂的暴徒 Crazed Mob
//<b>Silence</b> and destroy all enemy minions.
//<b>沉默</b>并消灭所有敌方随从。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}