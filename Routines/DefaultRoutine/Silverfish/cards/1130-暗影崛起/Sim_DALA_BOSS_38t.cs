namespace HREngine.Bots
{
	class Sim_DALA_BOSS_38t : SimTemplate //* 派对传送门 PARTY PORTAL!
//Summon a random Partygoer.
//随机召唤一个派对达人。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}