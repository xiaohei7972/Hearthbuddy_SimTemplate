namespace HREngine.Bots
{
	class Sim_DALA_802 : SimTemplate //* 随机猎人套牌 Random Hunter Deck
//Start the run with a deck of random cards.
//用一副随机套牌开始冒险。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}