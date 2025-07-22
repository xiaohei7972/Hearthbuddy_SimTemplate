namespace HREngine.Bots
{
	class Sim_GILA_BOSS_43t : SimTemplate //* 自掘坟墓 Grave Mistake
//Trigger all minions' <b>Deathrattles</b> twice.
//触发所有随从的<b>亡语</b>两次。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}