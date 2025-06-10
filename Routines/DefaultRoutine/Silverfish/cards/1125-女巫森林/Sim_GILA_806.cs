namespace HREngine.Bots
{
	class Sim_GILA_806 : SimTemplate //* 黄铜灯笼 Brass Lantern
//<b>Discover</b> a copy of a card in your deck. Repeat this 2 more times.
//<b>发现</b>你牌库中一张牌的复制。再重复两次。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}