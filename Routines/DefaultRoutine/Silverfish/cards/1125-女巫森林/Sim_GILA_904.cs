namespace HREngine.Bots
{
	class Sim_GILA_904 : SimTemplate //* 午夜钟声 Stroke of Midnight
//<b>Echo</b>Destroy a random enemy minion.
//<b>回响</b>随机消灭一个敌方随从。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 1),
            };
        }
	}
}